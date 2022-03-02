// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MenuNavigationItem.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace

namespace Vuescape.DotNet.Domain
{
    using OBeautifulCode.Type;

    /// <summary>
    /// A navigation item.
    /// </summary>
    public partial class MenuNavigationItem : NavigationItemBase, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MenuNavigationItem"/> class.
        /// </summary>
        /// <param name="title">The title of the link.</param>
        /// <param name="menuTitlePath">OPTIONAL. If omitted will create a top level menu item.
        /// Path separated Titles to allow construction of a menu. This item will be placed under this node in a menu.  e.g. Top Level Menu/Reports/ would place this menu item under Menu=>Reports.</param>
        /// <param name="navigationUrl">OPTIONAL. The url to navigate to in the application. e.g. /report/report-name.</param>
        /// <param name="iconName">OPTIONAL. icon name corresponding to representation in a specific icon library. e.g. "fas fa-acorn" for font awesome.</param>
        public MenuNavigationItem(string title, string menuTitlePath = null, string navigationUrl = null, string iconName = null)
        : base(NavigationItemKind.Menu, title, navigationUrl, iconName)
        {
            this.MenuTitlePath = menuTitlePath;
        }

        /// <summary>
        /// Gets the parent title path.
        /// </summary>
        public string MenuTitlePath { get; }
    }
}
