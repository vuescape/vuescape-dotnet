// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ColumnWrapBehavior.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    using System;

    /// <summary>
    /// The wrapping behavior of a cell.
    /// </summary>
    public enum ColumnWrapBehavior
    {
        /// <summary>
        /// None.
        /// </summary>
        None = 0,

        /// <summary>
        /// Wrap the contents of the cell.
        /// </summary>
        Wrap,

        /// <summary>
        /// Don't wrap the contents of the cell and truncate if it doesn't fit.
        /// </summary>
        NoWrapAndTruncate,

        /// <summary>
        /// Don't wrap the contents of the cell and display an ellipsis if it doesn't fit.
        /// </summary>
        NoWrapAndDisplayEllipsis,
    }
}
