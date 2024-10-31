// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NavigationActionPayload.cs" company="Vuescape">
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
    public class NavigationActionPayload : IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NavigationActionPayload"/> class.
        /// </summary>
        /// <param name="url">The URL to navigate to.</param>
        /// <param name="target">The optional target for the navigation, such as "_blank".</param>
        /// <param name="replace">Optional flag indicating whether to replace the current page in history.</param>
        [SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", MessageId = "0#", Justification = "Prefer using string URL for serialization.")]
        public NavigationActionPayload(
            string url,
            string target = null,
            bool? replace = null)
        {
            new { url }.AsArg().Must().NotBeNullNorWhiteSpace();

            this.Url = url;
            this.Target = target;
            this.Replace = replace;
        }

        /// <summary>
        /// Gets the URL to navigate to.
        /// </summary>
        [SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Justification = "Prefer using string URL for serialization.")]
        public string Url { get; }

        /// <summary>
        /// Gets the optional target for the navigation, such as "_blank".
        /// </summary>
        public string Target { get; }

        /// <summary>
        /// Gets a value indicating whether to replace the current page in history.
        /// </summary>
        public bool? Replace { get; }
    }
}
