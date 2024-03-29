﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SlottedUiObjectTest.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Vuescape.DotNet.Domain.Test
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    using FakeItEasy;

    using OBeautifulCode.CodeAnalysis.Recipes;
    using OBeautifulCode.CodeGen.ModelObject.Recipes;

    [SuppressMessage("Microsoft.Maintainability", "CA1505:AvoidUnmaintainableCode", Justification = ObcSuppressBecause.CA1505_AvoidUnmaintainableCode_DisagreeWithAssessment)]
    public static partial class SlottedUiObjectTest
    {
        [SuppressMessage("Microsoft.Maintainability", "CA1505:AvoidUnmaintainableCode", Justification = ObcSuppressBecause.CA1505_AvoidUnmaintainableCode_DisagreeWithAssessment)]
        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        static SlottedUiObjectTest()
        {
            ConstructorArgumentValidationTestScenarios.RemoveAllScenarios()
            .AddScenario(() =>
                new ConstructorArgumentValidationTestScenario<SlottedUiObject>
                {
                    Name = "constructor should throw ArgumentOutOfRangeException when parameter 'defaultSlot' is null and parameter 'slotNameToUiObjectMap' is not null scenario",
                    ConstructionFunc = () =>
                    {
                        var result = new SlottedUiObject(
                                             new Dictionary<string, UiObject>(),
                                             null);

                        return result;
                    },
                    ExpectedExceptionType = typeof(ArgumentException),
                    ExpectedExceptionMessageContains = new[] { "slotNameToUiObjectMap", },
                })
            .AddScenario(() =>
                new ConstructorArgumentValidationTestScenario<SlottedUiObject>
                {
                    Name = "constructor should throw ArgumentNullException when parameter 'slotNameToUiObjectMap' is null scenario",
                    ConstructionFunc = () =>
                    {
                        var referenceObject = A.Dummy<SlottedUiObject>();

                        var result = new SlottedUiObject(
                            null,
                            referenceObject.DefaultSlotName);

                        return result;
                    },
                    ExpectedExceptionType = typeof(ArgumentNullException),
                    ExpectedExceptionMessageContains = new[] { "slotNameToUiObjectMap" },
                })
            .AddScenario(() =>
                new ConstructorArgumentValidationTestScenario<SlottedUiObject>
                {
                    Name = "constructor should throw ArgumentException when parameter 'slotNameToUiObjectMap' is an empty dictionary scenario",
                    ConstructionFunc = () =>
                    {
                        var referenceObject = A.Dummy<SlottedUiObject>();

                        var result = new SlottedUiObject(
                                             new Dictionary<string, UiObject>(),
                                             referenceObject.DefaultSlotName);

                        return result;
                    },
                    ExpectedExceptionType = typeof(ArgumentException),
                    ExpectedExceptionMessageContains = new[] { "slotNameToUiObjectMap", "is an empty dictionary", },
                });
        }
    }
}