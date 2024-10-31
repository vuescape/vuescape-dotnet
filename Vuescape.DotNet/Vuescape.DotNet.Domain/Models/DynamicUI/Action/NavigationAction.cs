// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NavigationAction.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    using OBeautifulCode.Type;

    /// <summary>
    /// Represents a navigation action with a payload containing navigation details.
    /// </summary>
    public class NavigationAction : ActionBase, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NavigationAction"/> class.
        /// </summary>
        /// <param name="payload">The payload containing navigation details.</param>
        public NavigationAction(NavigationActionPayload payload)
        {
            this.Payload = payload;
        }

        /// <inheritdoc />
        public override string Type => "navigate";

        /// <summary>
        /// Gets the payload containing navigation details.
        /// </summary>
        public NavigationActionPayload Payload { get; }
    }
}
