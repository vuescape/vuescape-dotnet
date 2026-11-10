// <copyright file="ObcTableFormatExtensions.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using OBeautifulCode.DataStructure;

    /// <summary>
    /// Extension methods on <see cref="OBeautifulCode.DataStructure.TableFormat"/>.
    /// </summary>
    public static class ObcTableFormatExtensions
    {
        /// <summary>
        /// The original tree table's CSS class for its tables, which draws a line around every cell and aligns the cells' text.
        /// </summary>
        public const string CellBorderCssClass = "cell-border";

        /// <summary>
        /// The CSS class, beside <see cref="CellBorderCssClass"/>, for lines between the rows only.
        /// </summary>
        public const string RowBordersCssClass = "row-border";

        /// <summary>
        /// The CSS class, beside <see cref="CellBorderCssClass"/>, for no lines.
        /// </summary>
        public const string NoBordersCssClass = "no-border";

        /// <summary>
        /// Gets the lines that separate a table's cells from the table's inner borders.  A web table draws its lines in
        /// one weight, style and color, so only the edges the borders apply to count, and there are no lines between
        /// columns only: a vertical edge means a line around every cell.
        /// A table without inner borders gets the web table's usual lines, though a spreadsheet would draw none, so
        /// that the many tables that never gave borders keep theirs.  So OBC can't ask for
        /// <see cref="TableBorderKind.None"/>: it allows neither empty inner borders nor a border on no edges.
        /// </summary>
        /// <param name="obcTableFormat">The table format.</param>
        /// <returns>
        /// The lines, or null when the table doesn't give its inner borders, for the web table's usual lines.
        /// </returns>
        [SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters", Justification = "Only a table's inner borders describe the whole table's lines; a row's or column's inner borders cover part of it.")]
        public static TableBorderKind? ToVuescapeTableBorderKind(
            this TableFormat obcTableFormat)
        {
            var edges = (obcTableFormat?.InnerBorders ?? Array.Empty<InnerBorder>())
                .Where(_ => _ != null)
                .Select(_ => _.Edges)
                .ToList();
            if (edges.Any(_ => _ == InnerBorderEdges.All || _ == InnerBorderEdges.Vertical))
            {
                return TableBorderKind.Grid;
            }

            if (edges.Any(_ => _ == InnerBorderEdges.Horizontal))
            {
                return TableBorderKind.Rows;
            }

            return null;
        }

        /// <summary>
        /// Gets the original tree table's CSS classes for the lines that separate a table's cells.  They always include
        /// <see cref="CellBorderCssClass"/>, which also aligns the cells' text, with a class beside it for other lines.
        /// The original tree table doesn't style that class, so it still draws a line around every cell.
        /// </summary>
        /// <param name="borders">The lines, or null for the usual lines (around every cell).</param>
        /// <returns>The CSS classes, separated by spaces.</returns>
        public static string ToVuescapeTreeTableCssClass(
            this TableBorderKind? borders)
        {
            switch (borders)
            {
                case TableBorderKind.Rows:
                    return CellBorderCssClass + " " + RowBordersCssClass;
                case TableBorderKind.None:
                    return CellBorderCssClass + " " + NoBordersCssClass;
                default:
                    return CellBorderCssClass;
            }
        }
    }
}
