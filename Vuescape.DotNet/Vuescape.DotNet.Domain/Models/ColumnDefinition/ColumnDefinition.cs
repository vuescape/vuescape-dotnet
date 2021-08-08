// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ColumnDefinition.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Type;

    /// <summary>
    /// This class contains the column definition.
    /// </summary>
    public partial class ColumnDefinition : IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ColumnDefinition"/> class.
        /// </summary>
        /// <param name="columnWidthBehavior">The column width behavior.</param>
        /// <param name="columnWrapBehavior">The column wrapping behavior.</param>
        /// <param name="width">The width of the column.</param>
        /// <param name="widthUnitOfMeasure">The unit of measure for the width.</param>
        public ColumnDefinition(ColumnWidthBehavior columnWidthBehavior, ColumnWrapBehavior columnWrapBehavior, decimal? width, UnitOfMeasure? widthUnitOfMeasure)
        {
            new { columnWidthBehavior }.AsArg().Must().NotBeEqualTo(ColumnWidthBehavior.None);

            if (widthUnitOfMeasure != null)
            {
                new { width }.AsArg().Must().NotBeNull();
                new { widthUnitOfMeasure.Value }.AsArg().Must().NotBeEqualTo(UnitOfMeasure.None);
            }

            if (width != null && width != 0)
            {
                new { widthUnitOfMeasure.Value }.AsArg().Must().NotBeEqualTo(UnitOfMeasure.None);
            }

            this.ColumnWidthBehavior = columnWidthBehavior;
            this.ColumnWrapBehavior = columnWrapBehavior;
            this.Width = width;
            this.WidthUnitOfMeasure = widthUnitOfMeasure;
        }

        /// <summary>
        /// Gets the cell width behavior.
        /// </summary>
        public ColumnWidthBehavior ColumnWidthBehavior { get; private set; }

        /// <summary>
        /// Gets the cell wrap behavior.
        /// </summary>
        public ColumnWrapBehavior ColumnWrapBehavior { get; private set; }

        /// <summary>
        /// Gets the cell width.
        /// </summary>
        public decimal? Width { get; private set; }

        /// <summary>
        /// Gets unit of measure for the width.
        /// </summary>
        public UnitOfMeasure? WidthUnitOfMeasure { get; private set; }
    }
}
