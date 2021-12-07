// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConvertObcToVuescapeTreeTableOpTest.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

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
    public static partial class ConvertObcToVuescapeTreeTableOpTest
    {
        [SuppressMessage("Microsoft.Maintainability", "CA1505:AvoidUnmaintainableCode", Justification = ObcSuppressBecause.CA1505_AvoidUnmaintainableCode_DisagreeWithAssessment)]
        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        static ConvertObcToVuescapeTreeTableOpTest()
        {
            ConstructorArgumentValidationTestScenarios.RemoveAllScenarios()
                            .AddScenario(() =>
                new ConstructorArgumentValidationTestScenario<ConvertObcToVuescapeTreeTableOp>
                {
                    Name = "constructor should throw ArgumentNullException when parameter 'obcTreeTable' is null scenario",
                    ConstructionFunc = () =>
                    {
                        var referenceObject = A.Dummy<ConvertObcToVuescapeTreeTableOp>();

                        var result = new ConvertObcToVuescapeTreeTableOp(
                                             null,
                                             referenceObject.TreeTableConversionMode,
                                             referenceObject.TokenToSubstitutionMap);

                        return result;
                    },
                    ExpectedExceptionType = typeof(ArgumentNullException),
                    ExpectedExceptionMessageContains = new[] { "obcTreeTable", },
                });
        }
    }
}