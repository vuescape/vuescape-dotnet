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

        /// <summary>
        /// Modal.
        /// </summary>
        Modal,

        /// <summary>
        /// Navigate to Url or route in the current window/tab.
        /// </summary>
        NavigateCurrentWindow,

        /// <summary>
        /// Navigate to Url or route in a new window/tab.
        /// </summary>
        NavigateNewWindow,

        /// <summary>
        /// Download text file.
        /// </summary>
        DownloadTextFile,

        /// <summary>
        /// Download file with Base64 encoding.
        /// </summary>
        DownloadBase64EncodedFile,
    }
}
