// <copyright file="RowFormatOptionsExtensions.Internal.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    using OBeautifulCode.DataStructure;

    /// <summary>
    /// Extension methods on <see cref="OBeautifulCode.DataStructure.RowFormatOptions"/>.
    /// </summary>
    public static partial class RowFormatOptionsExtensions
    {
        /// <summary>
        /// Determine if Row should align child rows with parent.
        /// </summary>
        /// <param name="obcRowFormatOptions">The RowFormatOptions.</param>
        /// <returns>A boolean indicating whether the row should align child rows with parent.</returns>
        internal static bool ShouldAlignChildRowsWithParent(
            this RowFormatOptions? obcRowFormatOptions)
        {
            var result = (obcRowFormatOptions ?? RowFormatOptions.None & RowFormatOptions.AlignChildRowsWithParent) != 0;
            return result;
        }

        /// <summary>
        /// Determine if Row is visible.
        /// </summary>
        /// <param name="obcRowFormatOptions">The RowFormatOptions.</param>
        /// <returns>A boolean indicating whether the row is visible.</returns>
        internal static bool IsVisible(
            this RowFormatOptions? obcRowFormatOptions)
        {
            var result = (obcRowFormatOptions ?? RowFormatOptions.None & RowFormatOptions.Hide) == 0;
            return result;
        }

        /// <summary>
        /// Determine if Row is not expandable.
        /// </summary>
        /// <param name="obcRowFormatOptions">The RowFormatOptions.</param>
        /// <returns>A boolean indicating whether the row is not expandable.</returns>
        internal static bool IsNotExpandable(
            this RowFormatOptions? obcRowFormatOptions)
        {
            var result = (obcRowFormatOptions ?? RowFormatOptions.None & RowFormatOptions.DisableCollapsing) != 0;
            return result;
        }

        /// <summary>
        /// Determine if Row is frozen.
        /// </summary>
        /// <param name="obcRowFormatOptions">The RowFormatOptions.</param>
        /// <returns>A boolean indicating whether the row is frozen.</returns>
        internal static bool IsFrozen(
            this RowFormatOptions? obcRowFormatOptions)
        {
            var result = (obcRowFormatOptions ?? RowFormatOptions.None & RowFormatOptions.Freeze) != 0;
            return result;
        }
    }
}
