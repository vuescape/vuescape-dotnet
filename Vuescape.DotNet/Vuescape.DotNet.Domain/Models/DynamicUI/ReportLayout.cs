﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ReportLayout.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
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
        /// <param name="title">The title of the report layout. OPTIONAL.</param>
        public ReportLayout(
            string id,
            PaneLayout content,
            string title = null)
        {
            new { id }.AsArg().Must().NotBeNullNorWhiteSpace();
            new { content }.AsArg().Must().NotBeNull();

            this.Id = id;
            this.Content = content;
            this.Title = title;
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
    }
}
