

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
    public static partial class TreeTableHeaderCellTest
    {
        [SuppressMessage("Microsoft.Maintainability", "CA1505:AvoidUnmaintainableCode", Justification = ObcSuppressBecause.CA1505_AvoidUnmaintainableCode_DisagreeWithAssessment)]
        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        static TreeTableHeaderCellTest()
        {
            ConstructorArgumentValidationTestScenarios.RemoveAllScenarios()
                .AddScenario(() =>
                    new ConstructorArgumentValidationTestScenario<TreeTableHeaderCell>
                    {
                        Name = "constructor should throw ArgumentNullException when parameter 'id' is null scenario",
                        ConstructionFunc = () =>
                        {
                            var referenceObject = A.Dummy<TreeTableHeaderCell>();

                            var result = new TreeTableHeaderCell(
                                                 null,
                                                 referenceObject.CssClasses,
                                                 referenceObject.Colspan,
                                                 referenceObject.ColumnSorter,
                                                 referenceObject.Renderer,
                                                 referenceObject.DisplayValue);

                            return result;
                        },
                        ExpectedExceptionType = typeof(ArgumentNullException),
                        ExpectedExceptionMessageContains = new[] { "id", },
                    })
                .AddScenario(() =>
                    new ConstructorArgumentValidationTestScenario<TreeTableHeaderCell>
                    {
                        Name = "constructor should throw ArgumentException when parameter 'id' is white space scenario",
                        ConstructionFunc = () =>
                        {
                            var referenceObject = A.Dummy<TreeTableHeaderCell>();

                            var result = new TreeTableHeaderCell(
                                                 Invariant($"  {Environment.NewLine}  "),
                                                 referenceObject.CssClasses,
                                                 referenceObject.Colspan,
                                                 referenceObject.ColumnSorter,
                                                 referenceObject.Renderer,
                                                 referenceObject.DisplayValue);

                            return result;
                        },
                        ExpectedExceptionType = typeof(ArgumentException),
                        ExpectedExceptionMessageContains = new[] { "id", "white space", },
                    });
        }
    }
}