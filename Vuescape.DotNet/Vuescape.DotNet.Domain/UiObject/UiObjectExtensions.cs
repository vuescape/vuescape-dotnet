// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UiObjectExtensions.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace

namespace Vuescape.DotNet.Domain
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using OBeautifulCode.Representation.System;

    /// <summary>
    /// Extension methods related to <see cref="UiObject"/>.
    /// </summary>
    public static class UiObjectExtensions
    {
        private static readonly IReadOnlyDictionary<Type, UiObjectType> TypeToUiObjectTypeMap = new Dictionary<Type, UiObjectType>
        {
            { typeof(bool), UiObjectType.Bool },
            { typeof(string), UiObjectType.String },
            { typeof(short), UiObjectType.Short },
            { typeof(int), UiObjectType.Int },
            { typeof(long), UiObjectType.Long },
            { typeof(decimal), UiObjectType.Decimal },
            { typeof(DateTime), UiObjectType.DateTime },
            { typeof(Guid), UiObjectType.Guid },
        };

        /// <summary>
        /// Gets the <see cref="UiObjectType"/> for a specified object.
        /// </summary>
        /// <param name="value">The object.</param>
        /// <returns>
        /// The specified object's <see cref="UiObjectType"/>.
        /// </returns>
        public static UiObjectType GetUiObjectType(
            this object value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            var valueType = value.GetType();

            if (!TypeToUiObjectTypeMap.TryGetValue(valueType, out var result))
            {
                result = valueType.IsEnum ? Domain.UiObjectType.Enum : Domain.UiObjectType.SpecifiedType;
            }

            return result;
        }

        /// <summary>
        /// Gets the <see cref="Type"/> for a specified <see cref="UiObjectType"/>.
        /// </summary>
        /// <param name="value">The UI object type.</param>
        /// <param name="assemblyQualifiedName">The assembly qualified name; required if <paramref name="value"/> is <see cref="UiObjectType.SpecifiedType"/>.</param>
        /// <returns>
        /// The <see cref="Type"/> corresponding to the specified <see cref="UiObjectType"/>.
        /// </returns>
        public static Type GetObjectType(
            this UiObjectType value,
            string assemblyQualifiedName)
        {
            // TODO: Verify this.
#pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
            if (value == null)
#pragma warning restore CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
            {
                throw new ArgumentNullException(nameof(value));
            }

            var result = (value == UiObjectType.SpecifiedType) || (value == UiObjectType.Enum)
                ? assemblyQualifiedName.ToTypeRepresentationFromAssemblyQualifiedName().ResolveFromLoadedTypes()
                : TypeToUiObjectTypeMap.Single(_ => _.Value == value).Key;

            return result;
        }

        /// <summary>
        /// Gets the assembly qualified name for a specified object in a <see cref="UiObject"/> context.
        /// </summary>
        /// <param name="value">The object.</param>
        /// <returns>
        /// The assembly qualified name for an object in a <see cref="UiObject"/> context.
        /// </returns>
        public static string GetUiObjectAssemblyQualifiedName(
            this object value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            var valueType = value.GetType();

            string result = null;

            if (!TypeToUiObjectTypeMap.ContainsKey(valueType))
            {
                result = valueType.ToRepresentation().RemoveAssemblyVersions().BuildAssemblyQualifiedName();
            }

            return result;
        }

        /// <summary>
        /// Determines whether an assembly qualified name is needed for a specified <see cref="UiObjectType"/>.
        /// </summary>
        /// <param name="uiObjectType">The UI object type.</param>
        /// <returns>
        /// true if the assembly qualified name is needed for the specified <see cref="UiObjectType"/>, otherwise false.
        /// </returns>
        public static bool RequiresAssemblyQualifiedName(
            this UiObjectType? uiObjectType)
        {
            bool result;

            if (uiObjectType == null)
            {
                result = false;
            }
            else if ((uiObjectType == UiObjectType.Enum) || (uiObjectType == UiObjectType.SpecifiedType))
            {
                result = true;
            }
            else
            {
                result = false;
            }

            return result;
        }
    }
}
