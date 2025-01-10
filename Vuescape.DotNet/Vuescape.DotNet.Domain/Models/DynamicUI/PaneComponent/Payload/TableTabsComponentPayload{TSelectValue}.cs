// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TableTabsComponentPayload{TSelectValue}.cs" company="Vuescape">
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
    /// Represents the payload for table tabs. i.e. Tabs that contain tables only.
    /// </summary>
    /// <typeparam name="TSelectValue">The type of the <see cref="SelectComponent{T}"/>.</typeparam>
    public partial class TableTabsComponentPayload<TSelectValue> : IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TableTabsComponentPayload{TSelectValue}"/> class.
        /// </summary>
        /// <param name="id">The identifier for this component.</param>
        /// <param name="tabs">The tabs to display.</param>
        /// <param name="selectComponent">OPTIONAL SelectComponent to display at the top of the tabs.</param>
        public TableTabsComponentPayload(
            string id,
            IReadOnlyList<TableTab> tabs,
            SelectComponent<TSelectValue> selectComponent = null)
        {
            this.Id = id;
            this.Tabs = tabs;
            this.SelectComponent = selectComponent;
            new { id }.AsArg().Must().NotBeNullNorWhiteSpace();
        }

        /// <summary>
        /// Gets the identifier.
        /// </summary>
        public string Id { get; }

        /// <summary>
        /// Gets the list of table tabs.
        /// </summary>
        public IReadOnlyList<TableTab> Tabs { get; }

        /// <summary>
        /// Gets the select component for the table tabs.
        /// </summary>
        public SelectComponent<TSelectValue> SelectComponent { get; }
    }
}
