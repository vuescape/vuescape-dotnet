// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CellFormat.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    using OBeautifulCode.Type;

    /// <summary>
    /// Cell formatting info.
    /// </summary>
    public partial class CellFormat : IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CellFormat"/> class.
        /// </summary>
        /// <param name="fontHexColor">The font color in hexadecimal.</param>
        /// <param name="fontSizeInPixels">The font size.</param>
        /// <param name="backgroundHexColor">The background color in hexadecimal.</param>
        /// <param name="horizontalAlignment">OPTIONAL. The horizontal alignment.</param>
        public CellFormat(
            string fontHexColor,
            string fontSizeInPixels,
            string backgroundHexColor,
            HorizontalAlignment? horizontalAlignment)
        {
            this.FontHexColor = fontHexColor;
            this.FontSizeInPixels = fontSizeInPixels;
            this.BackgroundHexColor = backgroundHexColor;
            this.HorizontalAlignment = horizontalAlignment;
        }

        /// <summary>
        /// Gets the font color in hexadecimal.
        /// </summary>
        public string FontHexColor { get; private set; }

        /// <summary>
        /// Gets the font size in pixels.
        /// </summary>
        public string FontSizeInPixels { get; private set; }

        /// <summary>
        /// Gets the background color in hexadecimal.
        /// </summary>
        public string BackgroundHexColor { get; private set; }

        /// <summary>
        /// Gets the horizontal alignment.
        /// </summary>
        public HorizontalAlignment? HorizontalAlignment { get; private set; }
    }
}
