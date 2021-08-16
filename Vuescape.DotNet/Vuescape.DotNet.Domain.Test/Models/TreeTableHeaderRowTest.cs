// <copyright file="TreeTableHeaderRowTest.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>

namespace Vuescape.DotNet.Domain.Test
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;

    using FakeItEasy;

    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.AutoFakeItEasy;
    using OBeautifulCode.CodeAnalysis.Recipes;
    using OBeautifulCode.CodeGen.ModelObject.Recipes;
    using OBeautifulCode.Math.Recipes;

    using Xunit;

    using static System.FormattableString;

    [SuppressMessage("Microsoft.Maintainability", "CA1505:AvoidUnmaintainableCode", Justification = ObcSuppressBecause.CA1505_AvoidUnmaintainableCode_DisagreeWithAssessment)]
    public static partial class TreeTableHeaderRowTest
    {
        [SuppressMessage("Microsoft.Maintainability", "CA1505:AvoidUnmaintainableCode", Justification = ObcSuppressBecause.CA1505_AvoidUnmaintainableCode_DisagreeWithAssessment)]
        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        static TreeTableHeaderRowTest()
        {
            ConstructorArgumentValidationTestScenarios.RemoveAllScenarios()
            .AddScenario(() =>
                new ConstructorArgumentValidationTestScenario<TreeTableHeaderRow>
                {
                    Name = "constructor should throw ArgumentNullException when parameter 'cells' is null scenario",
                    ConstructionFunc = () =>
                    {
                        var referenceObject = A.Dummy<TreeTableHeaderRow>();

                        var result = new TreeTableHeaderRow(
                                             referenceObject.Id,
                                             null,
                                             referenceObject.CssClasses,
                                             referenceObject.CssStyles,
                                             referenceObject.Renderer);

                        return result;
                    },
                    ExpectedExceptionType = typeof(ArgumentNullException),
                    ExpectedExceptionMessageContains = new[] { "cells", },
                })
            .AddScenario(() =>
                new ConstructorArgumentValidationTestScenario<TreeTableHeaderRow>
                {
                    Name = "constructor should throw ArgumentException when parameter 'cells' is an empty enumerable scenario",
                    ConstructionFunc = () =>
                    {
                        var referenceObject = A.Dummy<TreeTableHeaderRow>();

                        var result = new TreeTableHeaderRow(
                                             referenceObject.Id,
                                             new List<TreeTableHeaderCell>(),
                                             referenceObject.CssClasses,
                                             referenceObject.CssStyles,
                                             referenceObject.Renderer);

                        return result;
                    },
                    ExpectedExceptionType = typeof(ArgumentException),
                    ExpectedExceptionMessageContains = new[] { "cells", "is an empty enumerable", },
                });
        }
    }
}