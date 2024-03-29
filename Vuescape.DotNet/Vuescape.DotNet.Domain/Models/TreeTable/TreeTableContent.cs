﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TreeTableContent.cs" company="Vuescape">
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
    /// The sort direction of the TreeTable.
    /// </summary>
    public partial class TreeTableContent : IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TreeTableContent"/> class.
        /// </summary>
        /// <param name="headers">The headers.</param>
        /// <param name="rows">The rows.</param>
        /// <param name="footers">The footers.</param>
        /// <param name="shouldScrollVertical">Whether the table should scroll vertically.</param>
        /// <param name="shouldScrollHorizontal">Whether the table should scroll horizontally.</param>
        /// <param name="shouldSyncHeaderScroll">Whether the table header should scroll with the rows.</param>
        /// <param name="shouldSyncFooterScroll">Whether the table footer should scroll with the rows.</param>
        /// <param name="shouldIncludeFooter">Whether to render a footer.</param>
        /// <param name="deadAreaColor">The color of the dead area.</param>
        /// <param name="maxRows">The maximum number of rows to display.</param>
        /// <param name="cssClass">The CSS class to apply to the parent div.</param>
        /// <param name="cssStyles">The CSS style to apply to the parent div.</param>
        /// <param name="sortLevel">The level to sort on.</param>
        public TreeTableContent(
            IReadOnlyList<TreeTableHeaderRow> headers,
            IReadOnlyList<TreeTableRow> rows,
            IReadOnlyList<TreeTableRow> footers,
            bool shouldScrollVertical,
            bool shouldScrollHorizontal,
            bool shouldSyncHeaderScroll,
            bool shouldSyncFooterScroll,
            bool shouldIncludeFooter,
            string deadAreaColor,
            int? maxRows,
            string cssClass,
            IReadOnlyDictionary<string, string> cssStyles,
            SortLevel sortLevel)
        {
            new { rows }.AsArg().Must().NotBeNull();

            this.Headers = headers;
            this.Rows = rows;
            this.Footers = footers;
            this.ShouldScrollVertical = shouldScrollVertical;
            this.ShouldScrollHorizontal = shouldScrollHorizontal;
            this.ShouldSyncHeaderScroll = shouldSyncHeaderScroll;
            this.ShouldSyncFooterScroll = shouldSyncFooterScroll;
            this.ShouldIncludeFooter = shouldIncludeFooter;
            this.DeadAreaColor = deadAreaColor;
            this.MaxRows = maxRows;
            this.CssClass = cssClass;
            this.CssStyles = cssStyles;
            this.SortLevel = sortLevel;
        }

        /// <summary>
        /// Gets the Headers.
        /// </summary>
        public IReadOnlyList<TreeTableHeaderRow> Headers { get; private set; }

        /// <summary>
        /// Gets the Rows.
        /// </summary>
        public IReadOnlyList<TreeTableRow> Rows { get; private set; }

        /// <summary>
        /// Gets the Footers.
        /// </summary>
        public IReadOnlyList<TreeTableRow> Footers { get; private set; }

        /// <summary>
        /// Gets a value indicating whether the TreeTable should scroll vertically.
        /// </summary>
        public bool ShouldScrollVertical { get; private set; }

        /// <summary>
        /// Gets a value indicating whether the TreeTable should scroll horizontally.
        /// </summary>
        public bool ShouldScrollHorizontal { get; private set; }

        /// <summary>
        /// Gets a value indicating whether the TreeTable header should scroll horizontally with the rows.
        /// </summary>
        public bool ShouldSyncHeaderScroll { get; private set; }

        /// <summary>
        /// Gets a value indicating whether the TreeTable footer should scroll horizontally with the rows.
        /// </summary>
        public bool ShouldSyncFooterScroll { get; private set; }

        /// <summary>
        /// Gets a value indicating whether the TreeTable should include a footer.
        /// </summary>
        public bool ShouldIncludeFooter { get; private set; }

        /// <summary>
        /// Gets the color of the dead area if the rows or columns don't fill the parent space.
        /// </summary>
        public string DeadAreaColor { get; private set; }

        /// <summary>
        /// Gets the maximum number of rows to display.
        /// </summary>
        public int? MaxRows { get; private set; }

        /// <summary>
        /// Gets the CSS Class of the parent div.
        /// </summary>
        public string CssClass { get; private set; }

        /// <summary>
        /// Gets the Styles of the parent div.
        /// </summary>
        public IReadOnlyDictionary<string, string> CssStyles { get; private set; }

        /// <summary>
        /// Gets the <see cref="SortLevel"/>.
        /// </summary>
        public SortLevel SortLevel { get; private set; }
    }
}
