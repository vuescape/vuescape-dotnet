// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PaneKind.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    /// <summary>
    /// In the UI, the kind of pane.
    /// </summary>
    public enum PaneKind
    {
        /// <summary>
        /// None.
        /// </summary>
        None = 0,

        /// <summary>
        /// Left Pane.
        /// </summary>
        LeftPane,

        /// <summary>
        /// Center Pane.
        /// </summary>
        CenterPane,

        /// <summary>
        /// Right Pane.
        /// </summary>
        RightPane,
    }
}