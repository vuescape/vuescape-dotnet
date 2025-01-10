// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FilterModeKind.cs" company="Vuescape">
//   Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    /// <summary>
    /// Represents the filter mode for a table column.
    /// </summary>
    public enum FilterModeKind
    {
        /// <summary>
        /// Filter mode is string.
        /// </summary>
        String,

        /// <summary>
        /// Filter mode is category.
        /// </summary>
        Category,

        /// <summary>
        /// Filter mode is date.
        /// </summary>
        Date,

        /// <summary>
        /// Filter mode is boolean.
        /// </summary>
        Boolean,
    }
}
