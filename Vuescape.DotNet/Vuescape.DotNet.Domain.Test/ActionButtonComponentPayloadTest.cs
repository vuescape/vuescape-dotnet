

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
    public static partial class ActionButtonComponentPayloadTest
    {
        [SuppressMessage("Microsoft.Maintainability", "CA1505:AvoidUnmaintainableCode", Justification = ObcSuppressBecause.CA1505_AvoidUnmaintainableCode_DisagreeWithAssessment)]
        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        static ActionButtonComponentPayloadTest()
        {
            ConstructorArgumentValidationTestScenarios.RemoveAllScenarios()
                .AddScenario(() =>
                    new ConstructorArgumentValidationTestScenario<ActionButtonComponentPayload>
                    {
                        Name = "constructor should throw ArgumentNullException when parameter 'id' is null scenario",
                        ConstructionFunc = () =>
                        {
                            var referenceObject = A.Dummy<ActionButtonComponentPayload>();

                            var result = new ActionButtonComponentPayload(
                                null,
                                referenceObject.Label,
                                referenceObject.Action,
                                referenceObject.Icons,
                                referenceObject.IconPosition);

                            return result;
                        },
                        ExpectedExceptionType = typeof(ArgumentNullException),
                        ExpectedExceptionMessageContains = new[] { "id", },
                    })
                .AddScenario(() =>
                    new ConstructorArgumentValidationTestScenario<ActionButtonComponentPayload>
                    {
                        Name = "constructor should throw ArgumentException when parameter 'id' is white space scenario",
                        ConstructionFunc = () =>
                        {
                            var referenceObject = A.Dummy<ActionButtonComponentPayload>();

                            var result = new ActionButtonComponentPayload(
                                Invariant($"  {Environment.NewLine}  "),
                                referenceObject.Label,
                                referenceObject.Action,
                                referenceObject.Icons,
                                referenceObject.IconPosition);

                            return result;
                        },
                        ExpectedExceptionType = typeof(ArgumentException),
                        ExpectedExceptionMessageContains = new[] { "id", "white space", },
                    })
                .AddScenario(() =>
                    new ConstructorArgumentValidationTestScenario<ActionButtonComponentPayload>
                    {
                        Name = "constructor should throw ArgumentNullException when parameter 'label' is null scenario",
                        ConstructionFunc = () =>
                        {
                            var referenceObject = A.Dummy<ActionButtonComponentPayload>();

                            var result = new ActionButtonComponentPayload(
                                referenceObject.Id,
                                null,
                                referenceObject.Action,
                                referenceObject.Icons,
                                referenceObject.IconPosition);

                            return result;
                        },
                        ExpectedExceptionType = typeof(ArgumentNullException),
                        ExpectedExceptionMessageContains = new[] { "label", },
                    })
                .AddScenario(() =>
                    new ConstructorArgumentValidationTestScenario<ActionButtonComponentPayload>
                    {
                        Name =
                            "constructor should throw ArgumentException when parameter 'label' is white space scenario",
                        ConstructionFunc = () =>
                        {
                            var referenceObject = A.Dummy<ActionButtonComponentPayload>();

                            var result = new ActionButtonComponentPayload(
                                referenceObject.Id,
                                Invariant($"  {Environment.NewLine}  "),
                                referenceObject.Action,
                                referenceObject.Icons,
                                referenceObject.IconPosition);

                            return result;
                        },
                        ExpectedExceptionType = typeof(ArgumentException),
                        ExpectedExceptionMessageContains = new[] { "label", "white space", },
                    });
        }
    }
}