

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
    public static partial class ActionMenuItemTest
    {
        [SuppressMessage("Microsoft.Maintainability", "CA1505:AvoidUnmaintainableCode", Justification = ObcSuppressBecause.CA1505_AvoidUnmaintainableCode_DisagreeWithAssessment)]
        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        static ActionMenuItemTest()
        {
            ConstructorArgumentValidationTestScenarios.RemoveAllScenarios()
                .AddScenario(() =>
                    new ConstructorArgumentValidationTestScenario<ActionMenuItem>
                    {
                        Name = "constructor should throw ArgumentNullException when parameter 'label' is null scenario",
                        ConstructionFunc = () =>
                        {
                            var referenceObject = A.Dummy<ActionMenuItem>();

                            var result = new ActionMenuItem(
                                null,
                                referenceObject.Action,
                                referenceObject.Icons,
                                referenceObject.IconPosition,
                                referenceObject.IsDisabled,
                                referenceObject.Tooltip,
                                referenceObject.Payload);

                            return result;
                        },
                        ExpectedExceptionType = typeof(ArgumentNullException),
                        ExpectedExceptionMessageContains = new[] { "label", },
                    })
                .AddScenario(() =>
                    new ConstructorArgumentValidationTestScenario<ActionMenuItem>
                    {
                        Name =
                            "constructor should throw ArgumentException when parameter 'label' is white space scenario",
                        ConstructionFunc = () =>
                        {
                            var referenceObject = A.Dummy<ActionMenuItem>();

                            var result = new ActionMenuItem(
                                Invariant($"  {Environment.NewLine}  "),
                                referenceObject.Action,
                                referenceObject.Icons,
                                referenceObject.IconPosition,
                                referenceObject.IsDisabled,
                                referenceObject.Tooltip,
                                referenceObject.Payload);

                            return result;
                        },
                        ExpectedExceptionType = typeof(ArgumentException),
                        ExpectedExceptionMessageContains = new[] { "label", "white space", },
                    });
        }
    }
}