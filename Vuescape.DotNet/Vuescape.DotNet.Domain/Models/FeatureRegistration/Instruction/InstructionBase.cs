// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InstructionBase.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace

namespace Vuescape.DotNet.Domain
{
    using OBeautifulCode.Type;

    /// <summary>
    /// Registers features.
    /// </summary>
    public partial class InstructionBase : IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InstructionBase"/> class.
        /// </summary>
        /// <param name="resourceTarget">The resource target kind.</param>
        public InstructionBase(ResourceTarget resourceTarget)
        {
            this.ResourceTarget = resourceTarget;
        }

        /// <summary>
        /// Gets the resource target kind.
        /// </summary>
        public ResourceTarget ResourceTarget { get; }
    }
}
