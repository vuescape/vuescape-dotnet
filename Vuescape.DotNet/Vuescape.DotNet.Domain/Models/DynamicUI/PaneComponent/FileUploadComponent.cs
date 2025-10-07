// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FileUploadComponent.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    using OBeautifulCode.Type;

    /// <summary>
    /// Represents a File Upload component with an associated payload.
    /// </summary>
    public partial class FileUploadComponent : PaneComponent<FileUploadComponentPayload>, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileUploadComponent"/> class.
        /// </summary>
        /// <param name="payload">The payload containing details of the title component.</param>
        public FileUploadComponent(FileUploadComponentPayload payload)
            : base(payload, DiscriminatedTypeNames.FileUploadComponent)
        {
        }
    }
}
