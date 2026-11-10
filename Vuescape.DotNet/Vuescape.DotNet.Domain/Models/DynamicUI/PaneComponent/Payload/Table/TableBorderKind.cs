// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TableBorderKind.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    /// <summary>
    /// Specifies the lines that separate a table's cells.
    /// </summary>
    public enum TableBorderKind
    {
        /// <summary>
        /// Lines around every cell.
        /// </summary>
        Grid,

        /// <summary>
        /// Lines between the rows only.
        /// </summary>
        Rows,

        /// <summary>
        /// No lines, e.g. for a list that is read down rather than across, such as a navigation's links.
        /// </summary>
        None,
    }
}
