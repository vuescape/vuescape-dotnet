﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Hover.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

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
        /// <param name="html">The HTML to render.</param>
        /// <param name="text">The text to render.</param>
        /// <param name="title">The title of the hover over.</param>
        public Hover(
            string html,
            string text,
            string title)
        {
            this.Html = html;
            this.Text = text;
            this.Title = title;
        }

        /// <summary>
        /// Gets the HTML for the hover over.
        /// </summary>
        public string Html { get; private set; }

        /// <summary>
        /// Gets the text to display in the hover over.
        /// </summary>
        public string Text { get; private set; }

        /// <summary>
        /// Gets the title of the hover over.
        /// </summary>
        public string Title { get; private set; }
    }
}
