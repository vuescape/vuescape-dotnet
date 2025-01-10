// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TableTab.cs" company="Vuescape">
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
    public partial class TableTab : IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TableTab"/> class.
        /// </summary>
        /// <param name="table">The table to display in the tab.</param>
        public TableTab(
            TableComponent table)
        {
            new { table }.AsArg().Must().NotBeNull();

            this.Table = table;
        }

        /// <summary>
        /// Gets the table to display in the tab.
        /// </summary>
        public TableComponent Table { get; }
    }
}
