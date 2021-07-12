// <copyright file="ColumnFormatOptionsExtensions.Internal.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    using System.Drawing;

    using OBeautifulCode.DataStructure;

    /// <summary>
    /// Extension methods on <see cref="OBeautifulCode.DataStructure.ColumnFormatOptions"/>.
    /// </summary>
    internal static partial class ColumnFormatOptionsExtensions
    {
        /// <summary>
        /// Determine if a column is visible from the <see cref="ColumnFormatOptions"/>.
        /// </summary>
        /// <param name="obcColumnFormatOptions">The column format options.</param>
        /// <returns>Whether a column is visible.</returns>
        internal static bool IsVisible(
            this ColumnFormatOptions? obcColumnFormatOptions)
        {
            var result = (obcColumnFormatOptions & ColumnFormatOptions.Hide) != 0;
            return result;
        }

        /// <summary>
        /// Determine if a column is sortable from the <see cref="ColumnFormatOptions"/>.
        /// </summary>
        /// <param name="obcColumnFormatOptions">The column format options.</param>
        /// <returns>Whether a column is sortable.</returns>
        internal static bool IsSortable(
            this ColumnFormatOptions? obcColumnFormatOptions)
        {
            var result = (obcColumnFormatOptions & ColumnFormatOptions.Sortable) != 0;
            return result;
        }

        /// <summary>
        /// Determine if a column is frozen from the <see cref="ColumnFormatOptions"/>.
        /// </summary>
        /// <param name="obcColumnFormatOptions">The column format options.</param>
        /// <returns>Whether a column is sortable.</returns>
        internal static bool IsFrozen(
            this ColumnFormatOptions? obcColumnFormatOptions)
        {
            var result = (obcColumnFormatOptions & ColumnFormatOptions.Freeze) != 0;
            return result;
        }

        /// <summary>
        /// Get the column sort direction from the <see cref="ColumnFormatOptions"/>.
        /// </summary>
        /// <param name="obcColumnFormatOptions">The column format options.</param>
        /// <returns>The <see cref="SortDirection"/> of the column.</returns>
        internal static SortDirection GetSortDirection(
            this ColumnFormatOptions? obcColumnFormatOptions)
        {
            var result = SortDirection.None;

            if ((obcColumnFormatOptions & ColumnFormatOptions.SortedAscending) != 0)
            {
                result = SortDirection.Ascending;
            }
            else if ((obcColumnFormatOptions & ColumnFormatOptions.SortedDescending) != 0)
            {
                result = SortDirection.Descending;
            }

            return result;
        }
    }
}
