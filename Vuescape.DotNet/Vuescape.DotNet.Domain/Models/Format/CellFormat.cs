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
        /// <param name="isBold">OPTIONAL. A value indicating whether the text is bold. DEFAULT is false.</param>
        /// <param name="isItalic">OPTIONAL. A value indicating whether the text is italic. DEFAULT is false.</param>
        /// <param name="isUnderlined">OPTIONAL. A value indicating whether the text is underlined. DEFAULT is false.</param>
        public CellFormat(
            string fontHexColor,
            string fontSizeInPixels,
            string backgroundHexColor,
            HorizontalAlignment? horizontalAlignment,
            bool isBold = false,
            bool isItalic = false,
            bool isUnderlined = false)
        {
            this.FontHexColor = fontHexColor;
            this.FontSizeInPixels = fontSizeInPixels;
            this.BackgroundHexColor = backgroundHexColor;
            this.HorizontalAlignment = horizontalAlignment;
            this.IsBold = isBold;
            this.IsItalic = isItalic;
            this.IsUnderlined = isUnderlined;
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

        /// <summary>
        /// Gets a value indicating whether the text is bold.
        /// </summary>
        public bool IsBold { get; private set; }

        /// <summary>
        /// Gets a value indicating whether the text is italic.
        /// </summary>
        public bool IsItalic { get; private set; }

        /// <summary>
        /// Gets a value indicating whether the text is underlined.
        /// </summary>
        public bool IsUnderlined { get; private set; }
    }
}
