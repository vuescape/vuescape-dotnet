// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TableCell.cs" company="Vuescape">
//   Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    using System.Collections.Generic;
    using OBeautifulCode.Type;

    /// <summary>
    /// Represents the properties for a table cell.
    /// </summary>
    public partial class TableCell : IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TableCell"/> class.
        /// </summary>
        /// <param name="displayValue">The value to display in the cell if no component is provided.</param>
        /// <param name="component">The component to use for rendering the cell.</param>
        /// <param name="rawValue">The raw value of the cell.</param>
        /// <param name="comparableValue">The value used for comparisons such as filtering or sorting.</param>
        /// <param name="cssStyles">The inline styles of the cell.</param>
        public TableCell(
            string displayValue = null,
            PaneComponentBase component = null,
            UiObject rawValue = null,
            object comparableValue = null,
            Dictionary<string, string> cssStyles = null)
        {
            this.DisplayValue = displayValue;
            this.Component = component;
            this.RawValue = rawValue;
            this.ComparableValue = comparableValue;
            this.CssStyles = cssStyles ?? new Dictionary<string, string>();
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
        /// Gets the value used for comparisons such as filtering or sorting.
        /// If not provided, the <see cref="DisplayValue"/> will be used, followed by the <see cref="RawValue"/>.
        /// Optional.
        /// </summary>
        public object ComparableValue { get; private set; }

        /// <summary>
        /// Gets the inline styles of the cell.
        /// Optional.
        /// </summary>
        public IReadOnlyDictionary<string, string> CssStyles { get; private set; }
    }
}
