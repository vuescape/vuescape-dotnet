// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ReportPaneInstruction.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace

namespace Vuescape.DotNet.Domain
{
    using OBeautifulCode.Type;

    /// <summary>
    /// Link.
    /// </summary>
    public partial class ReportPaneInstruction : InstructionBase, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportPaneInstruction"/> class.
        /// </summary>
        /// <param name="resourceTarget">The resource target.</param>
        /// <param name="initialWidth">OPTIONAL. The initial width.</param>
        /// <param name="minimumWidth">OPTIONAL. The minimum width.</param>
        /// <param name="maximumWidth">OPTIONAL. The maximum width.</param>
        /// <param name="reportPaneTitleBarButtons">OPTIONAL. The report pane title bar buttons to display.</param>
        public ReportPaneInstruction(ResourceTarget resourceTarget, int? initialWidth = null, int? minimumWidth = null, int? maximumWidth = null, ReportPaneTitleBarButtons? reportPaneTitleBarButtons = null)
            : base(resourceTarget)
        {
            this.InitialWidth = initialWidth;
            this.MinimumWidth = minimumWidth;
            this.MaximumWidth = maximumWidth;
            this.ReportPaneTitleBarButtons = reportPaneTitleBarButtons;
        }

        /// <summary>
        /// Gets the initial width.
        /// </summary>
        public int? InitialWidth { get; }

        /// <summary>
        /// Gets the minimum width.
        /// </summary>
        public int? MinimumWidth { get; }

        /// <summary>
        /// Gets the maximum width.
        /// </summary>
        public int? MaximumWidth { get; }

        /// <summary>
        /// Gets the <see cref="ReportPaneTitleBarButtons"/> for the report pane.
        /// </summary>
        public ReportPaneTitleBarButtons? ReportPaneTitleBarButtons { get; }
    }
}
