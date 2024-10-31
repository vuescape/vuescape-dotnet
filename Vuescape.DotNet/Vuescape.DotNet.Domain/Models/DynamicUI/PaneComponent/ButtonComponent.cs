// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ButtonComponent.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Type;

    /// <summary>
    /// Represents a button component with an associated payload.
    /// </summary>
    public class ButtonComponent : PaneComponentBase, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ButtonComponent"/> class.
        /// </summary>
        /// <param name="payload">The payload containing details of the button component.</param>
        public ButtonComponent(ButtonComponentPayload payload)
        {
            new { payload }.AsArg().Must().NotBeNull();

            this.Payload = payload;
        }

        /// <summary>
        /// Gets the type of the pane component.
        /// </summary>
        public override string Type => "button";

        /// <summary>
        /// Gets the payload containing details of the button component.
        /// </summary>
        public ButtonComponentPayload Payload { get; }
    }
}
