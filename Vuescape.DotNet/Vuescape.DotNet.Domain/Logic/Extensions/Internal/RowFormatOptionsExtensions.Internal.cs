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
    internal static partial class RowFormatOptionsExtensions
    {
        /// <summary>
        /// Determine if Row is visible.
        /// </summary>
        /// <param name="obcRowFormatOptions">The RowFormatOptions.</param>
        /// <returns>A boolean indicating whether the row is visible.</returns>
        internal static bool IsVisible(
            this RowFormatOptions? obcRowFormatOptions)
        {
            var result = (obcRowFormatOptions & RowFormatOptions.Hide) != 0;
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
            var result = (obcRowFormatOptions & RowFormatOptions.DisableCollapsing) != 0;
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
            var result = (obcRowFormatOptions & RowFormatOptions.Freeze) != 0;
            return result;
        }
    }
}
