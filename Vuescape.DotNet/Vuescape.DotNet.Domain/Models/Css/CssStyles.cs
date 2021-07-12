// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CssStyles.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    using System.Collections.Generic;

    using OBeautifulCode.Type;

    /// <summary>
    /// Wraps a Css Style.
    /// </summary>
    public partial class CssStyles : IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CssStyles"/> class.
        /// </summary>
        /// <param name="table">The table CSS Style.</param>
        /// <param name="allRows">CSS Style for all rows.</param>
        /// <param name="allCells">CSS Style for all cells of all rows.</param>
        /// <param name="currentRow">The current row's CSS Style.</param>
        /// <param name="currentRowCells">The CSS Style for all cells of the current row.</param>
        /// <param name="currentCell">The current cell's CSS Style.</param>
        public CssStyles(CssStyleWrapper table, IReadOnlyList<CssStyleWrapper> allRows, IReadOnlyList<IReadOnlyList<CssStyleWrapper>> allCells, CssStyleWrapper currentRow, IReadOnlyList<CssStyleWrapper> currentRowCells, CssStyleWrapper currentCell)
        {
            this.Table = table;
            this.AllRows = allRows;
            this.AllCells = allCells;
            this.CurrentRow = currentRow;
            this.CurrentRowCells = currentRowCells;
            this.CurrentCell = currentCell;
        }

        /// <summary>
        /// Gets the CSS Style.
        /// </summary>
        public CssStyleWrapper Table { get; private set; }

        /// <summary>
        /// Gets the CSS Style.
        /// </summary>
        public IReadOnlyList<CssStyleWrapper> AllRows { get; private set; }

        /// <summary>
        /// Gets the CSS Style.
        /// </summary>
        public IReadOnlyList<IReadOnlyList<CssStyleWrapper>> AllCells { get; private set; }

        /// <summary>
        /// Gets the CSS Style.
        /// </summary>
        public CssStyleWrapper CurrentRow { get; private set; }

        /// <summary>
        /// Gets the CSS Style.
        /// </summary>
        public IReadOnlyList<CssStyleWrapper> CurrentRowCells { get; private set; }

        /// <summary>
        /// Gets the CSS Style.
        /// </summary>
        public CssStyleWrapper CurrentCell { get; private set; }
    }
}
