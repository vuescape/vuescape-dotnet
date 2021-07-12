// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SortComparisonStrategy.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    /// <summary>
    /// The sort comparison strategy to use.
    /// </summary>
    public enum SortComparisonStrategy
    {
        /// <summary>
        /// None
        /// </summary>
        None = 0,

        /// <summary>
        /// Use the default comparison implementation.
        /// </summary>
        Default,

        /// <summary>
        /// Use a string ordinal sort comparison.
        /// </summary>
        StringOrdinal,

        /// <summary>
        /// Use string sort comparison.
        /// </summary>
        StringCaseInsensitive,
    }
}
