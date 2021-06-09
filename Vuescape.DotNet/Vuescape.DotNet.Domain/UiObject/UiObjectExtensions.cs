﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UiObjectExtensions.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace

namespace Vuescape.DotNet.Domain
{
    using System;
    using System.Collections.Generic;

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
    }
}
