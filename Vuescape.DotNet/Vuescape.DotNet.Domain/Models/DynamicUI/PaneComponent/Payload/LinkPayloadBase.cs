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
        /// <param name="navigationAction">The navigation action.</param>
        protected LinkPayloadBase(NavigationAction navigationAction)
        {
            new { navigationAction }.AsArg().Must().NotBeNull();

            this.NavigationAction = navigationAction;
        }

        /// <summary>
        /// Gets the navigation action.
        /// </summary>
        public NavigationAction NavigationAction { get; private set; }
    }
}
