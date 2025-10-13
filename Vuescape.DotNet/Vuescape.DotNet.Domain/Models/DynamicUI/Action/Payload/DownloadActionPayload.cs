// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DownloadActionPayload.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    using System.Diagnostics.CodeAnalysis;
    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Type;

    /// <summary>
    /// Represents the payload for a navigation action, including URL, target, and replace flag.
    /// </summary>
    public partial class DownloadActionPayload : IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DownloadActionPayload"/> class.
        /// </summary>
        /// <param name="url">The URL to navigate to.</param>
        /// <param name="shouldResolveDownloadFile">Should the api be invoked to resolve the actual download URL.</param>
        [SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", MessageId = "0#", Justification = "Prefer using string URL for serialization.")]
        public DownloadActionPayload(
            string url,
            bool shouldResolveDownloadFile)
        {
            new { url }.AsArg().Must().NotBeNullNorWhiteSpace();

            this.Url = url;
            this.ShouldResolveDownloadFile = shouldResolveDownloadFile;
        }

        /// <summary>
        /// Gets the URL to navigate to.
        /// </summary>
        [SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Justification = "Prefer using string URL for serialization.")]
        public string Url { get; private set; }

        /// <summary>
        /// Gets a value indicating whether the URL should be used to resolve the actual download URL.
        /// </summary>
        public bool ShouldResolveDownloadFile { get; private set; }
    }
}
