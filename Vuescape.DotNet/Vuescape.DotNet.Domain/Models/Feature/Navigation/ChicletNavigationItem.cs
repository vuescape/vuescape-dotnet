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
        /// <param name="link">The <see cref="NavigationLink"/> to navigate to.</param>
        public ChicletNavigationItem(NavigationLink link)
            : base(link, NavigationItemKind.Chiclet)
        {
        }
    }
}
