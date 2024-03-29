﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ObcToVuescapeConversionContextTest.cs" company="Vuescape">
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
    public static partial class ObcToVuescapeConversionContextTest
    {
        [SuppressMessage("Microsoft.Maintainability", "CA1505:AvoidUnmaintainableCode", Justification = ObcSuppressBecause.CA1505_AvoidUnmaintainableCode_DisagreeWithAssessment)]
        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        static ObcToVuescapeConversionContextTest()
        {
            ConstructorArgumentValidationTestScenarios.RemoveAllScenarios()
                .AddScenario(() =>
                    new ConstructorArgumentValidationTestScenario<ObcToVuescapeConversionContext>
                    {
                        Name = "constructor should throw ArgumentOutOfRangeException when parameter 'reportConversionMode' is 'None' scenario",
                        ConstructionFunc = () =>
                        {
                            var referenceObject = A.Dummy<ObcToVuescapeConversionContext>();

                            var result = new ObcToVuescapeConversionContext(
                                ReportConversionMode.None,
                                referenceObject.QueryString,
                                referenceObject.BaseUrlToken,
                                referenceObject.BaseUrl,
                                referenceObject.CultureKind,
                                referenceObject.LocalTimeZone);

                            return result;
                        },
                        ExpectedExceptionType = typeof(ArgumentOutOfRangeException),
                        ExpectedExceptionMessageContains = new[] { "reportConversionMode", },
                    });
        }
    }
}