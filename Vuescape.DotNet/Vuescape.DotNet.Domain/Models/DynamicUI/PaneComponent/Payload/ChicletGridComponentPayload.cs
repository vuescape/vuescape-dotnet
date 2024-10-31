// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ChicletGridComponentPayload.cs" company="Vuescape">
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
    /// Represents properties for a chiclet grid, containing a collection of chiclets.
    /// </summary>
    public class ChicletGridComponentPayload : IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChicletGridComponentPayload"/> class.
        /// </summary>
        /// <param name="chiclets">The collection of chiclets displayed in the grid.</param>
        public ChicletGridComponentPayload(IReadOnlyList<Chiclet> chiclets)
        {
            new { chiclets }.AsArg().Must().NotBeNull();

            this.Chiclets = chiclets;
        }

        /// <summary>
        /// Gets the collection of chiclets displayed in the grid.
        /// </summary>
        public IReadOnlyList<Chiclet> Chiclets { get; }
    }
}
