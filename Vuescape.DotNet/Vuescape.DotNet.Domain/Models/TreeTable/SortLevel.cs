// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SortLevel.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    /// <summary>
    /// The sort direction of the TreeTable.
    /// </summary>
    public enum SortLevel
    {
        /// <summary>
        /// None
        /// </summary>
        None = 0,

        /// <summary>
        /// Sort on the top level parent rows.
        /// </summary>
        Parent,

        /// <summary>
        /// Sort on the child rows.
        /// </summary>
        Children,
    }
}
