// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Tab.cs" company="Vuescape">
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
    public abstract partial class Tab : IHaveId<string>, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Tab"/> class.
        /// </summary>
        /// <param name="id">The unique identifier of the tab.</param>
        /// <param name="label">The tab label.</param>
        /// <param name="badge">OPTIONAL badge to display on the tab.</param>
        protected Tab(
            string id,
            string label,
            Badge badge = null)
        {
            new { id }.AsArg().Must().NotBeNullNorWhiteSpace();
            new { label }.AsArg().Must().NotBeNullNorWhiteSpace();

            this.Id = id;
            this.Label = label;
            this.Badge = badge;
        }

        /// <summary>
        /// Gets the unique identifier of the tab.
        /// </summary>
        public string Id { get; private set; }

        /// <summary>
        /// Gets the tab label.
        /// </summary>
        public string Label { get; private set; }

        /// <summary>
        /// Gets the badge to display on the tab.
        /// </summary>
        public Badge Badge { get; private set; }
    }
}
