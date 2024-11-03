
namespace Vuescape.DotNet.Domain.Test
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using FakeItEasy;
    using OBeautifulCode.CodeAnalysis.Recipes;
    using OBeautifulCode.CodeGen.ModelObject.Recipes;

    [SuppressMessage("Microsoft.Maintainability", "CA1505:AvoidUnmaintainableCode", Justification = ObcSuppressBecause.CA1505_AvoidUnmaintainableCode_DisagreeWithAssessment)]
    public static partial class ButtonComponentPayloadTest
    {
        [SuppressMessage("Microsoft.Maintainability", "CA1505:AvoidUnmaintainableCode", Justification = ObcSuppressBecause.CA1505_AvoidUnmaintainableCode_DisagreeWithAssessment)]
        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        static ButtonComponentPayloadTest()
        {
            ConstructorArgumentValidationTestScenarios
                .RemoveAllScenarios()
                .AddScenario(() =>
                    new ConstructorArgumentValidationTestScenario<ButtonComponentPayload>
                    {
                        Name =
                            "constructor should throw ArgumentNullException when parameter 'label' is null scenario",
                        ConstructionFunc = () =>
                        {
                            var referenceObject = A.Dummy<ButtonComponentPayload>();

                            var result = new ButtonComponentPayload(
                                null,
                                referenceObject.Action,
                                referenceObject.Icons);

                            return result;
                        },
                        ExpectedExceptionType = typeof(ArgumentNullException),
                        ExpectedExceptionMessageContains = new[] { "label", },
                    })
                .AddScenario(() =>
                    new ConstructorArgumentValidationTestScenario<ButtonComponentPayload>
                    {
                        Name =
                            "constructor should throw ArgumentNullException when parameter 'action' is null scenario",
                        ConstructionFunc = () =>
                        {
                            var referenceObject = A.Dummy<ButtonComponentPayload>();

                            var result = new ButtonComponentPayload(
                                referenceObject.Label,
                                null,
                                referenceObject.Icons);

                            return result;
                        },
                        ExpectedExceptionType = typeof(ArgumentNullException),
                        ExpectedExceptionMessageContains = new[] { "action", },
                    })
                .AddScenario(() =>
                    new ConstructorArgumentValidationTestScenario<ButtonComponentPayload>
                    {
                        Name =
                            "constructor should throw ArgumentException when parameter 'icons' contains a null element scenario",
                        ConstructionFunc = () =>
                        {
                            var referenceObject = A.Dummy<ButtonComponentPayload>();

                            var result = new ButtonComponentPayload(
                                referenceObject.Label,
                                referenceObject.Action,
                                new string[0].Concat(referenceObject.Icons).Concat(new string[] { null })
                                    .Concat(referenceObject.Icons).ToList());

                            return result;
                        },
                        ExpectedExceptionType = typeof(ArgumentException),
                        ExpectedExceptionMessageContains = new[] { "icons", "contains at least one null element", },
                    });
        }
    }
}
