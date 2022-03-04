// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DisplayReportOp.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace

namespace Vuescape.DotNet.Domain
{
    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.DataStructure;
    using OBeautifulCode.Type;

    /// <summary>
    /// An operation to display a report in a pane.
    /// </summary>
    public partial class DisplayReportOp : LinkedResourceOpBase, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DisplayReportOp"/> class.
        /// </summary>
        /// <param name="linkedResource">The linked resource.</param>
        /// <param name="targetedPaneKind">The pane to target.</param>
        /// <param name="initialWidth">OPTIONAL. The initial width. If null, the UI will default to a reasonable value based on the <paramref name="targetedPaneKind"/>.</param>
        /// <param name="minimumWidth">OPTIONAL. The minimum width. If null, the UI will default to a reasonable value based on the <paramref name="targetedPaneKind"/>.</param>
        /// <param name="maximumWidth">OPTIONAL. The maximum width. If null, the UI will default to a reasonable value based on the <paramref name="targetedPaneKind"/>.</param>
        /// <param name="reportPaneTitleBarButtons">OPTIONAL. The report pane title bar buttons to display.</param>
        public DisplayReportOp(
            ILinkedResource linkedResource,
            PaneKind targetedPaneKind,
            int? initialWidth = null,
            int? minimumWidth = null,
            int? maximumWidth = null,
            ReportPaneTitleBarButtons? reportPaneTitleBarButtons = null)
            : base(linkedResource)
        {
            targetedPaneKind.MustForArg().NotBeEqualTo(PaneKind.None);

            this.TargetedPaneKind = targetedPaneKind;
            this.InitialWidth = initialWidth;
            this.MinimumWidth = minimumWidth;
            this.MaximumWidth = maximumWidth;
            this.ReportPaneTitleBarButtons = reportPaneTitleBarButtons;
        }

        /// <summary>
        /// Gets the pane to target for displaying the report.
        /// </summary>
        public PaneKind TargetedPaneKind { get; private set; }

        /// <summary>
        /// Gets the initial width of the pane.
        /// </summary>
        public int? InitialWidth { get; private set; }

        /// <summary>
        /// Gets the minimum width of the pane.
        /// </summary>
        public int? MinimumWidth { get; private set; }

        /// <summary>
        /// Gets the maximum width of the pane.
        /// </summary>
        public int? MaximumWidth { get; private set; }

        /// <summary>
        /// Gets the <see cref="ReportPaneTitleBarButtons"/> of the report pane.
        /// </summary>
        public ReportPaneTitleBarButtons? ReportPaneTitleBarButtons { get; private set; }
    }
}
