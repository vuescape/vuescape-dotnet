// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TableRow.cs" company="Vuescape">
//   Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    using System.Collections.Generic;
    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Type;

    /// <summary>
    /// Represents a row in a table.
    /// </summary>
    public partial class TableRow : IHaveId<string>, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TableRow"/> class.
        /// </summary>
        /// <param name="id">The identifier of the row.</param>
        /// <param name="cells">The cells in the row.</param>
        /// <param name="childRows">OPTIONAL rows nested under this row, keyed by the same column ids, shown while this row is expanded.  A table with any child rows is shown as a tree.  DEFAULT is no child rows.</param>
        /// <param name="isExpanded">OPTIONAL value indicating whether the row starts expanded.  The user can still collapse it.  DEFAULT is collapsed.</param>
        public TableRow(
            string id,
            IReadOnlyDictionary<string, TableCell> cells,
            IReadOnlyList<TableRow> childRows = null,
            bool? isExpanded = null)
        {
            new { id }.AsArg().Must().NotBeNullNorWhiteSpace();
            new { cells }.AsArg().Must().NotBeNullNorEmptyDictionaryNorContainAnyNullValues();
            new { childRows }.AsArg().Must().NotContainAnyNullElementsWhenNotNull();

            this.Id = id;
            this.Cells = cells;
            this.ChildRows = childRows;
            this.IsExpanded = isExpanded;
        }

        /// <summary>
        /// Gets the identifier of the row.
        /// </summary>
        public string Id { get; private set; }

        /// <summary>
        /// Gets the cells of the row.
        /// Optional.
        /// </summary>
        public IReadOnlyDictionary<string, TableCell> Cells { get; private set; }

        /// <summary>
        /// Gets the rows nested under this row, shown while this row is expanded.
        /// Optional.
        /// </summary>
        public IReadOnlyList<TableRow> ChildRows { get; private set; }

        /// <summary>
        /// Gets a value indicating whether the row starts expanded.
        /// Optional.  Null means collapsed.
        /// </summary>
        public bool? IsExpanded { get; private set; }
    }
}
