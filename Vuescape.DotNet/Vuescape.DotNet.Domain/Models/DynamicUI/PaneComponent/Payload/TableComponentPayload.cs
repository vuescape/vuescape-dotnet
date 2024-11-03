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
        /// <param name="headers">The headers of the table.</param>
        /// <param name="rows">The rows of the table, where each row is a collection of cell values.</param>
        public TableComponentPayload(
            IReadOnlyList<string> headers,
            IReadOnlyList<IReadOnlyList<string>> rows)
        {
            new { headers }.AsArg().Must().NotBeNull();
            new { rows }.AsArg().Must().NotBeNull();

            this.Headers = headers;
            this.Rows = rows;
        }

        /// <summary>
        /// Gets the headers of the table.
        /// </summary>
        public IReadOnlyList<string> Headers { get; private set; }

        /// <summary>
        /// Gets the rows of the table, where each row is a collection of cell values.
        /// </summary>
        public IReadOnlyList<IReadOnlyList<string>> Rows { get; private set; }
    }
}
