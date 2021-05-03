// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TargetKind.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace

namespace Vuescape.DotNet.Domain
{
    /// <summary>
    /// The kind of target.
    /// </summary>
    public enum LinkTargetKind
    {
        /// <summary>
        /// None.
        /// </summary>
        None = 0,

        /// <summary>
        /// Left Pane.
        /// </summary>
        PaneLeft,

        /// <summary>
        /// Center Pane.
        /// </summary>
        PaneCenter,

        /// <summary>
        /// Right Pane.
        /// </summary>
        PaneRight,

        /// <summary>
        /// Modal.
        /// </summary>
        Modal,

        /// <summary>
        /// Navigate to Url.
        /// </summary>
        Url,

        /// <summary>
        /// Navigate to router Route.
        /// </summary>
        Route,

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
