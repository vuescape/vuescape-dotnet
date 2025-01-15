// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SelectComponent.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    using OBeautifulCode.Type;

    /// <summary>
    /// Represents a select component with an associated payload.
    /// </summary>
    public partial class SelectComponent : PaneComponent<SelectComponentPayload>, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SelectComponent"/> class.
        /// </summary>
        /// <param name="payload">The payload containing details of the button component.</param>
        public SelectComponent(SelectComponentPayload payload)
            : base(payload)
        {
        }

        /// <summary>
        /// Gets the type of the pane component.
        /// </summary>
        public override string Type => "select";
    }
}
