// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TreeTableRowDependencyClientBehavior.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    /// <summary>
    /// A client behavior for handling <see cref="TreeTableRowDependency"/>.
    /// </summary>
    public partial class TreeTableRowDependencyClientBehavior : ClientBehaviorBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TreeTableRowDependencyClientBehavior"/> class.
        /// </summary>
        public TreeTableRowDependencyClientBehavior()
            : base("TreeTableRowDependencyClientBehavior")
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TreeTableRowDependencyClientBehavior"/> class.
        /// </summary>
        /// <param name="name">Name representation of this behavior.</param>
        protected TreeTableRowDependencyClientBehavior(string name)
            : base(name)
        {
        }
    }
}
