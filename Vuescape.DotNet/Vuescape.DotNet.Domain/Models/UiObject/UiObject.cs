// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UiObject.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    using System;

    using OBeautifulCode.Type;

    using static System.FormattableString;

    /// <summary>
    /// This class wraps an <see cref="object"/> and stores a <see cref="UiObjectType"/> describing the type of the object.
    /// </summary>
    public partial class UiObject : IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UiObject"/> class.
        /// </summary>
        /// <remarks>
        /// This class wraps an object and assigns a <see cref="UiObjectType"/> so that an object can be serialized to and from the UI.
        /// </remarks>
        /// <param name="value">The object value.</param>
        public UiObject(object value)
        : this(value, value?.GetUiObjectType(), value?.GetUiObjectAssemblyQualifiedName())
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UiObject"/> class.
        /// </summary>
        /// <remarks>
        /// This class wraps an object and assigns a <see cref="UiObjectType"/> so that an object can be serialized to and from the UI.
        /// </remarks>
        /// <param name="value">The object value.</param>
        /// <param name="uiObjectType">The <see cref="UiObjectType"/>.</param>
        /// <param name="assemblyQualifiedName">The assembly qualified name.</param>
#pragma warning disable SA1305 // Field names should not use Hungarian notation
        public UiObject(
            object value,
            UiObjectType? uiObjectType,
            string assemblyQualifiedName)
#pragma warning restore SA1305 // Field names should not use Hungarian notation
        {
            if (value == null)
            {
                if (uiObjectType != null)
                {
                    throw new ArgumentException(Invariant($"{nameof(value)} is null but {nameof(uiObjectType)} is not null."));
                }
            }
            else
            {
                if (uiObjectType == null)
                {
                    throw new ArgumentException(Invariant($"{nameof(value)} is not null but {nameof(uiObjectType)} is null."));
                }

                if (((uiObjectType == Domain.UiObjectType.Enum) || (uiObjectType == Domain.UiObjectType.SpecifiedType)) && string.IsNullOrWhiteSpace(assemblyQualifiedName))
                {
                    throw new ArgumentException(Invariant($"{nameof(assemblyQualifiedName)} is expected when {nameof(uiObjectType)} is in this set: [{Domain.UiObjectType.Enum}, {Domain.UiObjectType.SpecifiedType}]."));
                }
            }

            this.Value = value;
            this.UiObjectType = uiObjectType;
            this.AssemblyQualifiedName = assemblyQualifiedName;
        }

        /// <summary>
        /// Gets the value.
        /// </summary>
        public object Value { get; private set; }

        /// <summary>
        /// Gets the <see cref="UiObjectType"/>.
        /// </summary>
        public UiObjectType? UiObjectType { get; private set; }

        /// <summary>
        /// Gets the assembly qualified name.
        /// </summary>
        public string AssemblyQualifiedName { get; private set; }
    }
}
