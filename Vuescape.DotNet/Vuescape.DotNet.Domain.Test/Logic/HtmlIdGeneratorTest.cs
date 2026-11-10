// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HtmlIdGeneratorTest.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain.Test
{
    using System;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;
    using Xunit;

    public static class HtmlIdGeneratorTest
    {
        private static MethodInfo GetToBase36()
        {
            return typeof(HtmlIdGenerator)
                .GetMethod("ToBase36", BindingFlags.NonPublic | BindingFlags.Static)
                ?? throw new InvalidOperationException("Could not find ToBase36 method");
        }

        [Fact]
        public static void ToBase36_WithZero_ReturnsZeroString()
        {
            var value = new object[] { 0UL };
            var systemUnderTest = GetToBase36();

            var actual = (string)systemUnderTest.Invoke(null, value);

            Assert.Equal("0", actual);
        }

        [Fact]
        public static void ToBase36_WithOne_ReturnsOneString()
        {
            var value = new object[] { 1UL };
            var systemUnderTest = GetToBase36();

            var actual = (string)systemUnderTest.Invoke(null, value);

            Assert.Equal("1", actual);
        }

        [Fact]
        public static void ToBase36_WithThirtyFive_ReturnsZ()
        {
            var value = new object[] { 35UL };
            var systemUnderTest = GetToBase36();

            var actual = (string)systemUnderTest.Invoke(null, value);

            Assert.Equal("z", actual);
        }

        [Fact]
        public static void ToBase36_WithThirtySix_Returns10()
        {
            var value = new object[] { 36UL };
            var systemUnderTest = GetToBase36();

            var actual = (string)systemUnderTest.Invoke(null, value);

            Assert.Equal("10", actual);
        }

        [Fact]
        public static void ToBase36_With1234567890_ReturnsExpected()
        {
            var value = new object[] { 1234567890UL };
            var systemUnderTest = GetToBase36();

            var actual = (string)systemUnderTest.Invoke(null, value);

            Assert.Equal("kf12oi", actual);
        }

        [Fact]
        public static void ToBase36_WithMax63BitValue_ReturnsExpected()
        {
            // 2^63-1 = 9223372036854775807
            var value = new object[] { 9223372036854775807UL };
            var systemUnderTest = GetToBase36();

            var actual = (string)systemUnderTest.Invoke(null, value);

            Assert.Equal("1y2p0ij32e8e7", actual);
        }

        [Fact]
        public static void NewId_ProducesOnlyLowercaseLettersAndDigits_AndLength13()
        {
            // Enough Ids that some are small values, which have fewer digits: about 1 in 2,500 has 10 or fewer.
            var regex = new Regex("^[0-9a-z]{13}$", RegexOptions.Compiled);
            for (int i = 0; i < 100000; i++)
            {
                var id = HtmlIdGenerator.NewId();
                Assert.Matches(regex, id);
            }
        }

        [Fact]
        public static void NewId_IsUnique_InSingleThreadedLoop()
        {
            var seen = new HashSet<string>();
            for (int i = 0; i < 1000; i++)
            {
                var id = HtmlIdGenerator.NewId();
                Assert.DoesNotContain(id, seen);
                seen.Add(id);
            }
        }

        [Fact]
        public static void NewId_IsUnique_WhenCalledInParallel()
        {
            var bag = new ConcurrentBag<string>();
            Parallel.For(0, 1000, _ =>
            {
                bag.Add(HtmlIdGenerator.NewId());
            });

            Assert.Equal(1000, bag.Distinct().Count());
        }
    }
}