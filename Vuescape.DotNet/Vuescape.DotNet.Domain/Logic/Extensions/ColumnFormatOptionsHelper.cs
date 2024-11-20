// <copyright file="ColumnFormatOptionsHelper.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    using System.Diagnostics.CodeAnalysis;

    using OBeautifulCode.DataStructure;

    /// <summary>
    /// Helper methods for <see cref="OBeautifulCode.DataStructure.ColumnFormatOptions"/>.
    /// </summary>
    public static class ColumnFormatOptionsHelper
    {
        /// <summary>
        /// Determines whether a <see cref="Column"/> is visible.
        /// </summary>
        /// <param name="obcColumn">The column.</param>
        /// <param name="obcSpecificColumnFormat">The format for this column.</param>
        /// <param name="obcColumnFormat">The format for all columns.</param>
        /// <param name="obcToVuescapeConversionContext">The conversion context.</param>
        /// <returns>True if visible otherwise false.</returns>
        [SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "obcToVuescapeConversionContext", Justification = "Future-proof usage.")]
        internal static bool IsVisible(
            Column obcColumn,
            ColumnFormat obcSpecificColumnFormat,
            ColumnFormat obcColumnFormat,
            ObcToVuescapeConversionContext obcToVuescapeConversionContext)
        {
            var result = (obcColumn?.Format?.Options.IsVisible()).GetValueOrDefault(true) &&
                         (obcSpecificColumnFormat?.Options.IsVisible()).GetValueOrDefault(true) &&
                         (obcColumnFormat?.Options.IsVisible()).GetValueOrDefault(true);

            return result;
        }

        /// <summary>
        /// Determines whether a <see cref="Column"/> is sortable.
        /// </summary>
        /// <param name="obcColumn">The column.</param>
        /// <param name="obcSpecificColumnFormat">The format for this column.</param>
        /// <param name="obcColumnFormat">The format for all columns.</param>
        /// <param name="obcToVuescapeConversionContext">The conversion context.</param>
        /// <returns>True if sortable otherwise false.</returns>
        [SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "obcToVuescapeConversionContext", Justification = "Future-proof usage.")]
        internal static bool IsSortable(
            Column obcColumn,
            ColumnFormat obcSpecificColumnFormat,
            ColumnFormat obcColumnFormat,
            ObcToVuescapeConversionContext obcToVuescapeConversionContext)
        {
            var result = (obcColumn?.Format?.Options.IsSortable()).GetValueOrDefault(false) ||
                         (obcSpecificColumnFormat?.Options.IsSortable()).GetValueOrDefault(false) ||
                         (obcColumnFormat?.Options.IsSortable()).GetValueOrDefault(false);

            return result;
        }
    }
}
