// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TableComponent.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Type;

    /// <summary>
    /// Represents a table component with an associated payload.
    /// </summary>
    public class TableComponent : PaneComponentBase, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TableComponent"/> class.
        /// </summary>
        /// <param name="payload">The payload containing details of the table component.</param>
        public TableComponent(TableComponentPayload payload)
        {
            new { payload }.AsArg().Must().NotBeNull();

            this.Payload = payload;
        }

        /// <summary>
        /// Gets the type of the pane component.
        /// </summary>
        public override string Type => "table";

        /// <summary>
        /// Gets the payload containing details of the table component.
        /// </summary>
        public TableComponentPayload Payload { get; }
    }
}
