// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ToggleTreeTableChildRowExpansionClientBehavior.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    /// <summary>
    /// A client behavior to add expand/collapse toggle of <see cref="TreeTable"/> child <see cref="TreeTableRow"/>s.
    /// </summary>
    public partial class ToggleTreeTableChildRowExpansionClientBehavior : ClientBehaviorBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ToggleTreeTableChildRowExpansionClientBehavior"/> class.
        /// </summary>
        public ToggleTreeTableChildRowExpansionClientBehavior()
            : base("ToggleTreeTableChildRowExpansionClientBehavior")
        {
        }
    }
}
