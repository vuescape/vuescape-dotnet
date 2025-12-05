// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ReportLayout.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    using System;
    using System.Collections.Generic;
    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Type;

    /// <summary>
    /// Represents the layout for a report with defined sections for left, right, and center panes.
    /// </summary>
    public partial class ReportLayout : IHaveId<string>, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportLayout"/> class.
        /// </summary>
        /// <param name="id">The unique identifier for the report layout.</param>
        /// <param name="content">The report content.</param>
        /// <param name="title">OPTIONAL title of the report layout. Default is no title.</param>
        /// <param name="targetPane">OPTIONAL pane to target when rendering the report. Default is no PaneKind.</param>
        /// <param name="paneWidthPercent">OPTIONAL default paneWidth in percent. Default is no percentage.</param>
        /// <param name="actionButton">OPTIONAL action button typically used for downloading.  DEFAULT is no action button.</param>
        /// <param name="reportDetail">OPTIONAL report detail.  DEFAULT no report detail.</param>
        public ReportLayout(
            string id,
            PaneLayout content,
            string title = null,
            PaneKind? targetPane = null,
            decimal? paneWidthPercent = null,
            ActionButtonComponent actionButton = null,
            string reportDetail = null)
        {
            new { id }.AsArg().Must().NotBeNullNorWhiteSpace();
            new { content }.AsArg().Must().NotBeNull();

            this.Id = id;
            this.Content = content;
            this.Title = title;
            this.TargetPane = targetPane;
            this.PaneWidthPercent = paneWidthPercent;
            this.ActionButton = actionButton;
            this.ReportDetail = reportDetail;
        }

        /// <summary>
        /// Gets the unique identifier for the report layout.
        /// </summary>
        public string Id { get; private set; }

        /// <summary>
        /// Gets the layout configuration for the left pane.
        /// </summary>
        public PaneLayout Content { get; private set; }

        /// <summary>
        /// Gets the title of the report layout, if available.
        /// </summary>
        public string Title { get; private set; }

        /// <summary>
        /// Gets the target pane.
        /// </summary>
        public PaneKind? TargetPane { get; private set; }

        /// <summary>
        /// Gets the pane width in percent.
        /// </summary>
        public decimal? PaneWidthPercent { get; private set; }

        /// <summary>
        /// Gets the action button.
        /// </summary>
        public ActionButtonComponent ActionButton { get; private set; }

        /// <summary>
        /// Gets the report detail.
        /// </summary>
        public string ReportDetail { get; private set; }
    }
}
