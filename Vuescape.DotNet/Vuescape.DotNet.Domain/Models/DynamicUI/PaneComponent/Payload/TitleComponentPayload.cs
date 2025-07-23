// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TitleComponentPayload.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Type;

    /// <summary>
    /// Represents the payload for a title component, containing the text to display.
    /// </summary>
    public partial class TitleComponentPayload : IHaveId<string>, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TitleComponentPayload"/> class.
        /// </summary>
        /// <param name="id">The unique identifier for this component.</param>
        /// <param name="text">The text to display in the title component.</param>
        public TitleComponentPayload(
            string id,
            string text)
        {
            new { id }.AsArg().Must().NotBeNullNorWhiteSpace();
            new { text }.AsArg().Must().NotBeNullNorWhiteSpace();

            this.Id = id;
            this.Text = text;
        }

        /// <inheritdoc />
        public string Id { get; private set; }

        /// <summary>
        /// Gets the text to display in the title component.
        /// </summary>
        public string Text { get; private set; }
    }
}
