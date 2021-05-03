// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ColumnSorter.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Vuescape.DotNet.Domain
{
    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Type;

    /// <summary>
    /// Sorts a column.
    /// </summary>
    public partial class ColumnSorter : IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ColumnSorter"/> class.
        /// </summary>
        /// <param name="sortByCellId">The cell ID to sort by.</param>
        /// <param name="sortDirection">The sort direction.</param>
        public ColumnSorter(
            string sortByCellId,
            SortDirection sortDirection)
        {
            new { sortByCellId }.AsArg().Must().NotBeNullNorWhiteSpace();

            this.SortByCellId = sortByCellId;
            this.SortDirection = sortDirection;
        }

        /// <summary>
        /// Gets the cell ID to use for sorting.
        /// </summary>
        public string SortByCellId { get; private set; }

        /// <summary>
        /// Gets the sort direction.
        /// </summary>
        public SortDirection SortDirection { get; private set; }
    }
}
