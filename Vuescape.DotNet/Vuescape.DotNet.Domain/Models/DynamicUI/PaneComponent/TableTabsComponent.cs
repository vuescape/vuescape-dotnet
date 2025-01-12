// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TableTabsComponent.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    using OBeautifulCode.Assertion.Recipes;

    /// <summary>
    /// Represents a table component with an associated payload.
    /// </summary>
    public partial class TableTabsComponent : PaneComponentBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TableTabsComponent"/> class.
        /// </summary>
        /// <param name="payload">The payload containing details of the table component.</param>
        public TableTabsComponent(TableTabsComponentPayload payload)
        {
            new { payload }.AsArg().Must().NotBeNull();

            this.Payload = payload;
        }

        /// <summary>
        /// Gets the type of the pane component.
        /// </summary>
        public override string Type => "tableTabs";

        /// <summary>
        /// Gets the payload containing details of the table component.
        /// </summary>
        public TableTabsComponentPayload Payload { get; private set; }
    }
}
