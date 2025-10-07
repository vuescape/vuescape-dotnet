// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ActionButtonComponentPayload.cs" company="Vuescape">
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
    public partial class ActionButtonComponentPayload : IHaveId<string>, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActionButtonComponentPayload"/> class.
        /// </summary>
        /// <param name="id">The unique identifier for this component.</param>
        /// <param name="label">The label to display on the button.</param>
        /// <param name="menuItems">The menu items associated with the button.</param>
        /// <param name="isDisabled">A value indicating whether the component is disabled. Default is false.</param>
        /// <param name="icons">OPTIONAL icons to display on the button. Default is null.</param>
        /// <param name="iconPosition">OPTIONAL icon position. Default is <see cref="IconPosition.Right"/>.</param>
        public ActionButtonComponentPayload(
            string id,
            string label,
            IReadOnlyList<ActionMenuItem> menuItems,
            bool isDisabled = false,
            IReadOnlyList<string> icons = null,
            IconPosition iconPosition = IconPosition.Right)
        {
            new { id }.AsArg().Must().NotBeNullNorWhiteSpace();
            new { label }.AsArg().Must().NotBeNullNorWhiteSpace();
            new { menuItems }.AsArg().Must().NotBeNullNorEmptyEnumerable().And().NotContainAnyNullElementsWhenNotNull();

            this.Id = id;
            this.Label = label;
            this.MenuItems = menuItems;
            this.IsDisabled = isDisabled;
            this.Icons = icons;
            this.IconPosition = iconPosition;
        }

        /// <inheritdoc />
        public string Id { get; private set; }

        /// <summary>
        /// Gets the label to display on the button.
        /// </summary>
        public string Label { get; private set; }

        /// <summary>
        /// Gets the menu items associated with the button.
        /// </summary>
        public IReadOnlyList<ActionMenuItem> MenuItems { get; private set; }

        /// <summary>
        /// Gets a value indicating whether the component is disabled.
        /// </summary>
        public bool IsDisabled { get; private set; }

        /// <summary>
        /// Gets the optional icons to display on the button.
        /// </summary>
        public IReadOnlyList<string> Icons { get; private set; }

        /// <summary>
        /// Gets the optional icon position.
        /// </summary>
        public IconPosition IconPosition { get; private set; }
    }
}
