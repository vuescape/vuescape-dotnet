// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NavigationItemKind.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace

namespace Vuescape.DotNet.Domain
{
    using System;

    /// <summary>
    /// The kind of <see cref="NavigationItem"/>.
    /// </summary>
    public enum NavigationItemKind
    {
        /// <summary>
        /// None.
        /// </summary>
        None = 0,

        /// <summary>
        /// Menu.
        /// </summary>
        Menu,

        /// <summary>
        /// Chiclet.
        /// </summary>
        Chiclet,
    }
}
