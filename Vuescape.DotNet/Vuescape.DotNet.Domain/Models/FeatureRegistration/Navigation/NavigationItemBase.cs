// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NavigationItemBase.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace

using OBeautifulCode.Assertion.Recipes;

namespace Vuescape.DotNet.Domain
{
    using OBeautifulCode.Type;

    /// <summary>
    /// Base class for navigation items.
    /// </summary>
    public abstract partial class NavigationItemBase : IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NavigationItemBase"/> class.
        /// </summary>
        /// <param name="navigationItemKind">The kind of navigation item.</param>
        /// <param name="title">The title of the link.</param>
        /// <param name="navigationUrl">OPTIONAL. The url to navigate to in the application. e.g. /report/report-name.
        /// Path separated Titles to allow construction of a menu. This item will be placed under this node in a menu.  e.g. Top Level Menu/Reports/ would place this menu item under Menu=>Reports.</param>
        /// <param name="iconName">OPTIONAL. icon name corresponding to representation in a specific icon library. e.g. "fas fa-acorn" for font awesome.</param>
        public NavigationItemBase(NavigationItemKind navigationItemKind, string title, string navigationUrl = null, string iconName = null)
        {
            title.AsArg().Must().NotBeNullNorWhiteSpace();

            this.NavigationItemKind = navigationItemKind;
            this.Title = title;
            this.NavigationUrl = navigationUrl;
            this.IconName = iconName;
        }

        /// <summary>
        /// Gets the resource target kind.
        /// </summary>
        public NavigationItemKind NavigationItemKind { get; }

        /// <summary>
        /// Gets the title.
        /// </summary>
        public string Title { get; private set; }

        /// <summary>
        /// Gets the navigation URL.
        /// </summary>
        public string NavigationUrl { get; }

        /// <summary>
        /// Gets the icon string.
        /// </summary>
        public string IconName { get; }
    }
}
