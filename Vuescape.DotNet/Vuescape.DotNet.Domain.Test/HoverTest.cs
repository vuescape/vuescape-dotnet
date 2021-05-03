

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
    public static partial class HoverTest
    {
        [SuppressMessage("Microsoft.Maintainability", "CA1505:AvoidUnmaintainableCode", Justification = ObcSuppressBecause.CA1505_AvoidUnmaintainableCode_DisagreeWithAssessment)]
        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        static HoverTest()
        {
            ConstructorArgumentValidationTestScenarios.RemoveAllScenarios()
                .AddScenario(() =>
                    new ConstructorArgumentValidationTestScenario<Hover>
                    {
                        Name = "constructor should throw ArgumentNullException when parameter 'component' is null scenario",
                        ConstructionFunc = () =>
                        {
                            var referenceObject = A.Dummy<Hover>();

                            var result = new Hover(
                                                 null,
                                                 referenceObject.Html,
                                                 referenceObject.Text,
                                                 referenceObject.Title);

                            return result;
                        },
                        ExpectedExceptionType = typeof(ArgumentNullException),
                        ExpectedExceptionMessageContains = new[] { "component", },
                    })
                .AddScenario(() =>
                    new ConstructorArgumentValidationTestScenario<Hover>
                    {
                        Name = "constructor should throw ArgumentException when parameter 'component' is white space scenario",
                        ConstructionFunc = () =>
                        {
                            var referenceObject = A.Dummy<Hover>();

                            var result = new Hover(
                                                 Invariant($"  {Environment.NewLine}  "),
                                                 referenceObject.Html,
                                                 referenceObject.Text,
                                                 referenceObject.Title);

                            return result;
                        },
                        ExpectedExceptionType = typeof(ArgumentException),
                        ExpectedExceptionMessageContains = new[] { "component", "white space", },
                    });
        }
    }
}