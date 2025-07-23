// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TextLinkPayload.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    using System.Collections.Generic;
    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Type;

    /// <summary>
    /// Represents the base payload for a component that is a form of link.
    /// </summary>
    public partial class TextLinkPayload : LinkPayloadBase, IHaveId<string>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TextLinkPayload"/> class.
        /// </summary>
        /// <param name="id">The unique identifier for this component.</param>
        /// <param name="text">The text to display.</param>
        /// <param name="navigationAction">The navigation action.</param>
        /// <param name="cssStyles">OPTIONAL CSS Styles to apply.</param>
        /// <param name="cssClass">OPTIONAL CSS class or space delimited classes to apply.</param>
        public TextLinkPayload(
            string id,
            string text,
            NavigationAction navigationAction,
            IReadOnlyDictionary<string, string> cssStyles = null,
            string cssClass = null)
            : base(navigationAction)
        {
            new { id }.AsArg().Must().NotBeNullNorWhiteSpace();
            new { text }.AsArg().Must().NotBeNullNorWhiteSpace();
            new { cssStyles }.AsArg().Must().NotContainAnyKeyValuePairsWithNullValueWhenNotNull();

            this.Id = id;
            this.Text = text;
            this.CssStyles = cssStyles;
            this.CssClass = cssClass;
        }

        /// <inheritdoc />
        public string Id { get; private set; }

        /// <summary>
        /// Gets the text.
        /// </summary>
        public string Text { get; private set; }

        /// <summary>
        /// Gets the CSS styles.
        /// </summary>
        public IReadOnlyDictionary<string, string> CssStyles { get; private set; }

        /// <summary>
        /// Gets the CSS class (or classes space delimited).
        /// </summary>
        public string CssClass { get; private set; }
    }
}
