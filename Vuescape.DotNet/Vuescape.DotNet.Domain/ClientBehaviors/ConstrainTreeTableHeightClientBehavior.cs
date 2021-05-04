// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConstrainTreeTableHeightClientBehavior.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    /// <summary>
    /// A client behavior to adjust <see cref="TreeTable"/> height to fill available space.
    /// </summary>
    public partial class ConstrainTreeTableHeightClientBehavior : ClientBehaviorBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConstrainTreeTableHeightClientBehavior"/> class.
        /// </summary>
        public ConstrainTreeTableHeightClientBehavior()
            : base("ConstrainTreeTableHeightBehavior")
        {
        }
    }
}
