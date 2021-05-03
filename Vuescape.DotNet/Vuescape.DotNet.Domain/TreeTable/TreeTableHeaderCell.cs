// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TreeTableHeaderCell.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Vuescape.DotNet.Domain
{
    using OBeautifulCode.Assertion.Recipes;
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
        /// <param name="cssClasses">The CSS classes.</param>
        /// <param name="colspan">The column span (colspan attribute in HTML).</param>
        /// <param name="columnSorter">The column sorter.</param>
        /// <param name="renderer">The name of the renderer.</param>
        /// <param name="displayValue">The display value.</param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "colspan", Justification = "This aligns with the HTML spelling.")]
        public TreeTableHeaderCell(
            string id,
            string cssClasses,
            int? colspan,
            ColumnSorter columnSorter,
            string renderer,
            string displayValue)
        {
            new { id }.AsArg().Must().NotBeNullNorWhiteSpace();

            this.Id = id;
            this.CssClasses = cssClasses;
            this.Colspan = colspan;
            this.ColumnSorter = columnSorter;
            this.Renderer = renderer;
            this.DisplayValue = displayValue;
        }

        /// <summary>
        /// Gets the Id.
        /// </summary>
        public string Id { get; private set; }

        /// <summary>
        /// Gets the CssClasses. // TODO: Collection or string.
        /// </summary>
        public string CssClasses { get; private set; }

        /// <summary>
        /// Gets the Colspan.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Colspan", Justification = "Aligns with client side HTML naming")]
        public int? Colspan { get; private set; }

        /// <summary>
        /// Gets the column sorter.
        /// </summary>
        public ColumnSorter ColumnSorter { get; private set; }

        /// <summary>
        /// Gets the Renderer.
        /// </summary>
        public string Renderer { get; private set; }

        /// <summary>
        /// Gets the display value.
        /// </summary>
        public string DisplayValue { get; private set; }
    }
}
