// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TableTabsComponent.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    using OBeautifulCode.Type;

    /// <summary>
    /// Represents a table component with an associated payload.
    /// </summary>
    public partial class TableTabsComponent : PaneComponent<TableTabsComponentPayload>, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TableTabsComponent"/> class.
        /// </summary>
        /// <param name="payload">The payload containing details of the table component.</param>
        public TableTabsComponent(TableTabsComponentPayload payload)
            : base(payload, DiscriminatedTypeNames.TableTabsComponent)
        {
        }
    }
}
