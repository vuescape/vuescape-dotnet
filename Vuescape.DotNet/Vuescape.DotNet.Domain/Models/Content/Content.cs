// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Content.cs" company="Vuescape">
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
    /// A wrapper for a string payload that may be encoded.  e.g. Base64.
    /// </summary>
    public partial class Content : IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Content"/> class.
        /// </summary>
        /// <param name="payload">The content payload.</param>
        /// <param name="resourceKind">The kind of content.</param>
        /// <param name="payloadEncodingKind">OPTIONAL. The encoding of the payload.  Defaults to None.</param>
        /// <param name="metadata">OPTIONAL. Metadata associated with the content.</param>
        public Content(
            string payload,
            ResourceKind resourceKind,
            PayloadEncodingKind payloadEncodingKind = PayloadEncodingKind.None,
            IReadOnlyDictionary<string, UiObject> metadata = null)
        {
            resourceKind.AsArg(nameof(resourceKind)).Must().NotBeEqualTo(ResourceKind.Unknown);

            this.Payload = payload;
            this.ResourceKind = resourceKind;
            this.PayloadEncodingKind = payloadEncodingKind;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Creates a new instance of the <see cref="Content"/> class with name metadata populated.
        /// </summary>
        /// <param name="name">The name of the content.</param>
        /// <param name="payload">The content payload.</param>
        /// <param name="resourceKind">The kind of content.</param>
        /// <param name="payloadEncodingKind">The encoding of the payload.</param>
        /// <returns>Content with name metadata populated.</returns>
        public static Content CreateWithName(
            string name,
            string payload,
            ResourceKind resourceKind,
            PayloadEncodingKind payloadEncodingKind = PayloadEncodingKind.None)
        {
            name.MustForArg(nameof(name)).NotBeNullNorWhiteSpace();

            IReadOnlyDictionary<string, UiObject> metadata = new Dictionary<string, UiObject> { { "name", new UiObject(name) } };
            var result = new Content(payload, resourceKind, payloadEncodingKind, metadata);

            return result;
        }

        /// <summary>
        /// Gets the content payload.
        /// </summary>
        public string Payload { get; private set; }

        /// <summary>
        /// Gets the ResourceKind.
        /// </summary>
        public ResourceKind ResourceKind { get; private set; }

        /// <summary>
        /// Gets the ResourceKind.
        /// </summary>
        public PayloadEncodingKind PayloadEncodingKind { get; private set; }

        /// <summary>
        /// Gets the metadata.
        /// </summary>
        public IReadOnlyDictionary<string, UiObject> Metadata { get; private set; }
    }
}
