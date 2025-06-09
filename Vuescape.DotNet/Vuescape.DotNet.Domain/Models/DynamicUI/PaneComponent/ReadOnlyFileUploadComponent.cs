// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ReadOnlyFileUploadComponent.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    using OBeautifulCode.Type;

    /// <summary>
    /// Represents a ReadOnly version of a File Upload component.
    /// </summary>
    public partial class ReadOnlyFileUploadComponent : PaneComponent<ReadOnlyFileUploadComponentPayload>, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReadOnlyFileUploadComponent"/> class.
        /// </summary>
        /// <param name="payload">The payload containing details of the title component.</param>
        public ReadOnlyFileUploadComponent(ReadOnlyFileUploadComponentPayload payload)
            : base(payload)
        {
        }

        /// <summary>
        /// Gets the type of the pane component.
        /// </summary>
        public override string Type => "readOnlyFileUpload";
    }
}
