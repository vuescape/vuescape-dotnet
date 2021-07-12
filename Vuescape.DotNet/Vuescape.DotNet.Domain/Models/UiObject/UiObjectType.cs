// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UiObjectType.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    /// <summary>
    /// The Type of the <see cref="UiObject"/>.
    /// </summary>
    public enum UiObjectType
    {
        /// <summary>
        /// None.
        /// </summary>
        None = 0,

        /// <summary>
        /// Boolean Type.
        /// </summary>
        Bool,

        /// <summary>
        /// String Type.
        /// </summary>
        String,

        /// <summary>
        /// Integer Type.
        /// </summary>
        Int,

        /// <summary>
        /// Short Type.
        /// </summary>
        Short,

        /// <summary>
        /// Long Type.
        /// </summary>
        Long,

        /// <summary>
        /// Decimal Type.
        /// </summary>
        Decimal,

        /// <summary>
        /// DateTime Type.
        /// </summary>
        DateTime,

        /// <summary>
        /// Guid.
        /// </summary>
        Guid,

        /// <summary>
        /// Enumeration.
        /// </summary>
        Enum,

        /// <summary>
        /// Any type that is explicitly specified (and not an arbitrary enum) and the type is not defined in this enum.
        /// </summary>
        SpecifiedType,
    }
}
