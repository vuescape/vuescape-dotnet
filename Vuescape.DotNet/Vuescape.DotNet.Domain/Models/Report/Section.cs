// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Section.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Vuescape.DotNet.Domain
{
    using System;

    using OBeautifulCode.Type;

    /// <summary>
    /// A section of a <see cref="Report"/>.
    /// </summary>
    public partial class Section : IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Section"/> class.
        /// </summary>
        /// <param name="id">The section's unique identifier.</param>
        /// <param name="treeTable">The tree table.</param>
        /// <param name="title">OPTIONAL title of the section.  DEFAULT is a section with no title.</param>
        public Section(
            string id,
            TreeTable treeTable,
            string title = null)
        {
            this.Id = id;
            this.TreeTable = treeTable ?? throw new ArgumentNullException(nameof(treeTable));
            this.Title = title;
        }

        /// <summary>
        /// Gets the section's unique identifier.
        /// </summary>
        public string Id { get; private set; }

        /// <summary>
        /// Gets the tree table.
        /// </summary>
        public TreeTable TreeTable { get; private set; }

        /// <summary>
        /// Gets the title of the section.
        /// </summary>
        public string Title { get; private set; }
    }
}