// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TreeTableRowDependency.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

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
        /// <param name="dependencyTypeName">The dependency type name.</param>
        /// <param name="payload">The payload for this dependency.</param>
        public TreeTableRowDependency(
            string targetId,
            string dependencyTypeName,
            IObject payload)
        {
            new { targetId }.AsArg().Must().NotBeNullNorWhiteSpace();
            new { dependencyTypeName }.AsArg().Must().NotBeNullNorWhiteSpace();

            this.TargetId = targetId;
            this.DependencyTypeName = dependencyTypeName;
            this.Payload = payload;
        }

        /// <summary>
        /// Gets the target ID.
        /// </summary>
        /// <remarks>
        /// This should be an identifier of the target that is dependent on this item.
        /// </remarks>
        public string TargetId { get; private set; }

        /// <summary>
        /// Gets the type name of the dependency.
        /// </summary>
        /// <remarks>
        /// This is the type name of the dependency, e.g. totalRowDisplayToggle, not a .NET type.
        /// </remarks>
        public string DependencyTypeName { get; private set; }

        /// <summary>
        /// Gets the Payload.
        /// </summary>
        public IObject Payload { get; private set; }
    }
}
