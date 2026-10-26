// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TableTab.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    using System.Diagnostics.CodeAnalysis;
    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Type;

    /// <summary>
    /// Represents the layout for a report with defined sections for left, right, and center panes.
    /// </summary>
    public partial class TableTab : Tab, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TableTab"/> class.
        /// </summary>
        /// <param name="id">The unique identifier of the tab.</param>
        /// <param name="label">The tab label.</param>
        /// <param name="table">The table to display in the tab, or null for a deferred tab whose <paramref name="onSelectAction"/> loads its content.</param>
        /// <param name="badge">OPTIONAL badge to display on the tab.</param>
        /// <param name="onSelectAction">OPTIONAL action to perform when the tab is selected.  Required when <paramref name="table"/> is null.</param>
        [SuppressMessage("StyleCop.CSharp.NamingRules", "SA1305:Field names should not use Hungarian notation", Justification = "This is not Hungarian notation")]
        public TableTab(
            string id,
            string label,
            TableComponent table,
            Badge badge = null,
            ActionBase onSelectAction = null)
        : base(id, label, badge)
        {
            if (table == null)
            {
                new { onSelectAction }.AsArg().Must().NotBeNull();
            }

            this.Table = table;
            this.OnSelectAction = onSelectAction;
        }

        /// <summary>
        /// Gets the table to display in the tab, or null for a deferred tab whose <see cref="OnSelectAction"/> loads its content.
        /// </summary>
        public TableComponent Table { get; private set; }

        /// <summary>
        /// Gets the action to perform when the tab is selected (e.g. navigate to the route that renders the report with this tab's table).
        /// </summary>
        public ActionBase OnSelectAction { get; private set; }
    }
}
