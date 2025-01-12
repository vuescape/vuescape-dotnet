// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TableComponentPayload.cs" company="Vuescape">
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
    /// Represents the payload for a table component, including headers and rows of data.
    /// </summary>
    public partial class TableComponentPayload : IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TableComponentPayload"/> class.
        /// </summary>
        /// <param name="id">The identifier of the table.</param>
        /// <param name="columns">The headers of the table.</param>
        /// <param name="rows">The rows of the table, where each row is a collection of cell values.</param>
        public TableComponentPayload(
            string id,
            IReadOnlyList<TableColumn> columns,
            IReadOnlyList<TableRow> rows)
        {
            new { id }.AsArg().Must().NotBeNullNorWhiteSpace();
            new { columns }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls();
            new { rows }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls();

            this.Id = id;
            this.Columns = columns;
            this.Rows = rows;
        }

        /// <summary>
        /// Gets the identifier of the table.
        /// </summary>
        public string Id { get; private set; }

        /// <summary>
        /// Gets the columns of the table.
        /// </summary>
        public IReadOnlyList<TableColumn> Columns { get; private set; }

        /// <summary>
        /// Gets the rows of the table.
        /// </summary>
        public IReadOnlyList<TableRow> Rows { get; private set; }
    }
}
