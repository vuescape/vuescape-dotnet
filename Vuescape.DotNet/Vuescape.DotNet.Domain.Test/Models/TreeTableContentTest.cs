// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TreeTableContentTest.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Vuescape.DotNet.Domain.Test
{
    using System;
    using System.Diagnostics.CodeAnalysis;

    using FakeItEasy;

    using OBeautifulCode.CodeAnalysis.Recipes;
    using OBeautifulCode.CodeGen.ModelObject.Recipes;

    [SuppressMessage("Microsoft.Maintainability", "CA1505:AvoidUnmaintainableCode", Justification = ObcSuppressBecause.CA1505_AvoidUnmaintainableCode_DisagreeWithAssessment)]
    public static partial class TreeTableContentTest
    {
        [SuppressMessage("Microsoft.Maintainability", "CA1505:AvoidUnmaintainableCode", Justification = ObcSuppressBecause.CA1505_AvoidUnmaintainableCode_DisagreeWithAssessment)]
        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        static TreeTableContentTest()
        {
            ConstructorArgumentValidationTestScenarios.RemoveAllScenarios()
            .AddScenario(() =>
                new ConstructorArgumentValidationTestScenario<TreeTableContent>
                {
                    Name = "constructor should throw ArgumentNullException when parameter 'rows' is null scenario",
                    ConstructionFunc = () =>
                    {
                        var referenceObject = A.Dummy<TreeTableContent>();

                        var result = new TreeTableContent(
                                             referenceObject.Headers,
                                             null,
                                             referenceObject.Footers,
                                             referenceObject.ShouldScrollVertical,
                                             referenceObject.ShouldScrollHorizontal,
                                             referenceObject.ShouldSyncHeaderScroll,
                                             referenceObject.ShouldSyncFooterScroll,
                                             referenceObject.ShouldIncludeFooter,
                                             referenceObject.ShouldFreezeFirstColumn,
                                             referenceObject.DeadAreaColor,
                                             referenceObject.MaxRows,
                                             referenceObject.CssClass,
                                             referenceObject.CssStyles,
                                             referenceObject.SortLevel);

                        return result;
                    },
                    ExpectedExceptionType = typeof(ArgumentNullException),
                    ExpectedExceptionMessageContains = new[] { "rows", },
                });
        }
    }
}