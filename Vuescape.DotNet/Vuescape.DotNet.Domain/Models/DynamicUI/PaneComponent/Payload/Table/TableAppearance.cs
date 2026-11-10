// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TableAppearance.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    using OBeautifulCode.Type;

    /// <summary>
    /// Represents how a table looks as a whole, as opposed to the format of its cells.
    /// </summary>
    public partial class TableAppearance : IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TableAppearance"/> class.
        /// </summary>
        /// <param name="isStriped">OPTIONAL value indicating whether every other row is shaded, to help follow a row across a wide table.  A list that is read down rather than across, e.g. a navigation's links, reads better without.  DEFAULT is true.</param>
        /// <param name="borders">OPTIONAL lines that separate the cells.  DEFAULT is <see cref="TableBorderKind.Grid"/>.</param>
        public TableAppearance(
            bool isStriped = true,
            TableBorderKind borders = TableBorderKind.Grid)
        {
            this.IsStriped = isStriped;
            this.Borders = borders;
        }

        /// <summary>
        /// Gets a value indicating whether every other row is shaded.
        /// </summary>
        public bool IsStriped { get; private set; }

        /// <summary>
        /// Gets the lines that separate the cells.
        /// </summary>
        public TableBorderKind Borders { get; private set; }
    }
}
