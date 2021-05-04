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
        /// <param name="title">The title of the link.</param>
        /// <param name="linkTarget">The kind of the link target.</param>
        /// <param name="source">The source.</param>
        public Link(string title, LinkTargetKind linkTarget, string source)
        {
            new { title }.AsArg().Must().NotBeNullNorWhiteSpace();
            new { linkTarget }.AsArg().Must().NotBeEqualTo(LinkTargetKind.None);
            new { source }.AsArg().Must().NotBeNullNorWhiteSpace();

            this.Title = title;
            this.LinkTarget = linkTarget;
            this.Source = source;
        }

        /// <summary>
        /// Gets the title.
        /// </summary>
        public string Title { get; private set; }

        /// <summary>
        /// Gets the <see cref="LinkTargetKind"/>.
        /// </summary>
        public LinkTargetKind LinkTarget { get; private set; }

        /// <summary>
        /// Gets the source.
        /// </summary>
        public string Source { get; private set; }
    }
}
