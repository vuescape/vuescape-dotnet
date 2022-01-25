// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LinkName.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    /// <summary>
    /// Link name.
    /// </summary>
    public static class LinkName
    {
        /// <summary>
        /// Link for getting self information. Typically details.
        /// </summary>
        public static readonly string Self = "__vs-self";

        /// <summary>
        /// Link for downloading CSV.
        /// </summary>
        public static readonly string DownloadCsv = "__vs-downloadCsv";

        /// <summary>
        /// Link for downloading PDF.
        /// </summary>
        public static readonly string DownloadPdf = "__vs-downloadPdf";
    }
}
