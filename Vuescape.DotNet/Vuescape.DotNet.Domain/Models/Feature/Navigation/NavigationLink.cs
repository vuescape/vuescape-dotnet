// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NavigationLink.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace

namespace Vuescape.DotNet.Domain
{
    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Type;

    /// <summary>
    /// A navigation link in the context of a web application.
    /// </summary>
    public partial class NavigationLink : IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NavigationLink"/> class.
        /// </summary>
        /// <param name="title">The title of the link.</param>
        /// <param name="url">The url to navigate to in the application. e.g. /report/report-name.</param>
        /// <param name="iconName">OPTIONAL. icon name corresponding to representation in a specific icon library. e.g. "fas fa-acorn" for font awesome.</param>
        public NavigationLink(string title, string url, string iconName = null)
        {
            title.MustForArg(nameof(title)).NotBeNullNorWhiteSpace();
            url.MustForArg(nameof(url)).NotBeNullNorWhiteSpace();

            this.Title = title;
            this.Url = url;
            this.IconName = iconName;
        }

        /// <summary>
        /// Gets the title.
        /// </summary>
        public string Title { get; private set; }

        /// <summary>
        /// Gets the URL to navigate to in the application.
        /// </summary>
        /// <example>"/report/report-name".</example>
        public string Url { get; private set; }

        /// <summary>
        /// Gets the icon name corresponding to the representation in a specific icon library.
        /// </summary>
        /// <example>"fas fa-acorn" for font awesome.</example>
        public string IconName { get; private set; }
    }
}
