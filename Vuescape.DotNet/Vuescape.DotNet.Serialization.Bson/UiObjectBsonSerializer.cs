// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UiObjectBsonSerializer.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Vuescape.DotNet.Serialization.Bson
{
    using System;
    using System.Diagnostics.CodeAnalysis;

    using MongoDB.Bson;
    using MongoDB.Bson.IO;
    using MongoDB.Bson.Serialization;
    using MongoDB.Bson.Serialization.Serializers;

    using OBeautifulCode.Serialization.Bson;

    using Vuescape.DotNet.Domain;

    using static System.FormattableString;

    /// <summary>
    /// Represents a serializer for <see cref="UiObject"/>.
    /// </summary>
    public class UiObjectBsonSerializer : SerializerBase<UiObject>
    {
        private static readonly StringSerializer AssemblyQualifiedNameSerializer = new StringSerializer();

        private static readonly EnumStringBsonSerializer<UiObjectType> UiObjectTypeSerializer = new EnumStringBsonSerializer<UiObjectType>();

        /// <inheritdoc />
        public override void Serialize(
            BsonSerializationContext context,
            BsonSerializationArgs args,
            UiObject value)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            if (value == null)
            {
                context.Writer.WriteNull();
            }
            else
            {
                context.Writer.WriteStartDocument();

                context.Writer.WriteName(nameof(UiObject.AssemblyQualifiedName));

                AssemblyQualifiedNameSerializer.Serialize(context, args, value.AssemblyQualifiedName);

                context.Writer.WriteName(nameof(UiObject.UiObjectType));

                if (value.UiObjectType == null)
                {
                    context.Writer.WriteNull();
                }
                else
                {
                    UiObjectTypeSerializer.Serialize(context, args, (UiObjectType)value.UiObjectType);
                }

                context.Writer.WriteName(nameof(UiObject.Value));

                if (value.Value == null)
                {
                    context.Writer.WriteNull();
                }
                else
                {
                    var serializer = value.Value.GetType().GetAppropriateSerializer();

                    if (serializer == null)
                    {
                        BsonSerializer.Serialize(context.Writer, value.Value.GetType(), value.Value, args: args);
                    }
                    else
                    {
                        serializer.Serialize(context, args, value.Value);
                    }
                }

                context.Writer.WriteEndDocument();
            }
        }

        /// <inheritdoc />
        [SuppressMessage("StyleCop.CSharp.NamingRules", "SA1305:Field names should not use Hungarian notation", Justification = "Not Hungarian Notation.")]
        public override UiObject Deserialize(
            BsonDeserializationContext context,
            BsonDeserializationArgs args)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            if (context.Reader == null)
            {
                throw new ArgumentException(Invariant($"{nameof(context)}.{nameof(BsonDeserializationContext.Reader)} is null"));
            }

            UiObject result;

            if ((context.Reader.State != BsonReaderState.Type) && (context.Reader.CurrentBsonType == BsonType.Null))
            {
                context.Reader.ReadNull();

                result = null;
            }
            else
            {
                context.Reader.ReadStartDocument();

                var name = context.Reader.ReadName();

                if (name != nameof(UiObject.AssemblyQualifiedName))
                {
                    throw new InvalidOperationException(Invariant($"Expected name token '{nameof(UiObject.AssemblyQualifiedName)}'."));
                }

                var assemblyQualifiedName = AssemblyQualifiedNameSerializer.Deserialize(context, args);

                name = context.Reader.ReadName();

                if (name != nameof(UiObject.UiObjectType))
                {
                    throw new InvalidOperationException(Invariant($"Expected name token '{nameof(UiObject.UiObjectType)}'."));
                }

                UiObjectType? uiObjectType = null;

                if (context.Reader.CurrentBsonType == BsonType.Null)
                {
                    context.Reader.ReadNull();
                }
                else
                {
                    uiObjectType = UiObjectTypeSerializer.Deserialize(context, args);
                }

                name = context.Reader.ReadName();

                if (name != nameof(UiObject.Value))
                {
                    throw new InvalidOperationException(Invariant($"Expected name token '{nameof(UiObject.Value)}'."));
                }

                object value = null;

                if (context.Reader.CurrentBsonType == BsonType.Null)
                {
                    context.Reader.ReadNull();
                }
                else
                {
                    var valueType = ((UiObjectType)uiObjectType).GetObjectType(assemblyQualifiedName);

                    var serializer = valueType.GetAppropriateSerializer();

                    value = serializer == null
                        ? BsonSerializer.Deserialize(context.Reader, valueType)
                        : serializer.Deserialize(context, args);
                }

                context.Reader.ReadEndDocument();

                result = new UiObject(value, uiObjectType, assemblyQualifiedName);
            }

            return result;
        }
    }
}