// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SelectComponent.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    using OBeautifulCode.Assertion.Recipes;

    /// <summary>
    /// Represents a select component with an associated payload.
    /// </summary>
    public partial class SelectComponent : PaneComponentBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SelectComponent"/> class.
        /// </summary>
        /// <param name="payload">The payload containing details of the button component.</param>
        public SelectComponent(SelectComponentPayload payload)
        {
            new { payload }.AsArg().Must().NotBeNull();

            this.Payload = payload;
        }

        /// <summary>
        /// Gets the type of the pane component.
        /// </summary>
        public override string Type => "select";

        /// <summary>
        /// Gets the payload containing details of the select component.
        /// </summary>
        public SelectComponentPayload Payload { get; private set; }
    }
}
