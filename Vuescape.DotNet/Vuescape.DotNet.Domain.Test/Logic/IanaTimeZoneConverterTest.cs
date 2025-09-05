// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IanaTimeZoneConverterTest.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
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
    using OBeautifulCode.Math.Recipes;
    using OBeautifulCode.Type;

    using Xunit;

    using static System.FormattableString;

    [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Iana", Justification = ObcSuppressBecause.CA1704_IdentifiersShouldBeSpelledCorrectly_SpellingIsCorrectInContextOfTheDomain)]
    [SuppressMessage("Microsoft.Maintainability", "CA1505:AvoidUnmaintainableCode", Justification = ObcSuppressBecause.CA1505_AvoidUnmaintainableCode_DisagreeWithAssessment)]
    public static partial class IanaTimeZoneConverterTest
    {
        [SuppressMessage("Microsoft.Maintainability", "CA1505:AvoidUnmaintainableCode", Justification = ObcSuppressBecause.CA1505_AvoidUnmaintainableCode_DisagreeWithAssessment)]
        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        static IanaTimeZoneConverterTest()
        {
        }

        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "timezone", Justification = ObcSuppressBecause.CA1704_IdentifiersShouldBeSpelledCorrectly_SpellingIsCorrectInContextOfTheDomain)]
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Iana", Justification = ObcSuppressBecause.CA1704_IdentifiersShouldBeSpelledCorrectly_SpellingIsCorrectInContextOfTheDomain)]
        [Fact]
        public static void ConvertIanaToStandardTimeZone___Valid_timezone_id___Returns_correct_StandardTimeZone()
        {
            // Arrange
            var testCases = new Dictionary<string, StandardTimeZone>
            {
                { "America/New_York", StandardTimeZone.Eastern },
                { "America/Los_Angeles", StandardTimeZone.Pacific },
                { "America/Chicago", StandardTimeZone.Central },
                { "America/Denver", StandardTimeZone.Mountain },
                { "Europe/London", StandardTimeZone.Gmt },
                { "Europe/Paris", StandardTimeZone.Romance },
                { "Asia/Tokyo", StandardTimeZone.Tokyo },
                { "Australia/Sydney", StandardTimeZone.AustraliaEastern },
                { "Pacific/Honolulu", StandardTimeZone.Hawaiian },
                { "America/Phoenix", StandardTimeZone.UnitedStatesMountain },
                { "Etc/GMT+12", StandardTimeZone.Dateline },
            };

            foreach (var testCase in testCases)
            {
                // Act
                var result = IanaTimeZoneConverter.ConvertIanaToStandardTimeZone(testCase.Key);

                // Assert
                Assert.Equal(testCase.Value, result);
            }
        }

        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "timezone", Justification = ObcSuppressBecause.CA1704_IdentifiersShouldBeSpelledCorrectly_SpellingIsCorrectInContextOfTheDomain)]
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Iana", Justification = ObcSuppressBecause.CA1704_IdentifiersShouldBeSpelledCorrectly_SpellingIsCorrectInContextOfTheDomain)]
        [Fact]
        public static void ConvertIanaToStandardTimeZone___Case_insensitive_timezone_id___Returns_correct_StandardTimeZone()
        {
            // Arrange
            var testCases = new Dictionary<string, StandardTimeZone>
            {
                { "america/new_york", StandardTimeZone.Eastern },
                { "AMERICA/LOS_ANGELES", StandardTimeZone.Pacific },
                { "Europe/LONDON", StandardTimeZone.Gmt },
                { "ASIA/TOKYO", StandardTimeZone.Tokyo },
            };

            foreach (var testCase in testCases)
            {
                // Act
                var result = IanaTimeZoneConverter.ConvertIanaToStandardTimeZone(testCase.Key);

                // Assert
                Assert.Equal(testCase.Value, result);
            }
        }

        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "iana", Justification = ObcSuppressBecause.CA1704_IdentifiersShouldBeSpelledCorrectly_SpellingIsCorrectInContextOfTheDomain)]
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "timezone", Justification = ObcSuppressBecause.CA1704_IdentifiersShouldBeSpelledCorrectly_SpellingIsCorrectInContextOfTheDomain)]
        [SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "whitespace", Justification = ObcSuppressBecause.CA1702_CompoundWordsShouldBeCasedCorrectly_AnalyzerIsIncorrectlyDetectingCompoundWords)]
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Iana", Justification = ObcSuppressBecause.CA1704_IdentifiersShouldBeSpelledCorrectly_SpellingIsCorrectInContextOfTheDomain)]
        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("   ")]
        [InlineData("\t")]
        [InlineData("\n")]
        public static void ConvertIanaToStandardTimeZone___Null_or_whitespace_timezone_id___Returns_Unknown(string ianaTimeZoneId)
        {
            // Arrange
            // Act
            var result = IanaTimeZoneConverter.ConvertIanaToStandardTimeZone(ianaTimeZoneId);

            // Assert
            Assert.Equal(StandardTimeZone.Unknown, result);
        }

        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "timezone", Justification = ObcSuppressBecause.CA1704_IdentifiersShouldBeSpelledCorrectly_SpellingIsCorrectInContextOfTheDomain)]
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Iana", Justification = ObcSuppressBecause.CA1704_IdentifiersShouldBeSpelledCorrectly_SpellingIsCorrectInContextOfTheDomain)]
        [Fact]
        public static void ConvertIanaToStandardTimeZone___Unknown_timezone_id___Returns_Unknown()
        {
            // Arrange
            var unknownTimeZoneIds = new[]
            {
                "Invalid/TimeZone",
                "NonExistent/Zone",
                "America/FakeCity",
                "Europe/NonExistentCity",
                "Random/String",
            };

            foreach (var unknownId in unknownTimeZoneIds)
            {
                // Act
                var result = IanaTimeZoneConverter.ConvertIanaToStandardTimeZone(unknownId);

                // Assert
                Assert.Equal(StandardTimeZone.Unknown, result);
            }
        }

        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "timezone", Justification = ObcSuppressBecause.CA1704_IdentifiersShouldBeSpelledCorrectly_SpellingIsCorrectInContextOfTheDomain)]
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Iana", Justification = ObcSuppressBecause.CA1704_IdentifiersShouldBeSpelledCorrectly_SpellingIsCorrectInContextOfTheDomain)]
        [Fact]
        public static void TryConvertIanaToStandardTimeZone___Valid_timezone_id___Returns_true_and_correct_StandardTimeZone()
        {
            // Arrange
            var testCases = new Dictionary<string, StandardTimeZone>
            {
                { "America/New_York", StandardTimeZone.Eastern },
                { "America/Los_Angeles", StandardTimeZone.Pacific },
                { "Europe/London", StandardTimeZone.Gmt },
                { "Asia/Tokyo", StandardTimeZone.Tokyo },
                { "Australia/Sydney", StandardTimeZone.AustraliaEastern },
            };

            foreach (var testCase in testCases)
            {
                // Act
                var result = IanaTimeZoneConverter.TryConvertIanaToStandardTimeZone(testCase.Key, out var standardTimeZone);

                // Assert
                Assert.True(result);
                Assert.Equal(testCase.Value, standardTimeZone);
            }
        }

        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "timezone", Justification = ObcSuppressBecause.CA1704_IdentifiersShouldBeSpelledCorrectly_SpellingIsCorrectInContextOfTheDomain)]
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Iana", Justification = ObcSuppressBecause.CA1704_IdentifiersShouldBeSpelledCorrectly_SpellingIsCorrectInContextOfTheDomain)]
        [Fact]
        public static void TryConvertIanaToStandardTimeZone___Case_insensitive_timezone_id___Returns_true_and_correct_StandardTimeZone()
        {
            // Arrange
            var testCases = new Dictionary<string, StandardTimeZone>
            {
                { "america/new_york", StandardTimeZone.Eastern },
                { "EUROPE/LONDON", StandardTimeZone.Gmt },
                { "Asia/TOKYO", StandardTimeZone.Tokyo },
            };

            foreach (var testCase in testCases)
            {
                // Act
                var result = IanaTimeZoneConverter.TryConvertIanaToStandardTimeZone(testCase.Key, out var standardTimeZone);

                // Assert
                Assert.True(result);
                Assert.Equal(testCase.Value, standardTimeZone);
            }
        }

        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "timezone", Justification = ObcSuppressBecause.CA1704_IdentifiersShouldBeSpelledCorrectly_SpellingIsCorrectInContextOfTheDomain)]
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "iana", Justification = ObcSuppressBecause.CA1704_IdentifiersShouldBeSpelledCorrectly_SpellingIsCorrectInContextOfTheDomain)]
        [SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "whitespace", Justification = ObcSuppressBecause.CA1702_CompoundWordsShouldBeCasedCorrectly_AnalyzerIsIncorrectlyDetectingCompoundWords)]
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Iana", Justification = ObcSuppressBecause.CA1704_IdentifiersShouldBeSpelledCorrectly_SpellingIsCorrectInContextOfTheDomain)]
        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("   ")]
        [InlineData("\t")]
        [InlineData("\n")]
        public static void TryConvertIanaToStandardTimeZone___Null_or_whitespace_timezone_id___Returns_false_and_Unknown(string ianaTimeZoneId)
        {
            // Arrange
            // Act
            var result = IanaTimeZoneConverter.TryConvertIanaToStandardTimeZone(ianaTimeZoneId, out var standardTimeZone);

            // Assert
            Assert.False(result);
            Assert.Equal(StandardTimeZone.Unknown, standardTimeZone);
        }

        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "timezone", Justification = ObcSuppressBecause.CA1704_IdentifiersShouldBeSpelledCorrectly_SpellingIsCorrectInContextOfTheDomain)]
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Iana", Justification = ObcSuppressBecause.CA1704_IdentifiersShouldBeSpelledCorrectly_SpellingIsCorrectInContextOfTheDomain)]
        [Fact]
        public static void TryConvertIanaToStandardTimeZone___Unknown_timezone_id___Returns_false_and_default_StandardTimeZone()
        {
            // Arrange
            var unknownTimeZoneIds = new[]
            {
                "Invalid/TimeZone",
                "NonExistent/Zone",
                "America/FakeCity",
                "Europe/NonExistentCity",
            };

            foreach (var unknownId in unknownTimeZoneIds)
            {
                // Act
                var result = IanaTimeZoneConverter.TryConvertIanaToStandardTimeZone(unknownId, out var standardTimeZone);

                // Assert
                Assert.False(result);
                Assert.Equal(default(StandardTimeZone), standardTimeZone);
            }
        }

        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "timezone", Justification = ObcSuppressBecause.CA1704_IdentifiersShouldBeSpelledCorrectly_SpellingIsCorrectInContextOfTheDomain)]
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Iana", Justification = ObcSuppressBecause.CA1704_IdentifiersShouldBeSpelledCorrectly_SpellingIsCorrectInContextOfTheDomain)]
        [Fact]
        public static void GetSupportedIanaTimeZoneIds___Called___Returns_all_supported_timezone_ids()
        {
            // Arrange
            var expectedTimeZoneIds = new[]
            {
                "America/New_York",
                "America/Los_Angeles",
                "America/Chicago",
                "America/Denver",
                "Europe/London",
                "Europe/Paris",
                "Asia/Tokyo",
                "Australia/Sydney",
                "Pacific/Honolulu",
                "America/Phoenix",
                "Etc/GMT+12",
                "Pacific/Midway",
                "America/Anchorage",
                "America/Tijuana",
                "America/Chihuahua",
                "America/Whitehorse",
                "America/Belize",
                "America/Mexico_City",
                "America/Regina",
                "America/Bogota",
                "America/Cancun",
                "America/Toronto",
                "America/Port-au-Prince",
                "America/Havana",
                "America/Indiana/Indianapolis",
                "America/Grand_Turk",
                "America/Asuncion",
                "America/Halifax",
                "America/Caracas",
                "America/Cuiaba",
                "America/Georgetown",
                "America/Santiago",
                "America/St_Johns",
                "America/Araguaina",
                "America/Sao_Paulo",
                "America/Cayenne",
                "America/Argentina/Buenos_Aires",
                "America/Nuuk",
                "America/Montevideo",
                "America/Punta_Arenas",
                "America/Miquelon",
                "America/Salvador",
                "Atlantic/Azores",
                "Atlantic/Cape_Verde",
                "Europe/Dublin",
                "Africa/Monrovia",
                "Africa/Sao_Tome",
                "Africa/Casablanca",
                "Europe/Amsterdam",
                "Europe/Belgrade",
                "Europe/Brussels",
                "Europe/Sarajevo",
                "Africa/Lagos",
                "Asia/Amman",
                "Europe/Athens",
                "Asia/Beirut",
                "Africa/Cairo",
                "Europe/Chisinau",
                "Asia/Damascus",
                "Asia/Gaza",
                "Africa/Harare",
                "Europe/Helsinki",
                "Asia/Jerusalem",
                "Africa/Juba",
                "Europe/Kaliningrad",
                "Africa/Khartoum",
                "Africa/Tripoli",
                "Africa/Windhoek",
                "Asia/Baghdad",
                "Europe/Istanbul",
                "Asia/Kuwait",
                "Europe/Minsk",
                "Europe/Moscow",
                "Africa/Nairobi",
                "Europe/Volgograd",
                "Asia/Tehran",
                "Asia/Dubai",
                "Europe/Astrakhan",
                "Asia/Baku",
                "Indian/Mauritius",
                "Europe/Saratov",
                "Asia/Tbilisi",
                "Asia/Yerevan",
                "Asia/Kabul",
                "Asia/Ashgabat",
                "Asia/Yekaterinburg",
                "Asia/Karachi",
                "Asia/Qyzylorda",
                "Asia/Kolkata",
                "Asia/Colombo",
                "Asia/Kathmandu",
                "Asia/Almaty",
                "Asia/Dhaka",
                "Asia/Omsk",
                "Asia/Rangoon",
                "Asia/Bangkok",
                "Asia/Barnaul",
                "Asia/Hovd",
                "Asia/Krasnoyarsk",
                "Asia/Novosibirsk",
                "Asia/Tomsk",
                "Asia/Shanghai",
                "Asia/Irkutsk",
                "Asia/Kuala_Lumpur",
                "Australia/Perth",
                "Asia/Taipei",
                "Asia/Ulaanbaatar",
                "Australia/Eucla",
                "Asia/Chita",
                "Asia/Pyongyang",
                "Asia/Seoul",
                "Asia/Yakutsk",
                "Australia/Adelaide",
                "Australia/Darwin",
                "Australia/Brisbane",
                "Pacific/Guam",
                "Australia/Hobart",
                "Asia/Vladivostok",
                "Australia/Lord_Howe",
                "Pacific/Bougainville",
                "Asia/Magadan",
                "Pacific/Norfolk",
                "Asia/Sakhalin",
                "Pacific/Guadalcanal",
                "Pacific/Auckland",
                "Pacific/Fiji",
                "Asia/Kamchatka",
                "Pacific/Chatham",
                "Pacific/Tongatapu",
                "Pacific/Apia",
                "Pacific/Kiritimati",
            };

            // Act
            var result = IanaTimeZoneConverter.GetSupportedIanaTimeZoneIds();

            // Assert
            Assert.NotNull(result);
            var resultList = result.ToList();
            Assert.NotEmpty(resultList);

            // Verify that all expected timezone IDs are present
            foreach (var expectedId in expectedTimeZoneIds)
            {
                Assert.Contains(expectedId, resultList);
            }

            // Verify that the result contains only unique values
            Assert.Equal(resultList.Count, resultList.Distinct().Count());
        }

        [Fact]
        public static void GetSupportedMappingCount___Called___Returns_correct_count()
        {
            // Arrange
            var expectedMinimumCount = 150; // Based on the extensive mapping in the converter

            // Act
            var result = IanaTimeZoneConverter.GetSupportedMappingCount();

            // Assert
            Assert.True(result >= expectedMinimumCount, $"Expected at least {expectedMinimumCount} mappings, but got {result}");
            Assert.True(result > 0, "Mapping count should be greater than 0");
        }

        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Iana", Justification = ObcSuppressBecause.CA1704_IdentifiersShouldBeSpelledCorrectly_SpellingIsCorrectInContextOfTheDomain)]
        [Fact]
        public static void GetSupportedMappingCount___Called___Matches_GetSupportedIanaTimeZoneIds_count()
        {
            // Arrange
            // Act
            var mappingCount = IanaTimeZoneConverter.GetSupportedMappingCount();
            var timeZoneIds = IanaTimeZoneConverter.GetSupportedIanaTimeZoneIds();
            var timeZoneIdsCount = timeZoneIds.Count();

            // Assert
            Assert.Equal(mappingCount, timeZoneIdsCount);
        }

        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "timezone", Justification = ObcSuppressBecause.CA1704_IdentifiersShouldBeSpelledCorrectly_SpellingIsCorrectInContextOfTheDomain)]
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Iana", Justification = ObcSuppressBecause.CA1704_IdentifiersShouldBeSpelledCorrectly_SpellingIsCorrectInContextOfTheDomain)]
        [Fact]
        public static void ConvertIanaToStandardTimeZone___Comprehensive_timezone_mappings___All_return_correct_values()
        {
            // Arrange
            var comprehensiveTestCases = new Dictionary<string, StandardTimeZone>
            {
                // UTC-12:00 to UTC-11:00
                { "Etc/GMT+12", StandardTimeZone.Dateline },
                { "Pacific/Midway", StandardTimeZone.Samoa },
                { "Pacific/Pago_Pago", StandardTimeZone.Samoa },

                // UTC-10:00 to UTC-09:00
                { "America/Adak", StandardTimeZone.Aleutian },
                { "Pacific/Honolulu", StandardTimeZone.Hawaiian },
                { "Pacific/Marquesas", StandardTimeZone.Marquesas },
                { "America/Anchorage", StandardTimeZone.Alaskan },

                // UTC-08:00 to UTC-07:00
                { "America/Tijuana", StandardTimeZone.PacificMexico },
                { "America/Los_Angeles", StandardTimeZone.Pacific },
                { "America/Phoenix", StandardTimeZone.UnitedStatesMountain },
                { "America/Chihuahua", StandardTimeZone.MountainMexico },
                { "America/Denver", StandardTimeZone.Mountain },
                { "America/Whitehorse", StandardTimeZone.Yukon },

                // UTC-06:00 to UTC-05:00
                { "America/Belize", StandardTimeZone.CentralAmerica },
                { "America/Chicago", StandardTimeZone.Central },
                { "Pacific/Easter", StandardTimeZone.EasterIsland },
                { "America/Mexico_City", StandardTimeZone.CentralMexico },
                { "America/Regina", StandardTimeZone.CanadaCentral },
                { "America/Bogota", StandardTimeZone.SouthAmericaPacific },
                { "America/Cancun", StandardTimeZone.EasternMexico },
                { "America/New_York", StandardTimeZone.Eastern },
                { "America/Port-au-Prince", StandardTimeZone.Haiti },
                { "America/Havana", StandardTimeZone.Cuba },
                { "America/Indiana/Indianapolis", StandardTimeZone.UnitedStatesEastern },
                { "America/Grand_Turk", StandardTimeZone.TurksAndCaicos },

                // UTC-04:00 to UTC-03:00
                { "America/Asuncion", StandardTimeZone.Paraguay },
                { "America/Halifax", StandardTimeZone.Atlantic },
                { "America/Caracas", StandardTimeZone.Venezuela },
                { "America/Cuiaba", StandardTimeZone.CentralBrazilian },
                { "America/Georgetown", StandardTimeZone.SouthAmericaWestern },
                { "America/Santiago", StandardTimeZone.PacificSouthAmerica },
                { "America/St_Johns", StandardTimeZone.Newfoundland },
                { "America/Araguaina", StandardTimeZone.Tocantins },
                { "America/Sao_Paulo", StandardTimeZone.EasternSouthAmerica },
                { "America/Cayenne", StandardTimeZone.SouthAmericaEastern },
                { "America/Argentina/Buenos_Aires", StandardTimeZone.Argentina },
                { "America/Nuuk", StandardTimeZone.Greenland },
                { "America/Montevideo", StandardTimeZone.Montevideo },

                // UTC-02:00 to UTC+00:00
                { "Atlantic/Azores", StandardTimeZone.Azores },
                { "Atlantic/Cape_Verde", StandardTimeZone.CapeVerde },
                { "Europe/Dublin", StandardTimeZone.Gmt },
                { "Europe/London", StandardTimeZone.Gmt },
                { "Africa/Monrovia", StandardTimeZone.Greenwich },
                { "Africa/Sao_Tome", StandardTimeZone.SaoTome },

                // UTC+01:00 to UTC+02:00
                { "Africa/Casablanca", StandardTimeZone.Morocco },
                { "Europe/Amsterdam", StandardTimeZone.WesternEurope },
                { "Europe/Belgrade", StandardTimeZone.CentralEurope },
                { "Europe/Brussels", StandardTimeZone.Romance },
                { "Europe/Sarajevo", StandardTimeZone.CentralEuropean },
                { "Africa/Lagos", StandardTimeZone.WesternCentralAfrica },
                { "Asia/Amman", StandardTimeZone.Jordan },
                { "Europe/Athens", StandardTimeZone.Gtb },
                { "Asia/Beirut", StandardTimeZone.MiddleEast },
                { "Africa/Cairo", StandardTimeZone.Egypt },
                { "Europe/Chisinau", StandardTimeZone.EasternEurope },
                { "Asia/Damascus", StandardTimeZone.Syria },
                { "Asia/Gaza", StandardTimeZone.WestBank },
                { "Africa/Harare", StandardTimeZone.SouthAfrica },
                { "Europe/Helsinki", StandardTimeZone.Fle },
                { "Asia/Jerusalem", StandardTimeZone.Israel },
                { "Africa/Juba", StandardTimeZone.SouthSudan },
                { "Europe/Kaliningrad", StandardTimeZone.Kaliningrad },
                { "Africa/Tripoli", StandardTimeZone.Libya },
                { "Africa/Windhoek", StandardTimeZone.Namibia },

                // UTC+03:00 to UTC+05:00
                { "Asia/Baghdad", StandardTimeZone.Arabic },
                { "Europe/Istanbul", StandardTimeZone.Turkey },
                { "Asia/Kuwait", StandardTimeZone.Arab },
                { "Europe/Minsk", StandardTimeZone.Belarus },
                { "Europe/Moscow", StandardTimeZone.Russian },
                { "Africa/Nairobi", StandardTimeZone.EasternAfrica },
                { "Asia/Tehran", StandardTimeZone.Iran },
                { "Asia/Dubai", StandardTimeZone.Arabian },
                { "Asia/Baku", StandardTimeZone.Azerbaijan },
                { "Asia/Tbilisi", StandardTimeZone.Georgian },
                { "Asia/Yerevan", StandardTimeZone.Caucasus },
                { "Asia/Kabul", StandardTimeZone.Afghanistan },
                { "Asia/Ashgabat", StandardTimeZone.WestAsia },
                { "Asia/Yekaterinburg", StandardTimeZone.Ekaterinburg },
                { "Asia/Karachi", StandardTimeZone.Pakistan },

                // UTC+05:30 to UTC+08:00
                { "Asia/Kolkata", StandardTimeZone.India },
                { "Asia/Colombo", StandardTimeZone.SriLanka },
                { "Asia/Kathmandu", StandardTimeZone.Nepal },
                { "Asia/Almaty", StandardTimeZone.CentralAsia },
                { "Asia/Dhaka", StandardTimeZone.Bangladesh },
                { "Asia/Omsk", StandardTimeZone.Omsk },
                { "Asia/Rangoon", StandardTimeZone.Myanmar },
                { "Asia/Bangkok", StandardTimeZone.SoutheastAsia },
                { "Asia/Krasnoyarsk", StandardTimeZone.NorthAsia },
                { "Asia/Shanghai", StandardTimeZone.China },
                { "Asia/Irkutsk", StandardTimeZone.NorthAsiaEast },
                { "Asia/Kuala_Lumpur", StandardTimeZone.Singapore },
                { "Australia/Perth", StandardTimeZone.WesternAustralia },
                { "Asia/Taipei", StandardTimeZone.Taipei },
                { "Asia/Ulaanbaatar", StandardTimeZone.Ulaanbaatar },

                // UTC+09:00 to UTC+12:00
                { "Asia/Tokyo", StandardTimeZone.Tokyo },
                { "Asia/Seoul", StandardTimeZone.Korea },
                { "Asia/Yakutsk", StandardTimeZone.Yakutsk },
                { "Australia/Adelaide", StandardTimeZone.CentralAustralia },
                { "Australia/Darwin", StandardTimeZone.AustraliaCentral },
                { "Australia/Brisbane", StandardTimeZone.EasternAustralia },
                { "Australia/Sydney", StandardTimeZone.AustraliaEastern },
                { "Pacific/Guam", StandardTimeZone.WestPacific },
                { "Australia/Hobart", StandardTimeZone.Tasmania },
                { "Asia/Vladivostok", StandardTimeZone.Vladivostok },
                { "Pacific/Auckland", StandardTimeZone.NewZealand },
                { "Pacific/Fiji", StandardTimeZone.Fiji },
                { "Asia/Kamchatka", StandardTimeZone.Kamchatka },

                // UTC+13:00 to UTC+14:00
                { "Pacific/Tongatapu", StandardTimeZone.Tonga },
                { "Pacific/Apia", StandardTimeZone.Samoa },
                { "Pacific/Kiritimati", StandardTimeZone.LineIslands },
            };

            foreach (var testCase in comprehensiveTestCases)
            {
                // Act
                var result = IanaTimeZoneConverter.ConvertIanaToStandardTimeZone(testCase.Key);

                // Assert
                Assert.Equal(testCase.Value, result);
            }
        }

        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Iana", Justification = ObcSuppressBecause.CA1704_IdentifiersShouldBeSpelledCorrectly_SpellingIsCorrectInContextOfTheDomain)]
        [Fact]
        public static void ConvertIanaToStandardTimeZone___Edge_cases___Handle_correctly()
        {
            // Arrange & Act & Assert
            // Test old vs new timezone names
            Assert.Equal(StandardTimeZone.Greenland, IanaTimeZoneConverter.ConvertIanaToStandardTimeZone("America/Godthab")); // Old name
            Assert.Equal(StandardTimeZone.Greenland, IanaTimeZoneConverter.ConvertIanaToStandardTimeZone("America/Nuuk")); // New name

            Assert.Equal(StandardTimeZone.Fle, IanaTimeZoneConverter.ConvertIanaToStandardTimeZone("Europe/Kiev")); // Old name
            Assert.Equal(StandardTimeZone.Fle, IanaTimeZoneConverter.ConvertIanaToStandardTimeZone("Europe/Kyiv")); // New name

            Assert.Equal(StandardTimeZone.Myanmar, IanaTimeZoneConverter.ConvertIanaToStandardTimeZone("Asia/Rangoon")); // Old name
            Assert.Equal(StandardTimeZone.Myanmar, IanaTimeZoneConverter.ConvertIanaToStandardTimeZone("Asia/Yangon")); // New name

            // Test duplicate entries for Chatham Islands (different UTC offsets but same enum)
            Assert.Equal(StandardTimeZone.ChathamIslands, IanaTimeZoneConverter.ConvertIanaToStandardTimeZone("Pacific/Chatham"));

            // Test Samoa timezone (appears in both UTC-11 and UTC+13 sections)
            Assert.Equal(StandardTimeZone.Samoa, IanaTimeZoneConverter.ConvertIanaToStandardTimeZone("Pacific/Midway")); // UTC-11
            Assert.Equal(StandardTimeZone.Samoa, IanaTimeZoneConverter.ConvertIanaToStandardTimeZone("Pacific/Apia")); // UTC+13
        }
    }
}
