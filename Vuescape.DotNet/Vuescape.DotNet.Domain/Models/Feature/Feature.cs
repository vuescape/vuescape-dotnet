// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Feature.cs" company="Vuescape">
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
    /// A Feature is an identified list of operations.
    /// </summary>
    public partial class Feature : IHaveStringId, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Feature"/> class.
        /// </summary>
        /// <param name="id">The ID.</param>
        /// <param name="operations">The operations to invoke for this feature.
        /// Note that arbitrary <see cref="IVoidOperation"/> are not supported -- operations must be implemented in Vuescape web.</param>
        public Feature(string id, IReadOnlyList<IVoidOperation> operations)
        {
            id.MustForArg(nameof(id)).NotBeNullNorWhiteSpace();
            operations.MustForArg(nameof(operations)).NotBeNullNorEmptyEnumerableNorContainAnyNulls();

            this.Id = id;
            this.Operations = operations;
        }

        /// <inheritdoc />
        public string Id { get; private set; }

        /// <summary>
        /// Gets the operations for this feature.
        /// </summary>
        public IReadOnlyList<IVoidOperation> Operations { get; private set; }
    }
}
