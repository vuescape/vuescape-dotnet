

namespace Vuescape.DotNet.Domain.Test
{
    using System;
    using System.Diagnostics.CodeAnalysis;

    using FakeItEasy;

    using OBeautifulCode.CodeAnalysis.Recipes;
    using OBeautifulCode.CodeGen.ModelObject.Recipes;

    using static System.FormattableString;

    [SuppressMessage("Microsoft.Maintainability", "CA1505:AvoidUnmaintainableCode", Justification = ObcSuppressBecause.CA1505_AvoidUnmaintainableCode_DisagreeWithAssessment)]
    public static partial class NavigationLinkTest
    {
        [SuppressMessage("Microsoft.Maintainability", "CA1505:AvoidUnmaintainableCode", Justification = ObcSuppressBecause.CA1505_AvoidUnmaintainableCode_DisagreeWithAssessment)]
        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        static NavigationLinkTest()
        {
            NavigationLinkTest.ConstructorArgumentValidationTestScenarios.RemoveAllScenarios()
            .AddScenario(() =>
                new ConstructorArgumentValidationTestScenario<NavigationLink>
                {
                    Name = "constructor should throw ArgumentNullException when parameter 'title' is null scenario",
                    ConstructionFunc = () =>
                    {
                        var referenceObject = A.Dummy<NavigationLink>();

                        var result = new NavigationLink(
                                             null,
                                             referenceObject.Url,
                                             referenceObject.IconName);

                        return result;
                    },
                    ExpectedExceptionType = typeof(ArgumentNullException),
                    ExpectedExceptionMessageContains = new[] { "title", },
                })
            .AddScenario(() =>
                new ConstructorArgumentValidationTestScenario<NavigationLink>
                {
                    Name = "constructor should throw ArgumentException when parameter 'title' is white space scenario",
                    ConstructionFunc = () =>
                    {
                        var referenceObject = A.Dummy<NavigationLink>();

                        var result = new NavigationLink(
                                             Invariant($"  {Environment.NewLine}  "),
                                             referenceObject.Url,
                                             referenceObject.IconName);

                        return result;
                    },
                    ExpectedExceptionType = typeof(ArgumentException),
                    ExpectedExceptionMessageContains = new[] { "title", "white space", },
                })
            .AddScenario(() =>
                new ConstructorArgumentValidationTestScenario<NavigationLink>
                {
                    Name = "constructor should throw ArgumentNullException when parameter 'url' is null scenario",
                    ConstructionFunc = () =>
                    {
                        var referenceObject = A.Dummy<NavigationLink>();

                        var result = new NavigationLink(
                                             referenceObject.Title,
                                             null,
                                             referenceObject.IconName);

                        return result;
                    },
                    ExpectedExceptionType = typeof(ArgumentNullException),
                    ExpectedExceptionMessageContains = new[] { "url", },
                })
            .AddScenario(() =>
                new ConstructorArgumentValidationTestScenario<NavigationLink>
                {
                    Name = "constructor should throw ArgumentException when parameter 'url' is white space scenario",
                    ConstructionFunc = () =>
                    {
                        var referenceObject = A.Dummy<NavigationLink>();

                        var result = new NavigationLink(
                                             referenceObject.Title,
                                             Invariant($"  {Environment.NewLine}  "),
                                             referenceObject.IconName);

                        return result;
                    },
                    ExpectedExceptionType = typeof(ArgumentException),
                    ExpectedExceptionMessageContains = new[] { "url", "white space", },
                });
        }
    }
}