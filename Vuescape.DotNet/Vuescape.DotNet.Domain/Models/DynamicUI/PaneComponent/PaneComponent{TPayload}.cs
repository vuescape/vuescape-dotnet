// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PaneComponent{TPayload}.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Type;

    /// <summary>
    /// Represents a component within a pane, which can be a button, chiclet grid, table, or title component.
    /// </summary>
    /// <typeparam name="TPayload">The type of the payload property.</typeparam>
    public abstract partial class PaneComponent<TPayload> : PaneComponentBase, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaneComponent{TPayload}"/> class.
        /// </summary>
        /// <param name="payload">The payload containing details of the component.</param>
        /// <param name="typeName">The discrimated type name.</param>
        protected PaneComponent(
            TPayload payload,
            string typeName)
            : base(typeName)
        {
            new { payload }.AsArg().Must().NotBeNull();

            this.Payload = payload;
        }

        /// <summary>
        /// Gets the payload for the component.
        /// </summary>
        public TPayload Payload { get; private set; }
    }
}
