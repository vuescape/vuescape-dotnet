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
    public partial class ReadOnlyFileUploadComponentPayload : IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReadOnlyFileUploadComponentPayload"/> class.
        /// </summary>
        /// <param name="id">The unique identifier for this component.</param>
        /// <param name="title">The title to display.</param>
        /// <param name="fileName">The file name to display.</param>
        /// <param name="fileSizeInBytes">The file size in bytes.</param>
        public ReadOnlyFileUploadComponentPayload(
            string id,
            string title,
            string fileName,
            long fileSizeInBytes)
        {
            new { id }.AsArg().Must().NotBeNullNorWhiteSpace();
            new { fileName }.AsArg().Must().NotBeNullNorWhiteSpace();
            new { fileSizeInBytes }.AsArg().Must().NotBeLessThan(0L);

            this.Id = id;
            this.Title = title;
            this.FileName = fileName;
            this.FileSizeInBytes = fileSizeInBytes;
        }

        /// <summary>
        /// Gets the ID.
        /// </summary>
        public string Id { get; private set; }

        /// <summary>
        /// Gets the title.
        /// </summary>
        public string Title { get; private set; }

        /// <summary>
        /// Gets the file name.
        /// </summary>
        public string FileName { get; private set; }

        /// <summary>
        /// Gets the file size in bytes.
        /// </summary>
        public long FileSizeInBytes { get; private set; }
    }
}
