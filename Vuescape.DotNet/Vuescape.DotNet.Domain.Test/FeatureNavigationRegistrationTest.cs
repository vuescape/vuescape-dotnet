

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

    using Xunit;

    using static System.FormattableString;

    [SuppressMessage("Microsoft.Maintainability", "CA1505:AvoidUnmaintainableCode", Justification = ObcSuppressBecause.CA1505_AvoidUnmaintainableCode_DisagreeWithAssessment)]
    public static partial class FeatureNavigationRegistrationTest
    {
        [SuppressMessage("Microsoft.Maintainability", "CA1505:AvoidUnmaintainableCode", Justification = ObcSuppressBecause.CA1505_AvoidUnmaintainableCode_DisagreeWithAssessment)]
        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        static FeatureNavigationRegistrationTest()
        {
            ConstructorArgumentValidationTestScenarios.RemoveAllScenarios()
            .AddScenario(() =>
                new ConstructorArgumentValidationTestScenario<FeatureNavigationRegistration>
                {
                    Name = "constructor should throw ArgumentNullException when parameter 'id' is null scenario",
                    ConstructionFunc = () =>
                    {
                        var referenceObject = A.Dummy<FeatureNavigationRegistration>();

                        var result = new FeatureNavigationRegistration(
                                             null,
                                             referenceObject.NavigationItems,
                                             referenceObject.FeatureId);

                        return result;
                    },
                    ExpectedExceptionType = typeof(ArgumentNullException),
                    ExpectedExceptionMessageContains = new[] { "id", },
                })
            .AddScenario(() =>
                new ConstructorArgumentValidationTestScenario<FeatureNavigationRegistration>
                {
                    Name = "constructor should throw ArgumentException when parameter 'id' is white space scenario",
                    ConstructionFunc = () =>
                    {
                        var referenceObject = A.Dummy<FeatureNavigationRegistration>();

                        var result = new FeatureNavigationRegistration(
                                             Invariant($"  {Environment.NewLine}  "),
                                             referenceObject.NavigationItems,
                                             referenceObject.FeatureId);

                        return result;
                    },
                    ExpectedExceptionType = typeof(ArgumentException),
                    ExpectedExceptionMessageContains = new[] { "id", "white space", },
                })
            .AddScenario(() =>
                new ConstructorArgumentValidationTestScenario<FeatureNavigationRegistration>
                {
                    Name = "constructor should throw ArgumentNullException when parameter 'navigationItems' is null scenario",
                    ConstructionFunc = () =>
                    {
                        var referenceObject = A.Dummy<FeatureNavigationRegistration>();

                        var result = new FeatureNavigationRegistration(
                                             referenceObject.Id,
                                             null,
                                             referenceObject.FeatureId);

                        return result;
                    },
                    ExpectedExceptionType = typeof(ArgumentNullException),
                    ExpectedExceptionMessageContains = new[] { "navigationItems", },
                })
            .AddScenario(() =>
                new ConstructorArgumentValidationTestScenario<FeatureNavigationRegistration>
                {
                    Name = "constructor should throw ArgumentException when parameter 'navigationItems' is an empty enumerable scenario",
                    ConstructionFunc = () =>
                    {
                        var referenceObject = A.Dummy<FeatureNavigationRegistration>();

                        var result = new FeatureNavigationRegistration(
                                             referenceObject.Id,
                                             new List<NavigationItemBase>(),
                                             referenceObject.FeatureId);

                        return result;
                    },
                    ExpectedExceptionType = typeof(ArgumentException),
                    ExpectedExceptionMessageContains = new[] { "navigationItems", "is an empty enumerable", },
                })
            .AddScenario(() =>
                new ConstructorArgumentValidationTestScenario<FeatureNavigationRegistration>
                {
                    Name = "constructor should throw ArgumentException when parameter 'navigationItems' contains a null element scenario",
                    ConstructionFunc = () =>
                    {
                        var referenceObject = A.Dummy<FeatureNavigationRegistration>();

                        var result = new FeatureNavigationRegistration(
                                             referenceObject.Id,
                                             new NavigationItemBase[0].Concat(referenceObject.NavigationItems).Concat(new NavigationItemBase[] { null }).Concat(referenceObject.NavigationItems).ToList(),
                                             referenceObject.FeatureId);

                        return result;
                    },
                    ExpectedExceptionType = typeof(ArgumentException),
                    ExpectedExceptionMessageContains = new[] { "navigationItems", "contains at least one null element", },
                });
        }
    }
}