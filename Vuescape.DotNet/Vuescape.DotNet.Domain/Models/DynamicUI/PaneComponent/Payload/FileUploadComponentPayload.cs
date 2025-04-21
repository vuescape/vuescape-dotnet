// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FileUploadComponentPayload.cs" company="Vuescape">
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
    public partial class FileUploadComponentPayload : IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileUploadComponentPayload"/> class.
        /// </summary>
        /// <param name="id">The unique identifier for this component.</param>
        /// <param name="title">OPTIONAL The title to display.</param>
        /// <param name="uploadInstructionText">OPTIONAL upload instructional text to display inside file upload area.</param>
        /// /// <param name="maxFileSizeInBytes">OPTIONAL maximum file size in bytes -- used for validation.</param>
        /// <param name="acceptFileTypeExtensions">OPTIONAL list containing the acceptable file type extensions. e.g. ".csv".</param>
        public FileUploadComponentPayload(
            string id,
            string title,
            string uploadInstructionText = null,
            long? maxFileSizeInBytes = null,
            IReadOnlyList<string> acceptFileTypeExtensions = null)
        {
            new { id }.AsArg().Must().NotBeNullNorWhiteSpace();

            this.Id = id;
            this.Title = title;
            this.UploadInstructionText = uploadInstructionText;
            this.MaxFileSizeInBytes = maxFileSizeInBytes;
            this.AcceptFileTypeExtensions = acceptFileTypeExtensions;
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
        /// Gets the upload instruction text.
        /// </summary>
        public string UploadInstructionText { get; private set; }

        /// <summary>
        /// Gets the maximum file size in bytes.
        /// </summary>
        public long? MaxFileSizeInBytes { get; private set; }

        /// <summary>
        /// Gets the accept file type extensions.
        /// </summary>
        public IReadOnlyList<string> AcceptFileTypeExtensions { get; private set; }
    }
}
