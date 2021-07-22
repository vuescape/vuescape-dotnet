// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TreeTableHeaderRow.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    using System.Collections.Generic;
    using System.Linq;

    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Type;

    /// <summary>
    /// Represents a Tree Table Header Row.
    /// </summary>
    public partial class TreeTableHeaderRow : IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TreeTableHeaderRow"/> class.
        /// </summary>
        /// <param name="id">The unique identifier.</param>
        /// <param name="cells">The items. This is typically the column values.</param>
        /// <param name="cssClasses">The CSS classes.</param>
        /// <param name="cssStyle">The CSS style.</param>
        /// <param name="renderer">The renderer for the row.</param>
        public TreeTableHeaderRow(
            string id,
            IReadOnlyList<TreeTableHeaderCell> cells,
            string cssClasses = null,
            string cssStyle = null,
            string renderer = null)
        {
            new { cells }.AsArg().Must().NotBeNullNorEmptyEnumerable();

            var numberOfCellsWithInitialSortDirection = cells.Count(_ =>
                _.ColumnSorter != null &&
                (_.ColumnSorter.SortDirection == SortDirection.Ascending ||
                 _.ColumnSorter.SortDirection == SortDirection.Descending));
            new { numberOfCellsWithInitialSortDirection }.AsOp().Must().NotBeGreaterThan(1);

            this.Id = id;
            this.Cells = cells;
            this.CssClasses = cssClasses;
            this.CssStyle = cssStyle;
            this.Renderer = renderer;
        }

        /// <summary>
        /// Gets the Id.
        /// </summary>
        public string Id { get; private set; }

        /// <summary>
        /// Gets the header items.
        /// </summary>
        public IReadOnlyList<TreeTableHeaderCell> Cells { get; private set; }

        /// <summary>
        /// Gets the CssClasses.
        /// </summary>
        public string CssClasses { get; private set; }

        /// <summary>
        /// Gets the CssStyle.
        /// </summary>
        public string CssStyle { get; private set; }

        /// <summary>
        /// Gets the cell renderer.
        /// </summary>
        public string Renderer { get; private set; }
    }
}
