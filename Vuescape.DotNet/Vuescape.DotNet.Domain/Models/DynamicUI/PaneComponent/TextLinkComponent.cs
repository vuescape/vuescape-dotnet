// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TextLinkComponent.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    using OBeautifulCode.Type;

    /// <summary>
    /// Represents text that is a link.
    /// </summary>
    public partial class TextLinkComponent : PaneComponent<TextLinkPayload>, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TextLinkComponent"/> class.
        /// </summary>
        /// <param name="payload">The payload.</param>
        public TextLinkComponent(TextLinkPayload payload)
            : base(payload, DiscriminatedTypeNames.TextLinkComponent)
        {
        }
    }
}
