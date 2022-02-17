// <copyright file="HorizontalAlignmentExtensions.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    using System;

    /// <summary>
    /// Extension methods on <see cref="OBeautifulCode.DataStructure.HorizontalAlignment "/>.
    /// </summary>
    public static partial class HorizontalAlignmentExtensions
    {
        /// <summary>
        /// Convert a <see cref="System.Drawing.Color"/> to a hexadecimal representation.
        /// </summary>
        /// <param name="horizontalAlignment">The horizontal alignment to convert.</param>
        /// <returns>Hexadecimal string.</returns>
        public static HorizontalAlignment? ToVuescapeHorizontalAlignment(this OBeautifulCode.DataStructure.HorizontalAlignment? horizontalAlignment)
        {
            if (horizontalAlignment == null)
            {
                return null;
            }

            switch (horizontalAlignment)
            {
                case OBeautifulCode.DataStructure.HorizontalAlignment.Unknown:
                    return HorizontalAlignment.Unknown;
                case OBeautifulCode.DataStructure.HorizontalAlignment.Left:
                    return HorizontalAlignment.Left;
                case OBeautifulCode.DataStructure.HorizontalAlignment.Center:
                    return HorizontalAlignment.Center;
                case OBeautifulCode.DataStructure.HorizontalAlignment.Right:
                    return HorizontalAlignment.Right;
                default:
                    throw new ArgumentOutOfRangeException(nameof(horizontalAlignment), horizontalAlignment, null);
            }
        }
    }
}
