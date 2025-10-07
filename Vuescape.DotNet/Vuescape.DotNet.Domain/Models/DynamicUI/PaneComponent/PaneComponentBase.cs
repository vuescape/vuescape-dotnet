// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PaneComponentBase.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    using System.Diagnostics.CodeAnalysis;
    using OBeautifulCode.Type;

    /// <summary>
    /// Represents a component within a pane, which can be a button, chiclet grid, table, or title component.
    /// </summary>
    public abstract partial class PaneComponentBase : DiscriminatedTypeBase, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaneComponentBase"/> class.
        /// </summary>
        /// <param name="typeName">The globally unique discriminator for this pane component.</param>
        protected PaneComponentBase(string typeName)
            : base(typeName)
        {
        }
    }
}
