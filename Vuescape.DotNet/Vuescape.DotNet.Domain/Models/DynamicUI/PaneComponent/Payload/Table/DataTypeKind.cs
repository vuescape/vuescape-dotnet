// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DataTypeKind.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    /// <summary>
    /// Represents the type of data for a table column.
    /// </summary>
    public enum DataTypeKind
    {
        /// <summary>
        /// Date type.
        /// </summary>
        Date,

        /// <summary>
        /// Numeric type.
        /// </summary>
        Numeric,

        /// <summary>
        /// Boolean type.
        /// </summary>
        Boolean,
    }
}
