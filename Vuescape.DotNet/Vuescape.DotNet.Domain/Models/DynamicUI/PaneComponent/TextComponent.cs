// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TextComponent.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    using OBeautifulCode.Type;

    /// <summary>
    /// Represents a title component with an associated payload.
    /// </summary>
    public partial class TextComponent : PaneComponent<TextComponentPayload>, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TextComponent"/> class.
        /// </summary>
        /// <param name="payload">The payload containing details of the title component.</param>
        public TextComponent(TextComponentPayload payload)
            : base(payload)
        {
        }

        /// <summary>
        /// Gets the type of the pane component.
        /// </summary>
        public override string Type => "text";
    }
}
