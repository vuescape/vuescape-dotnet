// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TreeTableRow.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

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
        /// <param name="name">The name.</param>
        /// <param name="cssClasses">The CSS classes.</param>
        /// <param name="depth">The depth of the row in the tree.</param>
        /// <param name="dependencies">The dependencies.</param>
        /// <param name="isExpandable">Whether the row is expandable.</param>
        /// <param name="isExpanded">Whether the row is expanded.</param>
        /// <param name="isFocused">Whether the row is focused. Typically in the UI the row will be highlighted.</param>
        /// <param name="isSelected">Whether the row is selected.</param>
        /// <param name="isVisible">Whether the row is visible.</param>
        /// <param name="cells">The items. This is typically the column values.</param>
        /// <param name="renderer">The name of the renderer.</param>
        /// <param name="value">The value.</param>
        /// <param name="children">The child rows.</param>
        /// <param name="links">The links for this row.</param>
        public TreeTableRow(
            string id,
            string name,
            string cssClasses,
            int depth,
            bool isExpandable,
            bool isExpanded,
            bool? isFocused,
            bool isSelected,
            bool isVisible,
            IReadOnlyList<TreeTableCell> cells,
            string renderer,
            IObject value,
            IReadOnlyList<TreeTableRow> children,
            IReadOnlyCollection<TreeTableRowDependency> dependencies = null,
            IReadOnlyDictionary<string, IReadOnlyCollection<Link>> links = null)
        {
            new { id }.AsArg().Must().NotBeNullNorWhiteSpace();
            new { name }.AsArg().Must().NotBeNullNorWhiteSpace();
            new { cells }.AsArg().Must().NotBeNullNorEmptyEnumerable();

            this.Id = id;
            this.Name = name;
            this.CssClasses = cssClasses;
            this.Depth = depth;
            this.Dependencies = dependencies;
            this.IsExpandable = isExpandable;
            this.IsExpanded = isExpanded;
            this.IsFocused = isFocused;
            this.IsSelected = isSelected;
            this.IsVisible = isVisible;
            this.Cells = cells;
            this.Renderer = renderer;
            this.Value = value;
            this.Children = children;
            this.Links = links;
        }

        /// <summary>
        /// Gets the Id.
        /// </summary>
        public string Id { get; private set; }

        /// <summary>
        /// Gets the name for this row.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Gets the CssClasses. // TODO: Collection or string.
        /// </summary>
        public string CssClasses { get; private set; }

        /// <summary>
        /// Gets the indent depth of this row.
        /// </summary>
        public int Depth { get; private set; }

        /// <summary>
        /// Gets a collection of dependencies.
        /// </summary>
        public IReadOnlyCollection<TreeTableRowDependency> Dependencies { get; private set; }

        /// <summary>
        /// Gets a value indicating whether this row is expandable.
        /// </summary>
        public bool IsExpandable { get; private set; }

        /// <summary>
        /// Gets a value indicating whether this row is expanded.
        /// </summary>
        public bool IsExpanded { get; private set; }

        /// <summary>
        /// Gets a value indicating whether this row is focused.
        /// </summary>
        public bool? IsFocused { get; private set; }

        /// <summary>
        /// Gets a value indicating whether this row is selected.
        /// </summary>
        public bool IsSelected { get; private set; }

        /// <summary>
        /// Gets a value indicating whether this row is visible.
        /// </summary>
        public bool IsVisible { get; private set; }

        /// <summary>
        /// Gets a collection of items.
        /// </summary>
        public IReadOnlyCollection<TreeTableCell> Cells { get; private set; }

        /// <summary>
        /// Gets the Renderer.
        /// </summary>
        public string Renderer { get; private set; }

        /// <summary>
        /// Gets the value.
        /// </summary>
        public IObject Value { get; private set; }

        /// <summary>
        /// Gets the children tree table rows.
        /// </summary>
        public IReadOnlyCollection<TreeTableRow> Children { get; private set; }

        /// <summary>
        /// Gets the Links.
        /// </summary>
        public IReadOnlyDictionary<string, IReadOnlyCollection<Link>> Links { get; private set; }

        /*
        public IReadOnlyDictionary<string, object> Onclick { get; private set; }
        */
    }
}
