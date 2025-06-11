

namespace Vuescape.DotNet.Domain.Test
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;

    using FakeItEasy;

    using OBeautifulCode.AutoFakeItEasy;
    using OBeautifulCode.CodeAnalysis.Recipes;
    using OBeautifulCode.CodeGen.ModelObject.Recipes;
    using OBeautifulCode.DataStructure;
    using OBeautifulCode.Math.Recipes;

    using Xunit;

    using static System.FormattableString;

    [SuppressMessage("Microsoft.Maintainability", "CA1505:AvoidUnmaintainableCode", Justification = ObcSuppressBecause.CA1505_AvoidUnmaintainableCode_DisagreeWithAssessment)]
    public static partial class RowBaseExtensionsTests
    {
        [Fact]
        public static void IsBlankFlatRow__Should_throw_ArgumentNullException___When_row_is_null()
        {
            // Arrange
            RowBase row = null;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => row.IsBlankFlatRow());
        }

        [Fact]
        public static void IsBlankFlatRow___Should_return_false___When_row_is_not_a_FlatRow()
        {
            // Arrange
            var treeRow = new Row(id: A.Dummy<string>(), cells: new ICell[] { new ConstCell<string>(id: A.Dummy<string>(), value: string.Empty) });

            // Act
            var result = treeRow.IsBlankFlatRow();

            // Assert
            Assert.False(result);
        }

        [Fact]
        public static void IsBlankFlatRow___Should_return_true___When_FlatRow_has_white_space_ConstCells()
        {
            // Arrange
            var cells = new List<CellBase>
            {
                new ConstCell<string>(" ", A.Dummy<string>()),
                new ConstCell<string>("\t\n", A.Dummy<string>()),
            };

            var flat = new FlatRow(id: A.Dummy<string>(), cells: cells);

            // Act
            var result = flat.IsBlankFlatRow();

            // Assert
            Assert.True(result);
        }

        [Fact]
        public static void IsBlankFlatRow___Should_return_false___When_FlatRow_has_ConstCell_with_a_value()
        {
            // Arrange
            var cells = new List<CellBase>
            {
                new InputCell<string>(A.Dummy<string>()),
            };

            var flat = new FlatRow(id: A.Dummy<string>(), cells: cells);

            // Act
            var result = flat.IsBlankFlatRow();

            // Assert
            Assert.False(result);
        }
    }
}