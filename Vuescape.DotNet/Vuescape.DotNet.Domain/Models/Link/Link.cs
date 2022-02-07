// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Link.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Type;

    /// <summary>
    /// Link.
    /// </summary>
    public partial class Link : IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Link"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="linkTarget">The kind of the link target.</param>
        /// <param name="title">The title of the link.</param>
        /// <param name="activatedCssStyles">The CSS Styles to apply when the link is activated.</param>
        /// <param name="resourceKind">The kind of resource.</param>
        public Link(string source, LinkTarget linkTarget, string title = null, CssStyles activatedCssStyles = null, ResourceKind resourceKind = ResourceKind.Report)
        {
            new { linkTarget }.AsArg().Must().NotBeEqualTo(LinkTarget.None);
            new { source }.AsArg().Must().NotBeNullNorWhiteSpace();

            this.Source = source;
            this.LinkTarget = linkTarget;
            this.Title = title;
            this.ActivatedCssStyles = activatedCssStyles;
            this.ResourceKind = resourceKind;
        }

        /// <summary>
        /// Gets the title.
        /// </summary>
        public string Title { get; private set; }

        /// <summary>
        /// Gets the <see cref="LinkTarget"/>.
        /// </summary>
        public LinkTarget LinkTarget { get; private set; }

        /// <summary>
        /// Gets the source.
        /// </summary>
        public string Source { get; private set; }

        /// <summary>
        /// Gets the activated CSS styles.
        /// </summary>
        public CssStyles ActivatedCssStyles { get; private set; }

        /// <summary>
        /// Gets the <see cref="ResourceKind"/>.
        /// </summary>
        public ResourceKind ResourceKind { get; private set; }
    }
}
