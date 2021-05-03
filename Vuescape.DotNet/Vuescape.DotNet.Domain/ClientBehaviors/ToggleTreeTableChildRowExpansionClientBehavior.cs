// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ToggleTreeTableChildRowExpansionClientBehavior.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace

namespace Vuescape.DotNet.Domain
{
    using OBeautifulCode.Type;

    /// <summary>
    /// Behavior to add expand/collapse toggle of child rows.
    /// </summary>
    public partial class ToggleTreeTableChildRowExpansionClientBehavior : ClientBehaviorBase, IModelViaCodeGen
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
