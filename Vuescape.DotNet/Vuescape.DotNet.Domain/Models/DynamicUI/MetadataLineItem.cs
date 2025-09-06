// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MetadataLineItem.cs" company="Vuescape">
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
    /// Represents a metadata line item that is displayed as: icon text.
    /// </summary>
    public partial class MetadataLineItem : IHaveId<string>, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataLineItem"/> class.
        /// </summary>
        /// <param name="id">The unique identifier for the line item.</param>
        /// <param name="icons">Indicates whether the chiclet is visible.</param>
        /// <param name="iconClass">The action associated with the chiclet.</param>
        /// <param name="text">The optional list of icon identifiers for the chiclet.</param>
        /// <param name="textClass">The optional CSS class to style the chiclet.</param>
        public MetadataLineItem(
            string id,
            IReadOnlyList<string> icons,
            string iconClass,
            string text,
            string textClass)
        {
            new { id }.AsArg().Must().NotBeNullNorWhiteSpace();

            this.Id = id;
            this.Icons = icons;
            this.IconClass = iconClass;
            this.Text = text;
            this.TextClass = textClass;
        }

        /// <summary>
        /// Gets the unique identifier for the chiclet.
        /// </summary>
        public string Id { get; private set; }

        /// <summary>
        /// Gets the optional list of icon identifiers.
        /// </summary>
        public IReadOnlyList<string> Icons { get; private set; }

        /// <summary>
        /// Gets the icon tailwind class.
        /// </summary>
        public string IconClass { get; private set; }

        /// <summary>
        /// Gets the text.
        /// </summary>
        public string Text { get; private set; }

        /// <summary>
        /// Gets the text tailwind class.
        /// </summary>
        public string TextClass { get; private set; }
    }
}
