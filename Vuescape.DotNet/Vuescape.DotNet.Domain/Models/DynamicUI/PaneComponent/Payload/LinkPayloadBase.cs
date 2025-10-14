// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LinkPayloadBase.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Type;

    /// <summary>
    /// Represents the base payload for a component that is a form of link.
    /// </summary>
    public abstract partial class LinkPayloadBase : IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LinkPayloadBase"/> class.
        /// </summary>
        /// <param name="action">The action.</param>
        protected LinkPayloadBase(ActionBase action)
        {
            new { action }.AsArg().Must().NotBeNull();

            this.Action = action;
        }

        /// <summary>
        /// Gets the action.
        /// </summary>
        public ActionBase Action { get; private set; }
    }
}
