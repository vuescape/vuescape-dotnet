// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ButtonComponent.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    using OBeautifulCode.Type;

    /// <summary>
    /// Represents a button component with an associated payload.
    /// </summary>
    public partial class ButtonComponent : PaneComponent<ButtonComponentPayload>, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ButtonComponent"/> class.
        /// </summary>
        /// <param name="payload">The payload containing details of the button component.</param>
        public ButtonComponent(ButtonComponentPayload payload)
            : base(payload, DiscriminatedTypeNames.ButtonComponent)
        {
        }
    }
}
