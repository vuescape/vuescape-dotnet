// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CellRenderer.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    /// <summary>
    /// Contains static list of cell renderer names.
    /// </summary>
    public static class CellRenderer
    {
        /// <summary>
        /// Empty cell renderer. Will render an empty cell. Useful for providing data but not rendering.
        /// </summary>
        public static readonly string EmptyCellRenderer = "EmptyCellRenderer";

        /// <summary>
        /// Fixed cell renderer.
        /// </summary>
        public static readonly string FixedCellRenderer = "FixedCellRenderer";

        /// <summary>
        /// Html cell renderer. Render value as HTML.
        /// </summary>
        public static readonly string HtmlCellRenderer = "HtmlCellRenderer";

        /// <summary>
        /// Default cell renderer. Render value as text.
        /// </summary>
        public static readonly string DefaultCellRenderer = "TextCellRenderer";
    }
}
