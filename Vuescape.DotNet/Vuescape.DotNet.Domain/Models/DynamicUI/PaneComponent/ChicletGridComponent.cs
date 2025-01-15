// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ChicletGridComponent.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    using OBeautifulCode.Type;

    /// <summary>
    /// Represents a chiclet grid component with an associated payload.
    /// </summary>
    public partial class ChicletGridComponent : PaneComponent<ChicletGridComponentPayload>, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChicletGridComponent"/> class.
        /// </summary>
        /// <param name="payload">The payload containing details of the chiclet grid component.</param>
        public ChicletGridComponent(ChicletGridComponentPayload payload)
            : base(payload)
        {
        }

        /// <summary>
        /// Gets the type of the pane component.
        /// </summary>
        public override string Type => "chicletGrid";
    }
}
