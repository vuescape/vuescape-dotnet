// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PaneSection.cs" company="Vuescape">
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
    /// Represents a section within a pane containing a list of pane items.
    /// </summary>
    public class PaneSection : IHaveId<string>, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaneSection"/> class.
        /// </summary>
        /// <param name="id">The unique identifier for the pane section.</param>
        /// <param name="items">The collection of items contained in this pane section.</param>
        public PaneSection(
            string id,
            IReadOnlyList<PaneItem> items)
        {
            new { id }.AsArg().Must().NotBeNullNorWhiteSpace();
            new { items }.AsArg().Must().NotBeNull();

            this.Id = id;
            this.Items = items;
        }

        /// <summary>
        /// Gets the unique identifier for the pane section.
        /// </summary>
        public string Id { get; }

        /// <summary>
        /// Gets the collection of items contained in this pane section.
        /// </summary>
        public IReadOnlyList<PaneItem> Items { get; }
    }
}
