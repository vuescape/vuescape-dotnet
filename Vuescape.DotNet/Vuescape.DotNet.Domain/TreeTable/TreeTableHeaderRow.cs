// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TreeTableHeaderRow.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Vuescape.DotNet.Domain
{
    using System.Collections.Generic;

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
        /// <param name="cssClasses">The CSS classes.</param>
        /// <param name="cells">The items. This is typically the column values.</param>
        public TreeTableHeaderRow(
            string id,
            string cssClasses,
            IReadOnlyList<TreeTableHeaderCell> cells)
        {
            new { id }.AsArg().Must().NotBeNullNorWhiteSpace();
            new { cells }.AsArg().Must().NotBeNullNorEmptyEnumerable();

            this.Id = id;
            this.CssClasses = cssClasses;
            this.Cells = cells;
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
        /// Gets the header items.
        /// </summary>
        public IReadOnlyList<TreeTableHeaderCell> Cells { get; private set; }
    }
}
