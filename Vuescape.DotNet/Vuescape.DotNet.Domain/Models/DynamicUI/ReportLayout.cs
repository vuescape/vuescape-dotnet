﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ReportLayout.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    using System;
    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Type;

    using static System.FormattableString;

    /// <summary>
    /// Represents the layout for a report with defined sections for left, right, and center panes.
    /// </summary>
    public partial class ReportLayout : IHaveId<string>, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportLayout"/> class.
        /// </summary>
        /// <param name="id">The unique identifier for the report layout.</param>
        /// <param name="leftPane">The layout configuration for the left pane.</param>
        /// <param name="rightPane">The layout configuration for the right pane.</param>
        /// <param name="centerPane">The layout configuration for the center pane.</param>
        /// <param name="title">The title of the report layout. OPTIONAL.</param>
        public ReportLayout(
            string id,
            PaneLayout leftPane,
            PaneLayout rightPane,
            PaneLayout centerPane,
            string title = null)
        {
            new { id }.AsArg().Must().NotBeNullNorWhiteSpace();
            if (leftPane == null && rightPane == null && centerPane == null)
            {
                throw new ArgumentNullException(Invariant(
                    $"All of {nameof(leftPane)}, {nameof(rightPane)}, and {nameof(centerPane)} are null."));
            }

            this.Id = id;
            this.LeftPane = leftPane;
            this.RightPane = rightPane;
            this.CenterPane = centerPane;
            this.Title = title;
        }

        /// <summary>
        /// Gets the unique identifier for the report layout.
        /// </summary>
        public string Id { get; private set; }

        /// <summary>
        /// Gets the title of the report layout, if available.
        /// </summary>
        public string Title { get; private set; }

        /// <summary>
        /// Gets the layout configuration for the left pane.
        /// </summary>
        public PaneLayout LeftPane { get; private set; }

        /// <summary>
        /// Gets the layout configuration for the right pane.
        /// </summary>
        public PaneLayout RightPane { get; private set; }

        /// <summary>
        /// Gets the layout configuration for the center pane.
        /// </summary>
        public PaneLayout CenterPane { get; private set; }
    }
}
