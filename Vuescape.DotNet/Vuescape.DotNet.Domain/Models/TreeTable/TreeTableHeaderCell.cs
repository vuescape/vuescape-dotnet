// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TreeTableHeaderCell.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    using System.Collections.Generic;

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
        /// <param name="cssStyle">The CSS style.</param>
        /// <param name="colspan">The column span (colspan attribute in HTML).</param>
        /// <param name="isVisible">Whether this item is visible.</param>
        /// <param name="columnSorter">The column sorter.</param>
        /// <param name="links">The Links for this item.</param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "colspan", Justification = "This aligns with the HTML spelling.")]
        public TreeTableHeaderCell(
            string id,
            string displayValue,
            Hover hover,
            string renderer,
            string cssClasses,
            string cssStyle,
            int? colspan,
            bool isVisible,
            ColumnSorter columnSorter,
            IReadOnlyDictionary<string, Link> links = null)
        {
            this.Id = id;
            this.DisplayValue = displayValue;
            this.Hover = hover;
            this.Renderer = renderer;
            this.CssClasses = cssClasses;
            this.CssStyle = cssStyle;
            this.Colspan = colspan;
            this.IsVisible = isVisible;
            this.ColumnSorter = columnSorter;
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

        /// <summary>
        /// Gets the CssStyle.
        /// </summary>
        public string CssStyle { get; private set; }

        /// <summary>
        /// Gets the column span (colspan attribute in HTML).
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Colspan", Justification = "Aligns with client side HTML naming")]
        public int? Colspan { get; private set; }

        /// <summary>
        /// Gets a value indicating whether the cell is visible.</summary>
        public bool IsVisible { get; private set; }

        /// <summary>
        /// Gets the column sorter.
        /// </summary>
        public ColumnSorter ColumnSorter { get; private set; }

        /// <summary>
        /// Gets the Links.
        /// </summary>
        public IReadOnlyDictionary<string, Link> Links { get; private set; }
    }
}
