// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TreeTableHeaderCell.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    using OBeautifulCode.Type;

    /// <summary>
    /// Represents a Tree Table Header Item.
    /// </summary>
    public partial class TreeTableHeaderCell : IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TreeTableHeaderCell"/> class.
        /// </summary>
        /// <param name="id">The unique identifier.</param>
        /// <param name="displayValue">The display representation of the value.</param>
        /// <param name="hover">The hover over behavior.</param>
        /// <param name="renderer">The name of the renderer.</param>
        /// <param name="cssClasses">The CSS classes.</param>
        /// <param name="cssStyles">The CSS style.</param>
        /// <param name="colspan">The column span (colspan attribute in HTML).</param>
        /// <param name="isVisible">Whether this item is visible.</param>
        /// <param name="columnSorter">The column sorter.</param>
        /// <param name="cellFormat">The cell formatting details.</param>
        /// <param name="links">The Links for this item.</param>
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "colspan", Justification = "This aligns with the HTML spelling.")]
        public TreeTableHeaderCell(
            string id,
            string displayValue,
            Hover hover,
            string renderer,
            string cssClasses,
            IReadOnlyDictionary<string, string> cssStyles,
            int? colspan,
            bool isVisible,
            ColumnSorter columnSorter,
            CellFormat cellFormat = null,
            IReadOnlyDictionary<string, Link> links = null)
        {
            this.Id = id;
            this.DisplayValue = displayValue;
            this.Hover = hover;
            this.Renderer = renderer;
            this.CssClasses = cssClasses;
            this.CssStyles = cssStyles;
            this.Colspan = colspan;
            this.IsVisible = isVisible;
            this.ColumnSorter = columnSorter;
            this.CellFormat = cellFormat;
            this.Links = links;
        }

        /// <summary>
        /// Gets the Id.
        /// </summary>
        public string Id { get; private set; }

        /// <summary>
        /// Gets the display representation of the value.
        /// </summary>
        public string DisplayValue { get; private set; }

        /// <summary>
        /// Gets the Hover behavior.
        /// </summary>
        public Hover Hover { get; private set; }

        /// <summary>
        /// Gets the Renderer.
        /// </summary>
        public string Renderer { get; private set; }

        /// <summary>
        /// Gets the CssClasses.
        /// </summary>
        public string CssClasses { get; private set; }

        // TODO: Change CssStyle to dictionary to aid in parsing on the client side

        /// <summary>
        /// Gets the CssStyles.
        /// </summary>
        public IReadOnlyDictionary<string, string> CssStyles { get; private set; }

        /// <summary>
        /// Gets the column span (colspan attribute in HTML).
        /// </summary>
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Colspan", Justification = "Aligns with client side HTML naming")]
        public int? Colspan { get; private set; }

        /// <summary>
        /// Gets a value indicating whether the cell is visible.</summary>
        public bool IsVisible { get; private set; }

        /// <summary>
        /// Gets the column sorter.
        /// </summary>
        public ColumnSorter ColumnSorter { get; private set; }

        /// <summary>
        /// Gets the cell format.</summary>
        public CellFormat CellFormat { get; private set; }

        /// <summary>
        /// Gets the Links.
        /// </summary>
        public IReadOnlyDictionary<string, Link> Links { get; private set; }

        /// <summary>
        /// Creates a visible header cell (i.e. will appear in the DOM) but is hidden via CSS.
        /// </summary>
        /// <returns>A hidden cell.</returns>
        public static TreeTableHeaderCell CreateHiddenCell()
        {
            var result = new TreeTableHeaderCell(
                null,
                null,
                null,
                null,
                "tree-table__display--none",
                null,
                null,
                true,
                null);

            return result;
        }
    }
}
