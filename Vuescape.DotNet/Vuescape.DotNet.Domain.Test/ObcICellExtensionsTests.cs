// <copyright file="ObcICellExtensionsTests.cs" company="Vuescape">
//    Copyright (c) Vuescape 2026. All rights reserved.
// </copyright>

namespace Vuescape.DotNet.Domain.Test
{
    using OBeautifulCode.DataStructure;

    using Xunit;

    public static class ObcICellExtensionsTests
    {
        [Fact]
        public static void GetCellFormat___Should_return_null___When_no_format_gives_anything()
        {
            // Arrange
            var systemUnderTest = new NullCell();

            // Act
            var actual = systemUnderTest.GetCellFormat(null, null, null, null, null, null, null);

            // Assert
            Assert.Null(actual);
        }

        [Fact]
        public static void GetCellFormat___Should_return_the_font_options___When_only_the_font_options_are_given()
        {
            // Arrange
            var systemUnderTest = new NullCell(format: ToCellFormat(FontFormatOptions.Bold | FontFormatOptions.Italics | FontFormatOptions.Underline));

            // Act
            var actual = systemUnderTest.GetCellFormat(null, null, null, null, null, null, null);

            // Assert
            Assert.True(actual.IsBold);
            Assert.True(actual.IsItalic);
            Assert.True(actual.IsUnderlined);
        }

        [Fact]
        public static void GetCellFormat___Should_return_the_most_specific_formats_font_options___When_several_formats_give_them()
        {
            // Arrange
            var systemUnderTest = new NullCell(format: ToCellFormat(FontFormatOptions.Italics));
            var rowFormat = new RowFormat(cellsFormat: ToCellFormat(FontFormatOptions.Bold));

            // Act
            var actual = systemUnderTest.GetCellFormat(rowFormat, null, null, null, null, null, null);

            // Assert
            Assert.False(actual.IsBold);
            Assert.True(actual.IsItalic);
            Assert.False(actual.IsUnderlined);
        }

        [Fact]
        public static void GetCellFormat___Should_return_the_tables_font_options___When_only_the_table_gives_them()
        {
            // Arrange
            var systemUnderTest = new NullCell();
            var tableFormat = new TableFormat(cellsFormat: ToCellFormat(FontFormatOptions.Bold));

            // Act
            var actual = systemUnderTest.GetCellFormat(null, null, null, null, null, tableFormat, null);

            // Assert
            Assert.True(actual.IsBold);
            Assert.False(actual.IsItalic);
            Assert.False(actual.IsUnderlined);
        }

        [Fact]
        public static void GetFontFormatOptionsCssClasses___Should_return_the_original_tree_tables_classes___When_the_cell_is_bold()
        {
            // Arrange
            var systemUnderTest = new NullCell(format: ToCellFormat(FontFormatOptions.Bold));

            // Act
            var actual = systemUnderTest.GetFontFormatOptionsCssClasses(null, null, null, null, null, null, "tree-table-cell__td", null);

            // Assert
            Assert.Contains("font-weight__bold", actual.Split(' '));
            Assert.DoesNotContain("font-style__italic", actual.Split(' '));
        }

        private static OBeautifulCode.DataStructure.CellFormat ToCellFormat(
            FontFormatOptions options)
        {
            var result = new OBeautifulCode.DataStructure.CellFormat(fontFormat: new FontFormat(options: options));
            return result;
        }
    }
}