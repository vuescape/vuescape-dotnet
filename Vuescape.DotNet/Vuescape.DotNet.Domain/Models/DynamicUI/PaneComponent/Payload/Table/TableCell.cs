// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TableCell.cs" company="Vuescape">
//   Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.CodeAnalysis.Recipes;
    using OBeautifulCode.Type;

    /// <summary>
    /// Represents the properties for a table cell.
    /// </summary>
    public partial class TableCell : IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TableCell"/> class.
        /// </summary>
        /// <param name="displayValue">OPTIONAL The value to display in the cell if no component is provided.</param>
        /// <param name="component">OPTIONAL The component to use for rendering the cell.</param>
        /// <param name="rawValue">OPTIONAL The raw value of the cell.</param>
        /// <param name="comparableValue">OPTIONAL The value used for comparisons such as filtering or sorting as a string.</param>
        /// <param name="cssStyles">OPTIONAL The inline styles of the cell.</param>
        /// <param name="colspan">OPTIONAL How many columns the cell spans, from its own column.  A header or footer row leaves out the cells of the columns it covers; a body row's cells in those columns, if it has them, aren't shown.  A span stays on one side of the frozen columns' edge.  DEFAULT is 1.</param>
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "colspan", Justification = ObcSuppressBecause.CA1704_IdentifiersShouldBeSpelledCorrectly_SpellingIsCorrectInContextOfTheDomain)]
        public TableCell(
            string displayValue = null,
            PaneComponentBase component = null,
            UiObject rawValue = null,
            ComparableValue comparableValue = null,
            IReadOnlyDictionary<string, string> cssStyles = null,
            int? colspan = null)
        {
            new { cssStyles }.AsArg().Must().NotContainAnyKeyValuePairsWithNullValueWhenNotNull();

            this.DisplayValue = displayValue;
            this.Component = component;
            this.RawValue = rawValue;
            this.ComparableValue = comparableValue;
            this.CssStyles = cssStyles;
            this.Colspan = colspan;
        }

        /// <summary>
        /// Gets the value to display in the cell if no component is provided.
        /// Optional.
        /// </summary>
        public string DisplayValue { get; private set; }

        /// <summary>
        /// Gets the component to use for rendering the cell.
        /// If not provided, the <see cref="DisplayValue"/> will be used.
        /// Optional.
        /// </summary>
        public PaneComponentBase Component { get; private set; }

        /// <summary>
        /// Gets the raw value of the cell.
        /// Optional.
        /// </summary>
        public UiObject RawValue { get; private set; }

        /// <summary>
        /// Gets the value used for comparisons such as filtering or sorting as a string.
        /// If not provided, the <see cref="DisplayValue"/> will be used, followed by the <see cref="RawValue"/>.
        /// Optional.
        /// </summary>
        public ComparableValue ComparableValue { get; private set; }

        /// <summary>
        /// Gets the inline styles of the cell.
        /// Optional.
        /// </summary>
        public IReadOnlyDictionary<string, string> CssStyles { get; private set; }

        /// <summary>
        /// Gets how many columns the cell spans, from its own column.
        /// A header or footer row leaves out the cells of the columns it covers; a body row's cells in those columns, if it
        /// has them, aren't shown.
        /// Optional.  Null means 1.
        /// </summary>
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Colspan", Justification = ObcSuppressBecause.CA1704_IdentifiersShouldBeSpelledCorrectly_SpellingIsCorrectInContextOfTheDomain)]
        public int? Colspan { get; private set; }
    }
}
