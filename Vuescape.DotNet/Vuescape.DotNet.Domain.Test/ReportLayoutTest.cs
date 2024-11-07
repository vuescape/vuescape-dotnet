namespace Vuescape.DotNet.Domain.Test
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using FakeItEasy;

    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.CodeAnalysis.Recipes;
    using OBeautifulCode.CodeGen.ModelObject.Recipes;
    using Xunit;

    using static System.FormattableString;

    [SuppressMessage("Microsoft.Maintainability", "CA1505:AvoidUnmaintainableCode", Justification = ObcSuppressBecause.CA1505_AvoidUnmaintainableCode_DisagreeWithAssessment)]
    public static partial class ReportLayoutTest
    {
        [SuppressMessage("Microsoft.Maintainability", "CA1505:AvoidUnmaintainableCode", Justification = ObcSuppressBecause.CA1505_AvoidUnmaintainableCode_DisagreeWithAssessment)]
        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        static ReportLayoutTest()
        {
            ConstructorArgumentValidationTestScenarios
                .RemoveAllScenarios()
                .AddScenario(() =>
                    new ConstructorArgumentValidationTestScenario<ReportLayout>
                    {
                        Name = "constructor should throw ArgumentNullException when parameter 'id' is null scenario",
                        ConstructionFunc = () =>
                        {
                            var referenceObject = A.Dummy<ReportLayout>();

                            var result = new ReportLayout(
                                null,
                                referenceObject.LeftPane,
                                referenceObject.RightPane,
                                referenceObject.CenterPane,
                                referenceObject.Title);

                            return result;
                        },
                        ExpectedExceptionType = typeof(ArgumentNullException),
                        ExpectedExceptionMessageContains = new[] { "id", },
                    })
                .AddScenario(() =>
                    new ConstructorArgumentValidationTestScenario<ReportLayout>
                    {
                        Name = "constructor should throw ArgumentException when parameter 'id' is white space scenario",
                        ConstructionFunc = () =>
                        {
                            var referenceObject = A.Dummy<ReportLayout>();

                            var result = new ReportLayout(
                                Invariant($"  {Environment.NewLine}  "),
                                referenceObject.LeftPane,
                                referenceObject.RightPane,
                                referenceObject.CenterPane,
                                referenceObject.Title);

                            return result;
                        },
                        ExpectedExceptionType = typeof(ArgumentException),
                        ExpectedExceptionMessageContains = new[] { "id", "white space", },
                    })
                .AddScenario(() =>
                    new ConstructorArgumentValidationTestScenario<ReportLayout>
                    {
                        Name =
                            "constructor should throw ArgumentNullException when parameter 'leftPane', 'rightPane', and 'centerPane' are all null scenario",
                        ConstructionFunc = () =>
                        {
                            var referenceObject = A.Dummy<ReportLayout>();

                            var result = new ReportLayout(
                                referenceObject.Id,
                                null,
                                null,
                                null,
                                referenceObject.Title);

                            return result;
                        },
                        ExpectedExceptionType = typeof(ArgumentNullException),
                        ExpectedExceptionMessageContains = new[] { "leftPane", },
                    });
        }

        [Fact]
        public static void Constructor___Should_not_throw___When_leftPane_is_null()
        {
            var sut = new ReportLayout(A.Dummy<string>(), A.Dummy<PaneLayout>(), null, null);

            sut.AsTest().Must().NotBeNull();
        }

        [Fact]
        public static void Constructor___Should_not_throw___When_rightPane_is_null()
        {
            var sut = new ReportLayout(A.Dummy<string>(), null, A.Dummy<PaneLayout>(), null);

            sut.AsTest().Must().NotBeNull();
        }

        [Fact]
        public static void Constructor___Should_not_throw___When_centerPane_is_null()
        {
            var sut = new ReportLayout(A.Dummy<string>(), null, null, A.Dummy<PaneLayout>());

            sut.AsTest().Must().NotBeNull();
        }
    }
}