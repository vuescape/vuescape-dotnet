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
    public partial class ButtonComponentPayload : IHaveId<string>, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ButtonComponentPayload"/> class.
        /// </summary>
        /// <param name="id">The unique identifier for this component.</param>
        /// <param name="label">The label to display on the button.</param>
        /// <param name="action">The action associated with the button.</param>
        /// <param name="icons">Optional icons to display on the button.</param>
        public ButtonComponentPayload(
            string id,
            string label,
            ActionBase action,
            IReadOnlyList<string> icons = null)
        {
            new { id }.AsArg().Must().NotBeNullNorWhiteSpace();
            new { label }.AsArg().Must().NotBeNull();
            new { action }.AsArg().Must().NotBeNull();
            new { icons }.AsArg().Must().NotContainAnyNullElements();

            this.Id = id;
            this.Label = label;
            this.Action = action;
            this.Icons = icons;
        }

        /// <inheritdoc />
        public string Id { get; private set; }

        /// <summary>
        /// Gets the label to display on the button.
        /// </summary>
        public string Label { get; private set; }

        /// <summary>
        /// Gets the action associated with the button.
        /// </summary>
        public ActionBase Action { get; private set; }

        /// <summary>
        /// Gets the optional icons to display on the button.
        /// </summary>
        public IReadOnlyList<string> Icons { get; private set; }
    }
}
