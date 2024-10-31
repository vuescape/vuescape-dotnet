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
    public abstract class PaneComponentBase : IModelViaCodeGen
    {
        /// <summary>
        /// Gets the type of the pane component.
        /// </summary>
        [SuppressMessage("Microsoft.Naming", "CA1721:PropertyNamesShouldNotMatchGetMethods", Justification = "Needs to align with Type property in TypeScript")]
        public abstract string Type { get; }
    }
}
