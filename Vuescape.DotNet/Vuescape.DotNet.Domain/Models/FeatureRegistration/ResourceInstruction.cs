// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ResourceInstruction.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace

namespace Vuescape.DotNet.Domain
{
    using System;

    using OBeautifulCode.DataStructure;
    using OBeautifulCode.Type;

    using static System.FormattableString;

    /// <summary>
    /// A resource instruction.
    /// </summary>
    public partial class ResourceInstruction : IModelViaCodeGen
    {
        /// <summary>
        /// Create a default <see cref="ResourceInstruction"/> for the specified <paramref name="resourceTarget"/>.
        /// </summary>
        /// <param name="linkedResource">The linked resource to retrieve.</param>
        /// <param name="resourceTarget">The resource target.</param>
        /// <returns>A <see cref="ResourceInstruction"/> with the default <see cref="InstructionBase"/> for the specified resourceTarget.</returns>
        public static ResourceInstruction CreateDefaultInstructionForTarget(ILinkedResource linkedResource, ResourceTarget resourceTarget)
        {
            switch (resourceTarget)
            {
                case ResourceTarget.None:
                    return CreateNull();
                case ResourceTarget.CenterPane:
                case ResourceTarget.LeftPane:
                case ResourceTarget.RightPane:
                    return new ResourceInstruction(linkedResource, new ReportPaneInstruction(resourceTarget));
                case ResourceTarget.Modal:
                case ResourceTarget.DownloadTextFile:
                case ResourceTarget.DownloadBase64EncodedFile:
                    throw new NotSupportedException(Invariant($"{nameof(resourceTarget)} value '{resourceTarget}' is not supported."));
                default:
                    throw new ArgumentOutOfRangeException(nameof(resourceTarget), resourceTarget, null);
            }
        }

        /// <summary>
        /// Create a null resource instruction.
        /// </summary>
        /// <returns>A <see cref="ResourceInstruction"/> instance with a <see cref="NullLinkedResource"/> and a <see cref="NullInstruction"/>.</returns>
        public static ResourceInstruction CreateNull()
        {
            return new ResourceInstruction(new NullLinkedResource(), new NullInstruction());
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceInstruction"/> class.
        /// <param name="linkedResource">The linked resource to retrieve.</param>
        /// <param name="instruction">The resource target.</param>
        /// </summary>
        public ResourceInstruction(ILinkedResource linkedResource, InstructionBase instruction)
        {
            this.LinkedResource = linkedResource;
            this.Instruction = instruction;
        }

        /// <summary>
        /// Gets the linked resource.
        /// </summary>
        public ILinkedResource LinkedResource { get; }

        /// <summary>
        /// Gets the resource target.
        /// </summary>
        public InstructionBase Instruction { get; }
    }
}
