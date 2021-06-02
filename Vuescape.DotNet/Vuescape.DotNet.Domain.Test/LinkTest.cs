

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
    public static partial class LinkTest
    {
        [SuppressMessage("Microsoft.Maintainability", "CA1505:AvoidUnmaintainableCode", Justification = ObcSuppressBecause.CA1505_AvoidUnmaintainableCode_DisagreeWithAssessment)]
        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        static LinkTest()
        {
            ConstructorArgumentValidationTestScenarios.RemoveAllScenarios()
                            .AddScenario(() =>
                new ConstructorArgumentValidationTestScenario<Link>
                {
                    Name = "constructor should throw ArgumentNullException when parameter 'source' is null scenario",
                    ConstructionFunc = () =>
                    {
                        var referenceObject = A.Dummy<Link>();

                        var result = new Link(
                                             null,
                                             referenceObject.LinkTarget,
                                             referenceObject.Title,
                                             referenceObject.ActivatedCssStyles);

                        return result;
                    },
                    ExpectedExceptionType = typeof(ArgumentNullException),
                    ExpectedExceptionMessageContains = new[] { "source", },
                })
            .AddScenario(() =>
                new ConstructorArgumentValidationTestScenario<Link>
                {
                    Name = "constructor should throw ArgumentException when parameter 'source' is white space scenario",
                    ConstructionFunc = () =>
                    {
                        var referenceObject = A.Dummy<Link>();

                        var result = new Link(
                                             Invariant($"  {Environment.NewLine}  "),
                                             referenceObject.LinkTarget,
                                             referenceObject.Title,
                                             referenceObject.ActivatedCssStyles);

                        return result;
                    },
                    ExpectedExceptionType = typeof(ArgumentException),
                    ExpectedExceptionMessageContains = new[] { "source", "white space", },
                });
        }
    }
}