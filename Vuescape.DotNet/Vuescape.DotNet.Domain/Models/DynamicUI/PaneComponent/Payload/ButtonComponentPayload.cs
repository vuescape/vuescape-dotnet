// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ButtonComponentPayload.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    using System.Collections.Generic;
    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Type;

    /// <summary>
    /// Represents the payload for a button component, including label, action, and optional icons.
    /// </summary>
    public class ButtonComponentPayload : IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ButtonComponentPayload"/> class.
        /// </summary>
        /// <param name="label">The label to display on the button.</param>
        /// <param name="action">The action associated with the button.</param>
        /// <param name="icons">Optional icons to display on the button.</param>
        public ButtonComponentPayload(
            string label,
            ActionBase action,
            IReadOnlyList<string> icons = null)
        {
            new { label }.AsArg().Must().NotBeNull();
            new { action }.AsArg().Must().NotBeNull();

            this.Label = label;
            this.Action = action;
            this.Icons = icons;
        }

        /// <summary>
        /// Gets the label to display on the button.
        /// </summary>
        public string Label { get; }

        /// <summary>
        /// Gets the action associated with the button.
        /// </summary>
        public ActionBase Action { get; }

        /// <summary>
        /// Gets the optional icons to display on the button.
        /// </summary>
        public IReadOnlyList<string> Icons { get; }
    }
}
