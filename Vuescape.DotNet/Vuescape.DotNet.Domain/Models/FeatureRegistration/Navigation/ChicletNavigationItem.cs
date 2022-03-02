// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ChicletNavigationItem.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace

namespace Vuescape.DotNet.Domain
{
    using OBeautifulCode.Type;

    /// <summary>
    /// A chiclet navigation item.
    /// </summary>
    public partial class ChicletNavigationItem : NavigationItemBase, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChicletNavigationItem"/> class.
        /// </summary>
        /// <param name="title">The title of the link.</param>
        /// <param name="navigationUrl">OPTIONAL. The url to navigate to in the application. e.g. /report/report-name.
        /// Path separated Titles to allow construction of a menu. This item will be placed under this node in a menu.  e.g. Top Level Menu/Reports/ would place this menu item under Menu=>Reports.</param>
        /// <param name="iconName">OPTIONAL. icon name corresponding to representation in a specific icon library. e.g. "fas fa-acorn" for font awesome.</param>
        public ChicletNavigationItem(string title, string navigationUrl = null, string iconName = null)
            : base(NavigationItemKind.Menu, title, navigationUrl, iconName)
        {
        }
    }
}
