// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RenderTextAs.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Indicates how a <see cref="TextComponent"/> should render its text.
    /// </summary>
    [SuppressMessage("Microsoft.Naming", "CA1717:OnlyFlagsEnumsShouldHavePluralNames", Justification = "This is not plural.")]
    public enum RenderTextAs
    {
        /// <summary>
        /// Render text as a Header.
        /// </summary>
        Heading,

        /// <summary>
        /// Render text as a Subheading.
        /// </summary>
        Subheading,

        /// <summary>
        /// Render text as a Paragraph.
        /// </summary>
        Paragraph,

        /// <summary>
        /// Render text as a HTML.
        /// </summary>
        Html,
    }
}
