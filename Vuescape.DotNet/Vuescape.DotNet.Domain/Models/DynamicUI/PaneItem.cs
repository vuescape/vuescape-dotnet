// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PaneItem.cs" company="Vuescape">
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
    public class PaneItem : IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaneItem"/> class.
        /// </summary>
        /// <param name="components">The components to display within this pane item.</param>
        /// <param name="width">The flexbox width of the item (e.g., "30%", "flex-grow-1"). OPTIONAL.</param>
        /// <param name="horizontalAlignment">The horizontal alignment of the content within the item.</param>
        /// <param name="verticalAlignment">The vertical alignment of the content within the item.</param>
        public PaneItem(
            IReadOnlyList<PaneComponentBase> components,
            string width = null,
            HorizontalAlignment horizontalAlignment = HorizontalAlignment.Left,
            VerticalAlignment verticalAlignment = VerticalAlignment.Top)
        {
            new { components }.AsArg().Must().NotBeNull();

            this.Width = width;
            this.HorizontalAlignment = horizontalAlignment;
            this.VerticalAlignment = verticalAlignment;
            this.Components = components;
        }

        /// <summary>
        /// Gets the flexbox width of the item (e.g., "30%", "flex-grow-1").
        /// </summary>
        public string Width { get; }

        /// <summary>
        /// Gets the horizontal alignment of the content within the item.
        /// </summary>
        public HorizontalAlignment HorizontalAlignment { get; }

        /// <summary>
        /// Gets the vertical alignment of the content within the item.
        /// </summary>
        public VerticalAlignment VerticalAlignment { get; }

        /// <summary>
        /// Gets the components to display within this pane item.
        /// </summary>
        public IReadOnlyList<PaneComponentBase> Components { get; }
    }
}
