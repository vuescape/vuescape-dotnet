// <copyright file="ColorExtensions.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    using static System.FormattableString;

    /// <summary>
    /// Extension methods on <see cref="System.Drawing.Color"/>.
    /// </summary>
    public static partial class ColorExtensions
    {
        /// <summary>
        /// Convert a <see cref="System.Drawing.Color"/> to a hexadecimal representation.
        /// </summary>
        /// <param name="color">The color to convert.</param>
        /// <returns>Hexadecimal string.</returns>
        public static string ToHex(this System.Drawing.Color color)
        {
            var result = Invariant($"#{color.R:X2}{color.G:X2}{color.B:X2}");
            return result;
        }
    }
}
