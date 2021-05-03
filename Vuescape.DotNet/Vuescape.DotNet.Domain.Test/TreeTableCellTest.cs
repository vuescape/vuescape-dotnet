

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
    public static partial class TreeTableCellTest
    {
        [SuppressMessage("Microsoft.Maintainability", "CA1505:AvoidUnmaintainableCode", Justification = ObcSuppressBecause.CA1505_AvoidUnmaintainableCode_DisagreeWithAssessment)]
        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        static TreeTableCellTest()
        {
            ConstructorArgumentValidationTestScenarios.RemoveAllScenarios()
                .AddScenario(() =>
                    new ConstructorArgumentValidationTestScenario<TreeTableCell>
                    {
                        Name = "constructor should throw ArgumentNullException when parameter 'id' is null scenario",
                        ConstructionFunc = () =>
                        {
                            var referenceObject = A.Dummy<TreeTableCell>();

                            var result = new TreeTableCell(
                                                 null,
                                                 referenceObject.CssClasses,
                                                 referenceObject.Colspan,
                                                 referenceObject.Hover,
                                                 referenceObject.IsVisible,
                                                 referenceObject.Renderer,
                                                 referenceObject.DisplayValue,
                                                 referenceObject.Value,
                                                 referenceObject.Links);

                            return result;
                        },
                        ExpectedExceptionType = typeof(ArgumentNullException),
                        ExpectedExceptionMessageContains = new[] { "id", },
                    })
                .AddScenario(() =>
                    new ConstructorArgumentValidationTestScenario<TreeTableCell>
                    {
                        Name = "constructor should throw ArgumentException when parameter 'id' is white space scenario",
                        ConstructionFunc = () =>
                        {
                            var referenceObject = A.Dummy<TreeTableCell>();

                            var result = new TreeTableCell(
                                                 Invariant($"  {Environment.NewLine}  "),
                                                 referenceObject.CssClasses,
                                                 referenceObject.Colspan,
                                                 referenceObject.Hover,
                                                 referenceObject.IsVisible,
                                                 referenceObject.Renderer,
                                                 referenceObject.DisplayValue,
                                                 referenceObject.Value,
                                                 referenceObject.Links);

                            return result;
                        },
                        ExpectedExceptionType = typeof(ArgumentException),
                        ExpectedExceptionMessageContains = new[] { "id", "white space", },
                    });
        }
    }
}