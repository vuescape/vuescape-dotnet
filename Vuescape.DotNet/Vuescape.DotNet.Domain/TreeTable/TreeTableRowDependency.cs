// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TreeTableRowDependency.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Type;

    /// <summary>
    /// Represents a Tree Table item dependency.
    /// </summary>
    public partial class TreeTableRowDependency : IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TreeTableRowDependency"/> class.
        /// </summary>
        /// <param name="targetId">The identifier of the target that is dependent on this item.</param>
        /// <param name="treeTableRowDependencyClientBehavior">The client behavior for this dependency.</param>
        /// <param name="payload">The payload for this dependency.</param>
        public TreeTableRowDependency(
            string targetId,
            TreeTableRowDependencyClientBehavior treeTableRowDependencyClientBehavior,
            IObject payload = null)
        {
            new { targetId }.AsArg().Must().NotBeNullNorWhiteSpace();
            new { treeTableRowDependencyClientBehavior }.AsArg().Must().NotBeNull();

            this.TargetId = targetId;
            this.TreeTableRowDependencyClientBehavior = treeTableRowDependencyClientBehavior;
            this.Payload = payload;
        }

        /// <summary>
        /// Gets the target ID.
        /// </summary>
        /// <remarks>
        /// This should be the identifier of the target that of this dependency.
        /// </remarks>
        public string TargetId { get; private set; }

        /// <summary>
        /// Gets the client behavior for this <see cref="TreeTableRowDependency"/>.
        /// </summary>
        public TreeTableRowDependencyClientBehavior TreeTableRowDependencyClientBehavior { get; private set; }

        /// <summary>
        /// Gets the Payload.
        /// </summary>
        public IObject Payload { get; private set; }
    }
}
