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
    public abstract partial class ActionBase : IModelViaCodeGen
    {
        /// <summary>
        /// Gets the type of the action. Used to discriminate actions in JavaScript.
        /// </summary>
        [SuppressMessage("Microsoft.Naming", "CA1721:PropertyNamesShouldNotMatchGetMethods", Justification = "Needs to align with Type property in TypeScript")]
        public abstract string Type { get; }
    }
}
