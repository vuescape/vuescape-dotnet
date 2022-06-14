// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PayloadEncodingKind.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    /// <summary>
    /// The encoding of the payload.
    /// </summary>
    public enum PayloadEncodingKind
    {
        /// <summary>
        /// No encoding. Suitable for text.
        /// </summary>
        None = 0,

        /// <summary>
        /// Base64 encoding.
        /// </summary>
        Base64,
    }
}
