// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TableRow.cs" company="Vuescape">
//   Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    using System.Collections.Generic;
    using OBeautifulCode.Type;

    /// <summary>
    /// Represents a row in a table.
    /// </summary>
    public partial class TableRow : IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TableRow"/> class.
        /// </summary>
        /// <param name="id">The identifier of the row.</param>
        /// <param name="cells">The cells in the row.</param>
        public TableRow(
            string id,
            IReadOnlyDictionary<string, TableCell> cells)
        {
            this.Id = id;
            this.Cells = cells;
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
    }
}
