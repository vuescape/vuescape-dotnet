// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MenuNavigationItem.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    using OBeautifulCode.Assertion.Recipes;
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
        /// <param name="menuTitlePath">OPTIONAL.  Path separated menu Titles to allow construction of a menu. This <see cref="MenuNavigationItem"/> will be placed under this node in a menu.
        /// Path separator is the pipe: "|".  If null or empty string then the item will be placed as a top level menu item.
        /// Note that there is currently a UI limitation to one nested level.
        /// </param>
        /// <param name="horizontalAlignment">The horizontal alignment of the menu item in the menu.</param>
        public MenuNavigationItem(NavigationLink link, string menuTitlePath = null, HorizontalAlignment horizontalAlignment = HorizontalAlignment.Right)
            : base(link, NavigationItemKind.Menu)
        {
            this.MenuTitlePath = menuTitlePath;
            this.HorizontalAlignment = horizontalAlignment;
        }

        /// <summary>
        /// Gets the menu title path.
        /// </summary>
        public string MenuTitlePath { get; private set; }

        /// <summary>
        /// Gets the horizontal alignment.
        /// </summary>
        public HorizontalAlignment HorizontalAlignment { get; private set; }
    }
}
