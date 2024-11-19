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
    public partial class PaneLayout : IHaveId<string>, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaneLayout"/> class.
        /// </summary>
        /// <param name="id">The unique identifier for the pane layout.</param>
        /// <param name="sections">The collection of sections within the pane.</param>
        public PaneLayout(
            string id,
            IReadOnlyList<PaneSection> sections)
        {
            new { id }.AsArg().Must().NotBeNullNorWhiteSpace();
            new { sections }.AsArg().Must().NotContainAnyNullElements();

            this.Id = id;
            this.Sections = sections;
        }

        /// <summary>
        /// Gets the unique identifier for the pane layout.
        /// </summary>
        public string Id { get; private set; }

        /// <summary>
        /// Gets the collection of sections within the pane.
        /// </summary>
        public IReadOnlyList<PaneSection> Sections { get; private set; }
    }
}
