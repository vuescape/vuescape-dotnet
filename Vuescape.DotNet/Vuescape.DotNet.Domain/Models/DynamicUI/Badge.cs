// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Badge.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Type;

    /// <summary>
    /// Represents a UI Badge.
    /// </summary>
    public partial class Badge : IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Badge"/> class.
        /// </summary>
        /// <param name="text">The badge text.</param>
        /// <param name="severity">The badge severity.</param>
        public Badge(
            string text,
            BadgeSeverity? severity = null)
        {
            this.Text = text;
            this.Severity = severity;
            new { text }.AsArg().Must().NotBeNullNorWhiteSpace();
        }

        /// <summary>
        /// Gets the badge text.
        /// </summary>
        public string Text { get; private set; }

        /// <summary>
        /// Gets the badge severity.
        /// </summary>
        public BadgeSeverity? Severity { get; private set; }
    }
}
