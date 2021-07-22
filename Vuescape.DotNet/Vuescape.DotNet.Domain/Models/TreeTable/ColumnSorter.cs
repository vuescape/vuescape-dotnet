// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ColumnSorter.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
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
        /// <param name="sortDirection">The sort direction.</param>
        /// <param name="sortComparisonStrategy">The sort comparison strategy to use.</param>
        public ColumnSorter(
            SortDirection sortDirection,
            SortComparisonStrategy sortComparisonStrategy)
        {
            new { sortComparisonStrategy }.AsArg().Must().NotBeEqualTo(SortComparisonStrategy.None);

            this.SortDirection = sortDirection;
            this.SortComparisonStrategy = sortComparisonStrategy;
        }

        /// <summary>
        /// Gets the sort direction.
        /// </summary>
        public SortDirection SortDirection { get; private set; }

        /// <summary>
        /// Gets the sort comparison strategy.
        /// </summary>
        public SortComparisonStrategy SortComparisonStrategy { get; private set; }
    }
}
