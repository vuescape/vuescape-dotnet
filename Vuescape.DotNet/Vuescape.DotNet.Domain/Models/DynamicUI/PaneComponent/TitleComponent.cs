// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TitleComponent.cs" company="Vuescape">
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
    public partial class TitleComponent : PaneComponent<TitleComponentPayload>, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TitleComponent"/> class.
        /// </summary>
        /// <param name="payload">The payload containing details of the title component.</param>
        public TitleComponent(TitleComponentPayload payload)
            : base(payload)
        {
        }

        /// <summary>
        /// Gets the type of the pane component.
        /// </summary>
        public override string Type => "title";
    }
}
