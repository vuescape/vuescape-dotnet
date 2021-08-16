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
        /// <param name="fontSize">The font size.</param>
        public CellFormat(
            string fontHexColor,
            string fontSize)
        {
            this.FontHexColor = fontHexColor;
            this.FontSize = fontSize;
        }

        /// <summary>
        /// Gets the font color in hexadecimal.
        /// </summary>
        public string FontHexColor { get; private set; }

        /// <summary>
        /// Gets the font size in pixels.
        /// </summary>
        public string FontSize { get; private set; }
    }
}
