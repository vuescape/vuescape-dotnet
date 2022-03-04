// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LinkedResourceOpBase.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    using OBeautifulCode.DataStructure;
    using OBeautifulCode.Type;

    /// <summary>
    /// An <see cref="IVoidOperation"/> that uses the contents of an <see cref="ILinkedResource"/> as the input for the operation.
    /// </summary>
    public abstract partial class LinkedResourceOpBase : IVoidOperation, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LinkedResourceOpBase"/> class.
        /// </summary>
        /// <param name="linkedResource">The linked resource.</param>
        protected LinkedResourceOpBase(ILinkedResource linkedResource)
        {
            this.LinkedResource = linkedResource;
        }

        /// <summary>
        /// Gets the linked resource.
        /// </summary>
        public ILinkedResource LinkedResource { get; private set; }
    }
}
