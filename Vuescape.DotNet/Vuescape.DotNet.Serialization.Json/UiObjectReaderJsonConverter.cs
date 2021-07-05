// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UiObjectReaderJsonConverter.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Vuescape.DotNet.Serialization.Json
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    using NewtonsoftFork.Json;
    using NewtonsoftFork.Json.Linq;

    using OBeautifulCode.Enum.Recipes;
    using OBeautifulCode.Serialization;
    using OBeautifulCode.Serialization.Json;
    using OBeautifulCode.String.Recipes;

    using Vuescape.DotNet.Domain;

    using static System.FormattableString;

    /// <summary>
    /// Handles serialization of <see cref="UiObject"/>.
    /// </summary>
    public class UiObjectReaderJsonConverter : JsonConverter
    {
        private readonly JsonSerializationConfigurationBase jsonSerializationConfiguration;

        /// <summary>
        /// Initializes a new instance of the <see cref="InheritedTypeReaderJsonConverter"/> class.
        /// </summary>
        /// <param name="jsonSerializationConfiguration">The serialization configuration in-use.</param>
        public UiObjectReaderJsonConverter(
            JsonSerializationConfigurationBase jsonSerializationConfiguration)
        {
            this.jsonSerializationConfiguration = jsonSerializationConfiguration;
        }

        /// <inheritdoc />
        public override bool CanRead => true;

        /// <inheritdoc />
        public override bool CanWrite => false;

        /// <inheritdoc />
        public override void WriteJson(
            JsonWriter writer,
            object value,
            JsonSerializer serializer)
        {
            throw new NotSupportedException("This is a read-only converter.");
        }

        /// <inheritdoc />
        public override object ReadJson(
            JsonReader reader,
            Type objectType,
            object existingValue,
            JsonSerializer serializer)
        {
            if (reader == null)
            {
                throw new ArgumentNullException(nameof(reader));
            }

            var jsonObject = JObject.Load(reader);

            var jsonProperties = GetProperties(jsonObject);

            var objectTypeTokenName = nameof(UiObject.UiObjectType).ToLowerFirstCharacter(CultureInfo.InvariantCulture);

            var assemblyQualifiedNameTokenName = nameof(UiObject.AssemblyQualifiedName).ToLowerFirstCharacter(CultureInfo.InvariantCulture);

            var valueTokenName = nameof(UiObject.Value).ToLowerFirstCharacter(CultureInfo.InvariantCulture);

            var uiObjectType = jsonProperties.Contains(objectTypeTokenName) && (jsonObject[objectTypeTokenName].Type != JTokenType.Null)
                ? jsonObject[objectTypeTokenName].ToString().ToEnum<UiObjectType>(ignoreCase: true)
                : (UiObjectType?)null;

            var assemblyQualifiedName = jsonProperties.Contains(assemblyQualifiedNameTokenName) && (jsonObject[assemblyQualifiedNameTokenName].Type != JTokenType.Null)
                ? jsonObject[assemblyQualifiedNameTokenName].ToString()
                : null;

            object value;

            if (jsonProperties.Contains(valueTokenName) && (jsonObject[valueTokenName].Type != JTokenType.Null))
            {
                if (uiObjectType == null)
                {
                    throw new InvalidOperationException(Invariant($"When {nameof(UiObject.Value)} is not null, {nameof(UiObject.UiObjectType)} must be not null."));
                }

                var valueType = ((UiObjectType)uiObjectType).GetObjectType(assemblyQualifiedName);

                value = this.Deserialize(jsonObject[valueTokenName], valueType, serializer);
            }
            else
            {
                value = null;
            }

            var result = new UiObject(value, uiObjectType, assemblyQualifiedName);

            return result;
        }

        /// <inheritdoc />
        public override bool CanConvert(
            Type objectType)
        {
            if (objectType == null)
            {
                throw new ArgumentNullException(nameof(objectType));
            }

            var result = objectType == typeof(UiObject);

            return result;
        }

        private static HashSet<string> GetProperties(
            JToken node)
        {
            var result = new HashSet<string>();

            if (node.Type == JTokenType.Object)
            {
                node.Children<JProperty>().Select(child => child.Name).ToList().ForEach(_ => result.Add(_));
            }

            return result;
        }

        private object Deserialize(
            JToken token,
            Type type,
            JsonSerializer serializer)
        {
            // If called from TryDeserializeCandidates() then there's a chance that a closed generic gets registered
            // for a candidate that isn't chosen and there's no way to de-register it.  Seems like a super edge case.
            this.jsonSerializationConfiguration.ThrowOnUnregisteredTypeIfAppropriate(type, SerializationDirection.Deserialize, null);

            var reader = token.CreateReader();

            var result = serializer.Deserialize(reader, type);

            return result;
        }
    }
}
