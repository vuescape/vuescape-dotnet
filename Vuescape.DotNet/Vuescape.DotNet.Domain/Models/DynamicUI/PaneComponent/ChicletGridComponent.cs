// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ChicletGridComponent.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Type;

    /// <summary>
    /// Represents a chiclet grid component with an associated payload.
    /// </summary>
    public class ChicletGridComponent : PaneComponentBase, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChicletGridComponent"/> class.
        /// </summary>
        /// <param name="payload">The payload containing details of the chiclet grid component.</param>
        public ChicletGridComponent(ChicletGridComponentPayload payload)
        {
            new { payload }.AsArg().Must().NotBeNull();

            this.Payload = payload;
        }

        /// <summary>
        /// Gets the type of the pane component.
        /// </summary>
        public override string Type => "chicletGrid";

        /// <summary>
        /// Gets the payload containing details of the chiclet grid component.
        /// </summary>
        public ChicletGridComponentPayload Payload { get; }
    }
}
