// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PaneLayout.cs" company="Vuescape">
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
    /// Represents the layout of a pane, including its sections and width percentage.
    /// </summary>
    public class PaneLayout : IHaveId<string>, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaneLayout"/> class.
        /// </summary>
        /// <param name="id">The unique identifier for the pane layout.</param>
        /// <param name="sections">The collection of sections within the pane.</param>
        /// <param name="paneWidthPercent">The width of the pane as a percentage.</param>
        public PaneLayout(
            string id,
            IReadOnlyList<PaneSection> sections,
            double paneWidthPercent)
        {
            new { id }.AsArg().Must().NotBeNullNorWhiteSpace();
            new { sections }.AsArg().Must().NotBeNull();

            this.Id = id;
            this.Sections = sections;
            this.PaneWidthPercent = paneWidthPercent;
        }

        /// <summary>
        /// Gets the unique identifier for the pane layout.
        /// </summary>
        public string Id { get; }

        /// <summary>
        /// Gets the collection of sections within the pane.
        /// </summary>
        public IReadOnlyList<PaneSection> Sections { get; }

        /// <summary>
        /// Gets the width of the pane as a percentage.
        /// </summary>
        public double PaneWidthPercent { get; }
    }
}
