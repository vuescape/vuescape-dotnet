// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MenuNavigationItem.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace

using OBeautifulCode.Assertion.Recipes;

namespace Vuescape.DotNet.Domain
{
    using OBeautifulCode.Type;

    /// <summary>
    /// Represents a navigation item that will be placed within the application menu hierarchy.
    /// </summary>
    public partial class MenuNavigationItem : NavigationItemBase, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MenuNavigationItem"/> class.
        /// </summary>
        /// <param name="link">The <see cref="NavigationLink"/> to navigate to.</param>
        /// <param name="menuTitlePath">Path separated menu Titles to allow construction of a menu. This <see cref="MenuNavigationItem"/> will be placed under this node in a menu.
        /// Path separator is the forward slash: "/".
        /// e.g. Top Level /Reports/Sales would place this menu item under Sales submenu of the top level Reports menu Reports->Sales.
        /// To create a top level item use "/" as the <paramref name="menuTitlePath"/>.
        /// </param>
        public MenuNavigationItem(NavigationLink link, string menuTitlePath = null)
            : base(link, NavigationItemKind.Menu)
        {
            menuTitlePath.MustForArg(nameof(menuTitlePath)).NotBeNullNorWhiteSpace();

            this.MenuTitlePath = menuTitlePath;
        }

        /// <summary>
        /// Gets the menu title path.
        /// </summary>
        public string MenuTitlePath { get; private set; }
    }
}
