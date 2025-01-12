// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TableColumn.cs" company="Vuescape">
//   Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    using System.Collections.Generic;
    using OBeautifulCode.Type;

    /// <summary>
    /// Represents a column in a table.
    /// </summary>
    public partial class TableColumn : IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TableColumn"/> class.
        /// </summary>
        /// <param name="id">The identifier of the column.</param>
        /// <param name="dataType">The type of data for the column.</param>
        /// <param name="isSortable">Whether the column is sortable.</param>
        /// <param name="sortMode">The sort mode for the column.</param>
        /// <param name="isFilterable">Whether the column is filterable.</param>
        /// <param name="filterMode">The filter mode for the column.</param>
        /// <param name="headerText">The header text of the column.</param>
        /// <param name="footerText">The footer text of the column.</param>
        /// <param name="style">The inline styles for the column cells.</param>
        /// <param name="cssClass">The CSS classes for the column cells.</param>
        /// <param name="headerStyle">The inline styles for the column header.</param>
        /// <param name="cssHeaderClass">The CSS classes for the column header.</param>
        /// <param name="bodyStyle">The inline styles for the column body.</param>
        /// <param name="cssBodyClass">The CSS classes for the column body.</param>
        /// <param name="footerStyle">The inline styles for the column footer.</param>
        /// <param name="cssFooterClass">The CSS classes for the column footer.</param>
        /// <param name="colspan">The number of columns to span for grouping.</param>
        /// <param name="rowspan">The number of rows to span for grouping.</param>
        /// <param name="isFrozen">Whether the column is fixed in horizontal scrolling.</param>
        /// <param name="alignFrozen">The position of the frozen column.</param>
        /// <param name="isHidden">Whether the column is rendered.</param>
        public TableColumn(
            string id,
            DataTypeKind? dataType = null,
            bool? isSortable = null,
            SortModeKind? sortMode = null,
            bool? isFilterable = null,
            FilterModeKind? filterMode = null,
            string headerText = null,
            string footerText = null,
            IReadOnlyDictionary<string, string> style = null,
            string cssClass = null,
            IReadOnlyDictionary<string, string> headerStyle = null,
            string cssHeaderClass = null,
            IReadOnlyDictionary<string, string> bodyStyle = null,
            string cssBodyClass = null,
            IReadOnlyDictionary<string, string> footerStyle = null,
            string cssFooterClass = null,
            int? colspan = null,
            int? rowspan = null,
            bool? isFrozen = null,
            string alignFrozen = null,
            bool? isHidden = null)
        {
            this.Id = id;
            this.DataType = dataType;
            this.IsSortable = isSortable;
            this.SortMode = sortMode;
            this.IsFilterable = isFilterable;
            this.FilterMode = filterMode;
            this.HeaderText = headerText;
            this.FooterText = footerText;
            this.Style = style ?? new Dictionary<string, string>();
            this.CssClass = cssClass;
            this.HeaderStyle = headerStyle ?? new Dictionary<string, string>();
            this.CssHeaderClass = cssHeaderClass;
            this.BodyStyle = bodyStyle ?? new Dictionary<string, string>();
            this.CssBodyClass = cssBodyClass;
            this.FooterStyle = footerStyle ?? new Dictionary<string, string>();
            this.CssFooterClass = cssFooterClass;
            this.Colspan = colspan;
            this.Rowspan = rowspan;
            this.IsFrozen = isFrozen;
            this.AlignFrozen = alignFrozen;
            this.IsHidden = isHidden;
        }

        /// <summary>
        /// Gets the identifier of the column if the field property is not defined.
        /// </summary>
        public string Id { get; private set; }

        /// <summary>
        /// Gets the type of data for the column.
        /// Optional.
        /// </summary>
        public DataTypeKind? DataType { get; private set; }

        /// <summary>
        /// Gets a value indicating whether the column is sortable.
        /// Optional.
        /// </summary>
        public bool? IsSortable { get; private set; }

        /// <summary>
        /// Gets the sort mode for the column.
        /// Optional.
        /// </summary>
        public SortModeKind? SortMode { get; private set; }

        /// <summary>
        /// Gets a value indicating whether the column is filterable.
        /// Optional.
        /// </summary>
        public bool? IsFilterable { get; private set; }

        /// <summary>
        /// Gets the filter mode for the column.
        /// Optional.
        /// </summary>
        public FilterModeKind? FilterMode { get; private set; }

        /// <summary>
        /// Gets the header text of the column.
        /// Optional.
        /// </summary>
        public string HeaderText { get; private set; }

        /// <summary>
        /// Gets the footer text of the column.
        /// Optional.
        /// </summary>
        public string FooterText { get; private set; }

        /// <summary>
        /// Gets the inline styles for the header, body, and footer cells.
        /// Optional.
        /// </summary>
        public IReadOnlyDictionary<string, string> Style { get; private set; }

        /// <summary>
        /// Gets the CSS classes for the header, body, and footer cells.
        /// Optional.
        /// </summary>
        public string CssClass { get; private set; }

        /// <summary>
        /// Gets the inline styles for the column header.
        /// Optional.
        /// </summary>
        public IReadOnlyDictionary<string, string> HeaderStyle { get; private set; }

        /// <summary>
        /// Gets the CSS class for the column header.
        /// Optional.
        /// </summary>
        public string CssHeaderClass { get; private set; }

        /// <summary>
        /// Gets the inline styles for the column body.
        /// Optional.
        /// </summary>
        public IReadOnlyDictionary<string, string> BodyStyle { get; private set; }

        /// <summary>
        /// Gets the CSS class for the column body.
        /// Optional.
        /// </summary>
        public string CssBodyClass { get; private set; }

        /// <summary>
        /// Gets the inline styles for the column footer.
        /// Optional.
        /// </summary>
        public IReadOnlyDictionary<string, string> FooterStyle { get; private set; }

        /// <summary>
        /// Gets the CSS class for the column footer.
        /// Optional.
        /// </summary>
        public string CssFooterClass { get; private set; }

        /// <summary>
        /// Gets the number of columns to span for grouping.
        /// Optional.
        /// </summary>
        public int? Colspan { get; private set; }

        /// <summary>
        /// Gets the number of rows to span for grouping.
        /// Optional.
        /// </summary>
        public int? Rowspan { get; private set; }

        /// <summary>
        /// Gets a value indicating whether the column is fixed in horizontal scrolling.
        /// Optional.
        /// </summary>
        public bool? IsFrozen { get; private set; }

        /// <summary>
        /// Gets the position of a frozen column. Valid values are "left" and "right".
        /// Optional.
        /// </summary>
        public string AlignFrozen { get; private set; }

        /// <summary>
        /// Gets a value indicating whether the column is rendered.
        /// Optional.
        /// </summary>
        public bool? IsHidden { get; private set; }
    }
}
