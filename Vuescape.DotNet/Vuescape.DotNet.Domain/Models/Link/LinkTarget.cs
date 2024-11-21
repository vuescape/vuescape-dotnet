// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LinkTarget.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    /// <summary>
    /// The target of a <see cref="Link"/>.
    /// </summary>
    public enum LinkTarget
    {
        /// <summary>
        /// None.
        /// </summary>
        None = 0,

        /// <summary>
        /// The Current Pane.
        /// </summary>
        CurrentPane = 1,

        /// <summary>
        /// Left Pane.
        /// </summary>
        LeftPane = 2,

        /// <summary>
        /// Center Pane.
        /// </summary>
        CenterPane,

        /// <summary>
        /// Right Pane.
        /// </summary>
        RightPane,

        /// <summary>
        /// Navigate to Url or route in the current window/tab.
        /// </summary>
        CurrentWindow,

        /// <summary>
        /// Navigate to Url or route in a new window/tab.
        /// </summary>
        NewWindow,

        /// <summary>
        /// Download.
        /// </summary>
        Download,

        /// <summary>
        /// Modal.
        /// </summary>
        Modal,
    }
}
