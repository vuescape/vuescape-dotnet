// <copyright file="RowFormatOptionsExtensionsTests.cs" company="Vuescape">
//    Copyright (c) Vuescape 2026. All rights reserved.
// </copyright>

namespace Vuescape.DotNet.Domain.Test
{
    using System;
    using OBeautifulCode.DataStructure;
    using Xunit;

    [CLSCompliant(false)]
    public static class RowFormatOptionsExtensionsTests
    {
        [Theory]
        [InlineData(RowFormatOptions.None, true)]
        [InlineData(RowFormatOptions.Hide, false)]
        [InlineData(RowFormatOptions.DisableCollapsing, true)]
        [InlineData(RowFormatOptions.DisableCollapsing | RowFormatOptions.AlignChildRowsWithParent | RowFormatOptions.Hide, false)]
        public static void IsVisible___Should_return_false___Only_when_options_include_Hide(
            RowFormatOptions options,
            bool expected)
        {
            // Act
            var actual = ((RowFormatOptions?)options).IsVisible();

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(RowFormatOptions.None, false)]
        [InlineData(RowFormatOptions.Hide, false)]
        [InlineData(RowFormatOptions.DisableCollapsing, true)]
        [InlineData(RowFormatOptions.DisableCollapsing | RowFormatOptions.AlignChildRowsWithParent | RowFormatOptions.Hide, true)]
        public static void IsNotExpandable___Should_return_true___Only_when_options_include_DisableCollapsing(
            RowFormatOptions options,
            bool expected)
        {
            // Act
            var actual = ((RowFormatOptions?)options).IsNotExpandable();

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(RowFormatOptions.None, false)]
        [InlineData(RowFormatOptions.Hide, false)]
        [InlineData(RowFormatOptions.Freeze, true)]
        [InlineData(RowFormatOptions.Freeze | RowFormatOptions.DisableCollapsing, true)]
        public static void IsFrozen___Should_return_true___Only_when_options_include_Freeze(
            RowFormatOptions options,
            bool expected)
        {
            // Act
            var actual = ((RowFormatOptions?)options).IsFrozen();

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public static void Extensions___Should_treat_null_options_as_None()
        {
            // Arrange
            RowFormatOptions? options = null;

            // Act & Assert
            Assert.True(options.IsVisible());
            Assert.False(options.IsNotExpandable());
            Assert.False(options.IsFrozen());
        }
    }
}
