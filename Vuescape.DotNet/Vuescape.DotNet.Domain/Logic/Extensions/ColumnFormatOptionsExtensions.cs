// <copyright file="ColumnFormatOptionsExtensions.Internal.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    using OBeautifulCode.DataStructure;

    /// <summary>
    /// Extension methods on <see cref="OBeautifulCode.DataStructure.ColumnFormatOptions"/>.
    /// </summary>
    public static partial class ColumnFormatOptionsExtensions
    {
        /// <summary>
        /// Determine if a column is visible from the <see cref="ColumnFormatOptions"/>.
        /// </summary>
        /// <param name="obcColumnFormatOptions">The column.</param>
        /// <returns>Whether a column is visible.</returns>
        internal static bool IsVisible(
            this ColumnFormatOptions? obcColumnFormatOptions)
        {
            if (obcColumnFormatOptions == null)
            {
                return true;
            }

            var result = (obcColumnFormatOptions & ColumnFormatOptions.Hide) == 0;
            return result;
        }

        /// <summary>
        /// Determine if a column is sortable from the <see cref="ColumnFormatOptions"/>.
        /// </summary>
        /// <param name="obcColumnFormatOptions">The column.</param>
        /// <returns>Whether a column is sortable.</returns>
        internal static bool IsSortable(
            this ColumnFormatOptions? obcColumnFormatOptions)
        {
            if (obcColumnFormatOptions == null)
            {
                return false;
            }

            var result = (obcColumnFormatOptions & ColumnFormatOptions.Sortable) != 0;
            return result;
        }

        /// <summary>
        /// Determine if a column is sortable from the <see cref="ColumnFormatOptions"/>.
        /// </summary>
        /// <param name="obcColumnFormatOptions">The column.</param>
        /// <returns>Whether a column is frozen.</returns>
        internal static bool IsFrozen(
            this ColumnFormatOptions? obcColumnFormatOptions)
        {
            if (obcColumnFormatOptions == null)
            {
                return false;
            }

            var result = (obcColumnFormatOptions & ColumnFormatOptions.Freeze) != 0;
            return result;
        }
    }
}
