// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TreeTableCell.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    using System.Collections.Generic;

    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Type;

    /// <summary>
    /// Represents a Tree Table Header Item.
    /// </summary>
    public partial class TreeTableCell : IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TreeTableCell"/> class.
        /// </summary>
        /// <param name="id">The unique identifier.</param>
        /// <param name="displayValue">The display representation of the value.</param>
        /// <param name="hover">The hover over behavior.</param>
        /// <param name="renderer">The name of the renderer.</param>
        /// <param name="cssClasses">The CSS classes.</param>
        /// <param name="cssStyles">The CSS styles.</param>
        /// <param name="colspan">The column span (colspan attribute in HTML).</param>
        /// <param name="isVisible">Whether this cell is visible.</param>
        /// <param name="cellFormat">The cell formatting details.</param>
        /// <param name="links">The Links for this cell.</param>
        /// <param name="slots">The slotted values for this cell.</param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "colspan", Justification = "This aligns with the HTML spelling.")]
        public TreeTableCell(
            string id,
            string displayValue,
            Hover hover,
            string renderer,
            string cssClasses,
            IReadOnlyDictionary<string, string> cssStyles,
            int? colspan,
            bool isVisible,
            CellFormat cellFormat,
            IReadOnlyDictionary<string, Link> links = null,
            SlottedUiObject slots = null)
        {
            this.Id = id;
            this.DisplayValue = displayValue;
            this.Hover = hover;
            this.Renderer = renderer;
            this.CssClasses = cssClasses;
            this.CssStyles = cssStyles;
            this.Colspan = colspan;
            this.IsVisible = isVisible;
            this.CellFormat = cellFormat;
            this.Links = links;
            this.Slots = slots;
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
        /// Gets the CssStyles.
        /// </summary>
        public IReadOnlyDictionary<string, string> CssStyles { get; private set; }

        /// <summary>
        /// Gets the column span (colspan attribute in HTML).
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Colspan", Justification = "Aligns with client side HTML naming")]
        public int? Colspan { get; private set; }

        /// <summary>
        /// Gets a value indicating whether the cell is visible.</summary>
        public bool IsVisible { get; private set; }

        /// <summary>
        /// Gets the cell format.</summary>
        public CellFormat CellFormat { get; private set; }

        /// <summary>
        /// Gets the Links.
        /// </summary>
        public IReadOnlyDictionary<string, Link> Links { get; private set; }

        /// <summary>
        /// Gets the Slots.
        /// </summary>
        public SlottedUiObject Slots { get; private set; }

        /// <summary>
        /// Creates a visible cell (i.e. will appear in the DOM) but is hidden via CSS.
        /// </summary>
        /// <returns>A hidden cell.</returns>
        public static TreeTableCell CreateHiddenCell()
        {
            var result = new TreeTableCell(
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
