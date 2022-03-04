// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NavigationItemKind.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    /// <summary>
    /// The kind of <see cref="NavigationItemBase"/>. This is used to identify the kind of the <see cref="NavigationItemBase"/> instance
    /// and to decided how to render.
    /// </summary>
    public enum NavigationItemKind
    {
        /// <summary>
        /// None.
        /// </summary>
        None = 0,

        /// <summary>
        /// Menu. Render as part of the main application menu.
        /// </summary>
        Menu,

        /// <summary>
        /// Chiclet. Render as part of the main "Bento Box" grid menu.
        /// </summary>
        Chiclet,
    }
}
