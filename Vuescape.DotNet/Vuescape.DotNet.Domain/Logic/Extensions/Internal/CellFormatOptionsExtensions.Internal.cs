// <copyright file="CellFormatOptionsExtensions.Internal.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    /// <summary>
    /// Extension methods on <see cref="OBeautifulCode.DataStructure.CellFormatOptions"/>.
    /// </summary>
    internal static partial class CellFormatOptionsExtensions
    {
        /// <summary>
        /// Determine if a cell has wrapped text from the <see cref="OBeautifulCode.DataStructure.CellFormatOptions"/>.
        /// </summary>
        /// <param name="obcCellFormatOptions">The cell format options.</param>
        /// <returns>Whether a column has wrapped.</returns>
        internal static bool IsCellWrapped(
            this OBeautifulCode.DataStructure.CellFormatOptions? obcCellFormatOptions)
        {
            if (obcCellFormatOptions == null)
            {
                return false;
            }

            var result = (obcCellFormatOptions & OBeautifulCode.DataStructure.CellFormatOptions.WrapText) != 0;
            return result;
        }
    }
}
