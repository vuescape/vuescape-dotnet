// <copyright file="ObcTableFormatExtensionsTests.cs" company="Vuescape">
//    Copyright (c) Vuescape 2026. All rights reserved.
// </copyright>

namespace Vuescape.DotNet.Domain.Test
{
    using System;
    using System.Drawing;
    using System.Linq;
    using OBeautifulCode.DataStructure;
    using Xunit;

    [CLSCompliant(false)]
    public static class ObcTableFormatExtensionsTests
    {
        [Theory]
        [InlineData(new[] { InnerBorderEdges.All }, TableBorderKind.Grid)]
        [InlineData(new[] { InnerBorderEdges.Vertical }, TableBorderKind.Grid)]
        [InlineData(new[] { InnerBorderEdges.Horizontal, InnerBorderEdges.Vertical }, TableBorderKind.Grid)]
        [InlineData(new[] { InnerBorderEdges.Horizontal }, TableBorderKind.Rows)]
        [InlineData(new[] { InnerBorderEdges.Horizontal, InnerBorderEdges.Horizontal }, TableBorderKind.Rows)]
        public static void ToVuescapeTableBorderKind___Should_return_the_lines_the_inner_borders_draw___When_the_table_gives_its_inner_borders(
            InnerBorderEdges[] edges,
            TableBorderKind expected)
        {
            // Arrange
            var innerBorders = edges
                .Select(_ => new InnerBorder(BorderWeight.Normal, BorderStyle.Solid, Color.Black, _))
                .ToList();
            var systemUnderTest = new TableFormat(innerBorders: innerBorders);

            // Act
            var actual = systemUnderTest.ToVuescapeTableBorderKind();

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public static void ToVuescapeTableBorderKind___Should_return_null___When_the_table_does_not_give_its_inner_borders()
        {
            // Act & Assert
            Assert.Null(((TableFormat)null).ToVuescapeTableBorderKind());
            Assert.Null(new TableFormat().ToVuescapeTableBorderKind());
        }

        [Theory]
        [InlineData(null, "cell-border")]
        [InlineData(TableBorderKind.Grid, "cell-border")]
        [InlineData(TableBorderKind.Rows, "cell-border row-border")]
        [InlineData(TableBorderKind.None, "cell-border no-border")]
        public static void ToVuescapeTreeTableCssClass___Should_return_the_original_tree_tables_classes_for_the_lines(
            TableBorderKind? borders,
            string expected)
        {
            // Act
            var actual = borders.ToVuescapeTreeTableCssClass();

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
