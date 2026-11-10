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
    public partial class TableComponentPayload : IHaveId<string>, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TableComponentPayload"/> class.
        /// </summary>
        /// <param name="id">The identifier of the table.</param>
        /// <param name="columns">The headers of the table.</param>
        /// <param name="rows">The rows of the table, where each row is a collection of cell values.</param>
        /// <param name="headerRows">OPTIONAL rows of the table's header, top to bottom, e.g. a row of group headings above the columns' headings.  Their cells are keyed by column identifier, like a row's, and can span columns (<see cref="TableCell.Colspan"/>).  The bottom row's cells hold the columns' sort controls.  Child rows are not shown.  An empty list means no header.  DEFAULT is one row of the columns' (deprecated) <see cref="TableColumn.HeaderText"/>, or no header when no column has any.</param>
        /// <param name="footerRows">OPTIONAL rows shown below the rows, e.g. totals, which stay in place when the rows scroll or are sorted.  Their cells are keyed by column identifier, like a row's, and can span columns (<see cref="TableCell.Colspan"/>).  Child rows are not shown.  DEFAULT is no footer rows.</param>
        /// <param name="footnotes">OPTIONAL notes shown as text below the table, top to bottom, e.g. how to read its numbers.  They are not part of the table: they don't stay in place when the rows scroll.  DEFAULT is no footnotes.</param>
        /// <param name="appearance">OPTIONAL how the table looks as a whole, e.g. its borders.  DEFAULT is striped rows with a line around every cell.</param>
        public TableComponentPayload(
            string id,
            IReadOnlyList<TableColumn> columns,
            IReadOnlyList<TableRow> rows,
            IReadOnlyList<TableRow> headerRows = null,
            IReadOnlyList<TableRow> footerRows = null,
            IReadOnlyList<string> footnotes = null,
            TableAppearance appearance = null)
        {
            new { id }.AsArg().Must().NotBeNullNorWhiteSpace();
            new { columns }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls();
            new { rows }.AsArg().Must().NotBeNull();
            new { rows }.AsArg().Must().NotContainAnyNullElementsWhenNotNull();
            new { headerRows }.AsArg().Must().NotContainAnyNullElementsWhenNotNull();
            new { footerRows }.AsArg().Must().NotContainAnyNullElementsWhenNotNull();
            new { footnotes }.AsArg().Must().NotContainAnyNullElementsWhenNotNull();

            this.Id = id;
            this.Columns = columns;
            this.Rows = rows;
            this.HeaderRows = headerRows;
            this.FooterRows = footerRows;
            this.Footnotes = footnotes;
            this.Appearance = appearance;
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

        /// <summary>
        /// Gets the rows of the table's header, top to bottom.
        /// Optional.  Null means one row of the columns' (deprecated) <see cref="TableColumn.HeaderText"/>; empty means no header.
        /// </summary>
        public IReadOnlyList<TableRow> HeaderRows { get; private set; }

        /// <summary>
        /// Gets the rows shown below the rows, e.g. totals.
        /// Optional.  Null means no footer rows.
        /// </summary>
        public IReadOnlyList<TableRow> FooterRows { get; private set; }

        /// <summary>
        /// Gets the notes shown as text below the table, top to bottom.
        /// Optional.  Null means no footnotes.
        /// </summary>
        public IReadOnlyList<string> Footnotes { get; private set; }

        /// <summary>
        /// Gets how the table looks as a whole.
        /// Optional.  Null means striped rows with a line around every cell.
        /// </summary>
        public TableAppearance Appearance { get; private set; }
    }
}
