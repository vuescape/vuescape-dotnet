// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HoverContentKind.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    /// <summary>
    /// The kind of content.
    /// </summary>
    public enum HoverContentKind
    {
        /// <summary>
        /// None
        /// </summary>
        None = 0,

        /// <summary>
        /// Plaintext content.
        /// </summary>
        Plaintext,

        /// <summary>
        /// Html content.
        /// </summary>
        Html,
    }
}
