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
    internal static partial class ColumnFormatOptionsExtensions
    {
        /// <summary>
        /// Determine if a column is visible from the <see cref="ColumnFormatOptions"/>.
        /// </summary>
        /// <param name="obcColumn">The column.</param>
        /// <returns>Whether a column is visible.</returns>
        internal static bool IsVisible(
            this Column obcColumn)
        {
            var options = obcColumn?.Format?.Options;
            if (options == null)
            {
                return true;
            }

            var result = (options & ColumnFormatOptions.Hide) == 0;
            return result;
        }

        /// <summary>
        /// Determine if a column is sortable from the <see cref="ColumnFormatOptions"/>.
        /// </summary>
        /// <param name="obcColumn">The column.</param>
        /// <returns>Whether a column is sortable.</returns>
        internal static bool IsSortable(
            this Column obcColumn)
        {
            var options = obcColumn?.Format?.Options;
            if (options == null)
            {
                return false;
            }

            var result = (options & ColumnFormatOptions.Sortable) != 0;
            return result;
        }

        /// <summary>
        /// Determine if a column is frozen from the <see cref="ColumnFormatOptions"/>.
        /// </summary>
        /// <param name="obcColumn">The column.</param>
        /// <returns>Whether a column is sortable.</returns>
        internal static bool IsFrozen(
            this Column obcColumn)
        {
            var options = obcColumn?.Format?.Options;
            if (options == null)
            {
                return false;
            }

            var result = (options & ColumnFormatOptions.Freeze) != 0;
            return result;
        }
    }
}
