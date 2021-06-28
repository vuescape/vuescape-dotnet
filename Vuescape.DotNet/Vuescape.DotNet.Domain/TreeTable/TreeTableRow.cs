// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TreeTableRow.cs" company="Vuescape">
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
    /// Represents a Tree Table Row.
    /// </summary>
    public partial class TreeTableRow : IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TreeTableRow"/> class.
        /// </summary>
        /// <param name="id">The unique identifier.</param>
        /// <param name="cells">The items. This is typically the column values.</param>
        /// <param name="depth">The depth of the row in the tree.</param>
        /// <param name="cssClasses">The CSS classes.</param>
        /// <param name="cssStyle">The CSS style.</param>
        /// <param name="renderer">The name of the renderer.</param>
        /// <param name="isExpandable">Whether the row is expandable.</param>
        /// <param name="isExpanded">Whether the row is expanded.</param>
        /// <param name="isVisible">Whether the row is visible.</param>
        /// <param name="isSelected">Whether the row is selected.</param>
        /// <param name="isFocused">Whether the row is focused. Typically in the UI the row will be highlighted.</param>
        /// <param name="links">The links for this row.</param>
        /// <param name="children">The child rows.</param>
        public TreeTableRow(
            string id,
            IReadOnlyList<TreeTableCell> cells,
            int depth,
            string cssClasses,
            string cssStyle,
            string renderer,
            bool isExpandable,
            bool isExpanded,
            bool isVisible,
            bool isSelected,
            bool? isFocused,
            IReadOnlyDictionary<string, Link> links,
            IReadOnlyList<TreeTableRow> children)
        {
            new { cells }.AsArg().Must().NotBeNullNorEmptyEnumerable();

            this.Id = id;
            this.Cells = cells;
            this.Depth = depth;
            this.CssClasses = cssClasses;
            this.CssStyle = cssStyle;
            this.Renderer = renderer;
            this.IsExpandable = isExpandable;
            this.IsExpanded = isExpanded;
            this.IsVisible = isVisible;
            this.IsSelected = isSelected;
            this.IsFocused = isFocused;
            this.Links = links;
            this.Children = children;
        }

        /// <summary>
        /// Gets the Id.
        /// </summary>
        public string Id { get; private set; }

        /// <summary>
        /// Gets a collection of items.
        /// </summary>
        public IReadOnlyList<TreeTableCell> Cells { get; private set; }

        /// <summary>
        /// Gets the CssClasses.
        /// </summary>
        public string CssClasses { get; private set; }

        /// <summary>
        /// Gets the CssStyle.
        /// </summary>
        public string CssStyle { get; private set; }

        /// <summary>
        /// Gets the Renderer.
        /// </summary>
        public string Renderer { get; private set; }

        /// <summary>
        /// Gets the indent depth of this row.
        /// </summary>
        public int Depth { get; private set; }

        /// <summary>
        /// Gets a value indicating whether this row is expandable.
        /// </summary>
        public bool IsExpandable { get; private set; }

        /// <summary>
        /// Gets a value indicating whether this row is expanded.
        /// </summary>
        public bool IsExpanded { get; private set; }

        /// <summary>
        /// Gets a value indicating whether this row is visible.
        /// </summary>
        public bool IsVisible { get; private set; }

        /// <summary>
        /// Gets a value indicating whether this row is selected.
        /// </summary>
        public bool IsSelected { get; private set; }

        /// <summary>
        /// Gets a value indicating whether this row is focused.
        /// </summary>
        public bool? IsFocused { get; private set; }

        /// <summary>
        /// Gets the Links.
        /// </summary>
        public IReadOnlyDictionary<string, Link> Links { get; private set; }

        /// <summary>
        /// Gets the children tree table rows.
        /// </summary>
        public IReadOnlyList<TreeTableRow> Children { get; private set; }
    }
}
