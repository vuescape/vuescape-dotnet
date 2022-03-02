// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ResourceTarget.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace

namespace Vuescape.DotNet.Domain
{
    /// <summary>
    /// The target kind of a resource.
    /// </summary>
    public enum ResourceTarget
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
        /// Download text file.
        /// </summary>
        DownloadTextFile,

        /// <summary>
        /// Download file with Base64 encoding.
        /// </summary>
        DownloadBase64EncodedFile,
    }
}
