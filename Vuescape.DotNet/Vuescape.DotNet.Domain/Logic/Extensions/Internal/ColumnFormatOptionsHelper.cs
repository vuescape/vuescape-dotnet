// <copyright file="ColumnFormatOptionsHelper.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    using OBeautifulCode.DataStructure;

    /// <summary>
    /// Helper methods for <see cref="OBeautifulCode.DataStructure.ColumnFormatOptions"/>.
    /// </summary>
    internal static partial class ColumnFormatOptionsHelper
    {
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

        internal static bool IsFrozen(
            Column obcColumn,
            ColumnFormat obcSpecificColumnFormat,
            ColumnFormat obcColumnFormat,
            ObcToVuescapeConversionContext obcToVuescapeConversionContext)
        {
            var result = (obcColumn?.Format?.Options.IsFrozen()).GetValueOrDefault(false) ||
                         (obcSpecificColumnFormat?.Options.IsFrozen()).GetValueOrDefault(false) ||
                         (obcColumnFormat?.Options.IsFrozen()).GetValueOrDefault(false);

            return result;
        }

    }
}
