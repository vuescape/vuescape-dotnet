// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ActionButtonComponent.cs" company="Vuescape">
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
    public partial class ActionButtonComponent : PaneComponent<ButtonComponentPayload>, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActionButtonComponent"/> class.
        /// </summary>
        /// <param name="payload">The payload containing details of the button component.</param>
        public ActionButtonComponent(ButtonComponentPayload payload)
            : base(payload, DiscriminatedTypeNames.ActionButtonComponent)
        {
        }
    }
}
