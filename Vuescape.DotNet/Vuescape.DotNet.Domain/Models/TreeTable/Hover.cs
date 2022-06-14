// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Hover.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Type;

    /// <summary>
    /// Instructions on how to construct a hover over.
    /// </summary>
    public partial class Hover : IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Hover"/> class.
        /// </summary>
        /// <param name="title">The title of the hover over.</param>
        /// <param name="content">The content to render.</param>
        /// <param name="contentKind">The kind of the content.</param>
        /// <param name="component">The name of the component to use to render with.</param>
        public Hover(
            string title,
            string content,
            HoverContentKind contentKind,
            string component = null)
        {
            new { contentKind }.AsArg().Must().NotBeEqualTo(HoverContentKind.None);

            this.Title = title;
            this.Content = content;
            this.ContentKind = contentKind;
            this.Component = component;
        }

        /// <summary>
        /// Gets the content to display in the hover over.
        /// </summary>
        public string Content { get; private set; }

        /// <summary>
        /// Gets the title of the hover over.
        /// </summary>
        public string Title { get; private set; }

        /// <summary>
        /// Gets the kind of the content.
        /// </summary>
        public HoverContentKind ContentKind { get; private set; }

        /// <summary>
        /// Gets the component used to render the hover over.
        /// </summary>
        public string Component { get; private set; }
    }
}
