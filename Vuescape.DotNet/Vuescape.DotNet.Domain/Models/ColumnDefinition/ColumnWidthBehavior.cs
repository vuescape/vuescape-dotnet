// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ColumnWidthBehavior.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    using System;

    /// <summary>
    /// The width behavior of a column.
    /// </summary>
    [Flags]
    public enum ColumnWidthBehavior
    {
        /// <summary>
        /// None.
        /// </summary>
        None = 0,

        /// <summary>
        /// Fit the cell width to the content.
        /// </summary>
        DynamicallySizeToContent,

        /// <summary>
        /// Fit the cell width to the content up to the supplied width.
        /// </summary>
        UseSpecifiedWidth,
    }
}
