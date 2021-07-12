// <copyright file="TreeTableRowTest.cs" company="Vuescape">
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
    using OBeautifulCode.Type;

    using Xunit;

    using static System.FormattableString;

    [SuppressMessage("Microsoft.Maintainability", "CA1505:AvoidUnmaintainableCode", Justification = ObcSuppressBecause.CA1505_AvoidUnmaintainableCode_DisagreeWithAssessment)]
    public static partial class TreeTableRowTest
    {
        [SuppressMessage("Microsoft.Maintainability", "CA1505:AvoidUnmaintainableCode", Justification = ObcSuppressBecause.CA1505_AvoidUnmaintainableCode_DisagreeWithAssessment)]
        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        static TreeTableRowTest()
        {
            ConstructorArgumentValidationTestScenarios.RemoveAllScenarios()
            .AddScenario(() =>
                new ConstructorArgumentValidationTestScenario<TreeTableRow>
                {
                    Name = "constructor should throw ArgumentNullException when parameter 'cells' is null scenario",
                    ConstructionFunc = () =>
                    {
                        var referenceObject = A.Dummy<TreeTableRow>();

                        var result = new TreeTableRow(
                                             referenceObject.Id,
                                             null,
                                             referenceObject.Depth,
                                             referenceObject.CssClasses,
                                             referenceObject.CssStyle,
                                             referenceObject.Renderer,
                                             referenceObject.IsExpandable,
                                             referenceObject.IsExpanded,
                                             referenceObject.IsVisible,
                                             referenceObject.IsSelected,
                                             referenceObject.IsFocused,
                                             referenceObject.Links,
                                             (IReadOnlyList<TreeTableRow>)referenceObject.Children);

                        return result;
                    },
                    ExpectedExceptionType = typeof(ArgumentNullException),
                    ExpectedExceptionMessageContains = new[] { "cells", },
                })
            .AddScenario(() =>
                new ConstructorArgumentValidationTestScenario<TreeTableRow>
                {
                    Name = "constructor should throw ArgumentException when parameter 'cells' is an empty enumerable scenario",
                    ConstructionFunc = () =>
                    {
                        var referenceObject = A.Dummy<TreeTableRow>();

                        var result = new TreeTableRow(
                                             referenceObject.Id,
                                             new List<TreeTableCell>(),
                                             referenceObject.Depth,
                                             referenceObject.CssClasses,
                                             referenceObject.CssStyle,
                                             referenceObject.Renderer,
                                             referenceObject.IsExpandable,
                                             referenceObject.IsExpanded,
                                             referenceObject.IsVisible,
                                             referenceObject.IsSelected,
                                             referenceObject.IsFocused,
                                             referenceObject.Links,
                                             (IReadOnlyList<TreeTableRow>)referenceObject.Children);

                        return result;
                    },
                    ExpectedExceptionType = typeof(ArgumentException),
                    ExpectedExceptionMessageContains = new[] { "cells", "is an empty enumerable", },
                });
        }
    }
}