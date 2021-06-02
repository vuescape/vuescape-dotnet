// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UiObject.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    using System;
    using System.Collections.Generic;

    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Representation.System;
    using OBeautifulCode.Type;

    /// <summary>
    /// This class wraps an <see cref="object"/> and stores a <see cref="UiObjectType"/> describing the type of the object.
    /// </summary>
    public partial class UiObject : IModelViaCodeGen
    {
        private static readonly IReadOnlyDictionary<Type, UiObjectType> TypeToUiObjectTypeMap = new Dictionary<Type, UiObjectType>()
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
        /// Initializes a new instance of the <see cref="UiObject"/> class.
        /// </summary>
        /// <remarks>
        /// This class wraps an object and assigns a <see cref="UiObjectType"/> so that an object can be serialized to and from the UI.
        /// </remarks>
        /// <param name="value">The object value.</param>
        /// <param name="uiObjectType">The UiObjectType of the value. Only required when object value is null.</param>
        /// <param name="assemblyQualifiedName">The assembly qualified name of the value. Only required when object value is null.</param>
#pragma warning disable SA1305 // Field names should not use Hungarian notation
        public UiObject(object value, UiObjectType? uiObjectType = null, string assemblyQualifiedName = null)
#pragma warning restore SA1305 // Field names should not use Hungarian notation
        {
            if (uiObjectType != null)
            {
                new { uiObjectType.Value }.AsArg(nameof(uiObjectType)).Must().NotBeEqualTo(UiObjectType.None);
            }

            if (assemblyQualifiedName != null)
            {
                new { uiObjectType }.AsArg().Must().NotBeNull();
            }

            if (value == null)
            {
                new { uiObjectType }.AsArg().Must().NotBeNull();

                // ReSharper disable once PossibleInvalidOperationException
                this.UiObjectType = (UiObjectType)uiObjectType;

                if (uiObjectType == UiObjectType.Enum || uiObjectType == UiObjectType.SpecifiedType)
                {
                    new { assemblyQualifiedName }.AsArg().Must().NotBeNullNorWhiteSpace();
                    this.AssemblyQualifiedName = assemblyQualifiedName;
                }

                return;
            }

            var valueType = value.GetType();
            if (!TypeToUiObjectTypeMap.TryGetValue(valueType, out var mappedUiObjectType))
            {
                mappedUiObjectType = valueType.IsEnum ? UiObjectType.Enum : UiObjectType.SpecifiedType;
                this.AssemblyQualifiedName = valueType.ToRepresentation().RemoveAssemblyVersions().BuildAssemblyQualifiedName();
            }

            // throw new NotSupportedException(Invariant($@"Object of type {value.GetType()} is not supported.  Supported types are defined in {nameof(Domain.UiObjectType)} and consist of the following {string.Join(",", typeof(UiObjectType).GetEnumNames())}."));
            if (uiObjectType != null)
            {
                new { uiObjectType.Value }.AsArg(nameof(uiObjectType)).Must().BeEqualTo(mappedUiObjectType);
            }

            if (assemblyQualifiedName != null)
            {
                new { assemblyQualifiedName }.AsArg().Must().BeEqualTo(this.AssemblyQualifiedName);
            }

            this.Value = value;
            this.UiObjectType = mappedUiObjectType;
        }

        /// <summary>
        /// Gets the value.
        /// </summary>
        public object Value { get; private set; }

        /// <summary>
        /// Gets the <see cref="UiObjectType"/>.
        /// </summary>
        public UiObjectType UiObjectType { get; private set; }

        /// <summary>
        /// Gets the assembly qualified name.
        /// </summary>
        public string AssemblyQualifiedName { get; private set; }
    }
}
