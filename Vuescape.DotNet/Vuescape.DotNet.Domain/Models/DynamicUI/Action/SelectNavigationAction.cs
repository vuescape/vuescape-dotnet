// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SelectNavigationAction.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    using OBeautifulCode.Assertion.Recipes;

    /// <summary>
    /// Represents a navigation action with a payload containing navigation details.
    /// </summary>
    public partial class SelectNavigationAction : ActionBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SelectNavigationAction"/> class.
        /// </summary>
        /// <param name="payload">The payload containing navigation details.</param>
        public SelectNavigationAction(NavigationActionPayload payload)
            : base(DiscriminatedTypeNames.SelectNavigationAction)
        {
            new { payload }.AsArg().Must().NotBeNull();

            this.Payload = payload;
        }

        /// <summary>
        /// Gets the payload containing navigation details.
        /// </summary>
        public NavigationActionPayload Payload { get; private set; }
    }
}
