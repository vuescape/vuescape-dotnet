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
        /// Use ordinal sort comparison.
        /// </summary>
        Ordinal,

        /// <summary>
        /// Use string sort comparison.
        /// </summary>
        String,

        /// <summary>
        /// Use string sort comparison.
        /// </summary>
        StringCaseInsensitive,
    }
}
