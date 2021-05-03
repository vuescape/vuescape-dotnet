// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TreeTableCell.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

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
        /// <param name="cssClasses">The CSS classes.</param>
        /// <param name="colspan">The column span (colspan attribute in HTML).</param>
        /// <param name="hover">The hover over behavior.</param>
        /// <param name="isVisible">Whether this item is visible.</param>
        /// <param name="renderer">The name of the renderer.</param>
        /// <param name="displayValue">The display representation of the value.</param>
        /// <param name="value">The value.</param>
        /// <param name="links">The Links for this item.</param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "colspan", Justification = "This aligns with the HTML spelling.")]
        public TreeTableCell(
            string id,
            string cssClasses,
            int? colspan,
            Hover hover,
            bool isVisible,
            string renderer,
            string displayValue,
            IObject value,
            IReadOnlyDictionary<string, IReadOnlyCollection<Link>> links = null)
        {
            new { id }.AsArg().Must().NotBeNullNorWhiteSpace();

            this.Id = id;
            this.CssClasses = cssClasses;
            this.Colspan = colspan;
            this.Hover = hover;
            this.IsVisible = isVisible;
            this.Renderer = renderer;
            this.DisplayValue = displayValue;
            this.Value = value;
            this.Links = links;
        }

        /// <summary>
        /// Gets the Id.
        /// </summary>
        public string Id { get; private set; }

        /// <summary>
        /// Gets the CssClasses.
        /// </summary>
        public string CssClasses { get; private set; }

        /// <summary>
        /// Gets the column span (colspan attribute in HTML).
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Colspan", Justification = "Aligns with client side HTML naming")]
        public int? Colspan { get; private set; }

        /// <summary>
        /// Gets the Hover behavior.
        /// </summary>
        public Hover Hover { get; private set; }

        /// <summary>
        /// Gets a value indicating whether the item is visible.</summary>
        public bool IsVisible { get; private set; }

        /// <summary>
        /// Gets the Renderer.
        /// </summary>
        public string Renderer { get; private set; }

        /// <summary>
        /// Gets the display representation of the value.
        /// </summary>
        public string DisplayValue { get; private set; }

        /// <summary>
        /// Gets the value.
        /// </summary>
        public IObject Value { get; private set; }

        /// <summary>
        /// Gets the Links.
        /// </summary>
        public IReadOnlyDictionary<string, IReadOnlyCollection<Link>> Links { get; private set; }
    }
}
