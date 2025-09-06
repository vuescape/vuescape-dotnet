// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ReadOnlyFileUploadComponentPayload.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    using System.Collections.Generic;
    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Type;

    /// <summary>
    /// Represents the file upload component payload.
    /// </summary>
    public partial class ReadOnlyFileUploadComponentPayload : IHaveId<string>, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReadOnlyFileUploadComponentPayload"/> class.
        /// </summary>
        /// <param name="id">The unique identifier for this component.</param>
        /// <param name="fileName">The file name to display.</param>
        /// <param name="fileSizeInBytes">The file size in bytes.</param>
        /// <param name="downloadNavigationAction">OPTIONAL A navigation action to perform in order to download the file.</param>
        /// <param name="metadataLineItems">OPTIONAL list of <see cref="MetadataLineItem"/>.</param>
        public ReadOnlyFileUploadComponentPayload(
            string id,
            string fileName,
            long fileSizeInBytes,
            NavigationAction downloadNavigationAction,
            IReadOnlyList<MetadataLineItem> metadataLineItems)
        {
            new { id }.AsArg().Must().NotBeNullNorWhiteSpace();
            new { fileSizeInBytes }.AsArg().Must().NotBeLessThan(0L);

            this.Id = id;
            this.FileName = fileName;
            this.FileSizeInBytes = fileSizeInBytes;
            this.DownloadNavigationAction = downloadNavigationAction;
            this.MetadataLineItems = metadataLineItems;
        }

        /// <summary>
        /// Gets the ID.
        /// </summary>
        public string Id { get; private set; }

        /// <summary>
        /// Gets the file name.
        /// </summary>
        public string FileName { get; private set; }

        /// <summary>
        /// Gets the file size in bytes.
        /// </summary>
        public long FileSizeInBytes { get; private set; }

        /// <summary>
        /// Gets the download navigation action.
        /// </summary>
        public NavigationAction DownloadNavigationAction { get; private set; }

        /// <summary>
        /// Gets the metadata line items.
        /// </summary>
        public IReadOnlyList<MetadataLineItem> MetadataLineItems { get; private set; }
    }
}
