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
    public partial class FileUploadComponentPayload : IHaveId<string>, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileUploadComponentPayload"/> class.
        /// </summary>
        /// <param name="id">The unique identifier for this component.</param>
        /// <param name="isRequired">Indicates if it is required to select a file to upload.</param>
        /// <param name="uploadInstructionText">OPTIONAL upload instructional text to display inside file upload area.</param>
        /// /// <param name="maxFileSizeInBytes">OPTIONAL maximum file size in bytes -- used for validation.</param>
        /// <param name="acceptFileTypeExtensions">OPTIONAL list containing the acceptable file type extensions. e.g. ".csv".</param>
        public FileUploadComponentPayload(
            string id,
            bool isRequired,
            string uploadInstructionText = null,
            long? maxFileSizeInBytes = null,
            IReadOnlyList<string> acceptFileTypeExtensions = null)
        {
            new { id }.AsArg().Must().NotBeNullNorWhiteSpace();

            this.Id = id;
            this.IsRequired = isRequired;
            this.UploadInstructionText = uploadInstructionText;
            this.MaxFileSizeInBytes = maxFileSizeInBytes;
            this.AcceptFileTypeExtensions = acceptFileTypeExtensions;
        }

        /// <summary>
        /// Gets the ID.
        /// </summary>
        public string Id { get; private set; }

        /// <summary>
        /// Gets a value indicating whether it is required to select a file to upload.
        /// </summary>
        public bool IsRequired { get; private set; }

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
