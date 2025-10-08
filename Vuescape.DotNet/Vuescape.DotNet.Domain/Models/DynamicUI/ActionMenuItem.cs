// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ActionMenuItem.cs" company="Vuescape">
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
    /// Represents an item within a pane, including its alignment, width, and contained components.
    /// </summary>
    public partial class ActionMenuItem : IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActionMenuItem"/> class.
        /// </summary>
        /// <param name="label">Text displayed for the menu item.</param>
        /// <param name="action">OPTIONAL action to execute when selected. Default is null.</param>
        /// <param name="icons">OPTIONAL collection of icon identifiers to display. Default is null.</param>
        /// <param name="iconPosition">OPTIONAL value indicating where icons are rendered relative to the label. Default is <see cref="IconPosition.Right"/>.</param>
        /// <param name="isDisabled">OPTIONAL value indicating whether the menu item is disabled. Default is false.</param>
        /// <param name="tooltip">OPTIONAL tooltip shown on hover/focus. Default is null.</param>
        public ActionMenuItem(
            string label,
            ActionBase action = null,
            IReadOnlyList<string> icons = null,
            IconPosition iconPosition = IconPosition.Left,
            bool isDisabled = false,
            string tooltip = null)
        {
            new { label }.AsArg().Must().NotBeNullNorWhiteSpace();

            this.Label = label;
            this.Action = action;
            this.Icons = icons;
            this.IconPosition = iconPosition;
            this.IsDisabled = isDisabled;
            this.Tooltip = tooltip;
        }

        /// <summary>
        /// Gets the text displayed for the menu item.
        /// </summary>
        public string Label { get; private set; }

        /// <summary>
        /// Gets the navigation action executed when the item is selected.
        /// </summary>
        public ActionBase Action { get; private set; }

        /// <summary>
        /// Gets the icons to display with the label, if any.
        /// </summary>
        public IReadOnlyList<string> Icons { get; private set; }

        /// <summary>
        /// Gets where icons are positioned relative to the label.
        /// </summary>
        public IconPosition IconPosition { get; private set; }

        /// <summary>
        /// Gets a value indicating whether the menu item is disabled.
        /// </summary>
        public bool IsDisabled { get; private set; }

        /// <summary>
        /// Gets the tooltip text shown on hover/focus, if any.
        /// </summary>
        public string Tooltip { get; private set; }
    }
}
