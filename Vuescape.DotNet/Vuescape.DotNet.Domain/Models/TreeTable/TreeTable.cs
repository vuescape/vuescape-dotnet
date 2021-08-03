// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TreeTable.cs" company="Vuescape">
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
    /// The sort direction of the TreeTable.
    /// </summary>
    public partial class TreeTable : IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TreeTable"/> class.
        /// </summary>
        /// <param name="id">The unique ID of the TreeTable.</param>
        /// <param name="columnDefinitions">The column definitions of the TreeTable.</param>
        /// <param name="content">The content of the TreeTable.</param>
        /// <param name="behaviors">The client behaviors to apply to the TreeTable.</param>
        public TreeTable(
            string id,
            IReadOnlyList<ColumnDefinition> columnDefinitions,
            TreeTableContent content,
            IReadOnlyCollection<ClientBehaviorBase> behaviors = null)
        {
            new { content }.AsArg().Must().NotBeNull();

            this.Id = id;
            this.ColumnDefinitions = columnDefinitions;
            this.Content = content;
            this.Behaviors = behaviors;
        }

        /// <summary>
        /// Gets the id.
        /// </summary>
        public string Id { get; private set; }

        /// <summary>
        /// Gets the column definitions.
        /// </summary>
        public IReadOnlyList<ColumnDefinition> ColumnDefinitions { get; private set; }

        /// <summary>
        /// Gets the content.
        /// </summary>
        public TreeTableContent Content { get; private set; }

        /// <summary>
        /// Gets the behaviors.
        /// </summary>
        public IReadOnlyCollection<ClientBehaviorBase> Behaviors { get; private set; }
    }
}
