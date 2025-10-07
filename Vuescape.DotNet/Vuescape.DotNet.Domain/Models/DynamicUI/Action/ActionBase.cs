// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ActionBase.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    using System.Diagnostics.CodeAnalysis;
    using OBeautifulCode.Type;

    /// <summary>
    /// Represents an action, which can be a navigation action or an unknown action.
    /// </summary>
    public abstract partial class ActionBase : DiscriminatedTypeBase, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActionBase"/> class.
        /// </summary>
        /// <param name="typeName">The globally unique discriminator for this action.</param>
        protected ActionBase(string typeName)
            : base(typeName)
        {
        }
    }
}
