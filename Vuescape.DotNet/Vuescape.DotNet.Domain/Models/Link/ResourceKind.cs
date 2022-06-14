// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ResourceKind.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    /// <summary>
    /// Specifies the kind of resource that is fetched from a server.
    /// </summary>
    public enum ResourceKind
    {
        /// <summary>
        /// Unknown (default).
        /// </summary>
        Unknown,

        /// <summary>
        /// A <see cref="Report"/>.
        /// </summary>
        Report,

        /// <summary>
        /// JSON document.
        /// </summary>
        Json,

        /// <summary>
        /// An image.
        /// </summary>
        Image,

        /// <summary>
        /// Audio.
        /// </summary>
        Audio,

        /// <summary>
        /// Video.
        /// </summary>
        Video,

        /// <summary>
        /// HTML.
        /// </summary>
        Html,

        /// <summary>
        /// A Microsoft Excel file.
        /// </summary>
        Excel,

        /// <summary>
        /// A CSV file.
        /// </summary>
        Csv,

        /// <summary>
        /// A PDF file.
        /// </summary>
        Pdf,

        /// <summary>
        /// A Zip file.
        /// </summary>
        Zip,

        /// <summary>
        /// Text.
        /// </summary>
        Text,
    }
}