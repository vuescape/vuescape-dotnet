// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NullInstruction.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace

namespace Vuescape.DotNet.Domain
{
    using OBeautifulCode.Type;

    /// <summary>
    /// Link.
    /// </summary>
    public partial class NullInstruction : InstructionBase, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NullInstruction"/> class.
        /// </summary>
        public NullInstruction()
            : base(ResourceTarget.None)
        {
        }
    }
}
