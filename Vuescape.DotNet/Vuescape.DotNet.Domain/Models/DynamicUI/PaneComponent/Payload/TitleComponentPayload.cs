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
    public class TitleComponentPayload : IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TitleComponentPayload"/> class.
        /// </summary>
        /// <param name="text">The text to display in the title component.</param>
        public TitleComponentPayload(string text)
        {
            new { text }.AsArg().Must().NotBeNull();

            this.Text = text;
        }

        /// <summary>
        /// Gets the text to display in the title component.
        /// </summary>
        public string Text { get; }
    }
}
