// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UiObjectTest.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Vuescape.DotNet.Domain.Test
{
    using System;
    using System.Diagnostics.CodeAnalysis;

    using FakeItEasy;

    using OBeautifulCode.AutoFakeItEasy;
    using OBeautifulCode.CodeAnalysis.Recipes;
    using OBeautifulCode.CodeGen.ModelObject.Recipes;
    using OBeautifulCode.Equality.Recipes;

    [SuppressMessage("Microsoft.Maintainability", "CA1505:AvoidUnmaintainableCode", Justification = ObcSuppressBecause.CA1505_AvoidUnmaintainableCode_DisagreeWithAssessment)]
    public static partial class UiObjectTest
    {
        [SuppressMessage("Microsoft.Maintainability", "CA1505:AvoidUnmaintainableCode", Justification = ObcSuppressBecause.CA1505_AvoidUnmaintainableCode_DisagreeWithAssessment)]
        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        static UiObjectTest()
        {
            EquatableTestScenarios.RemoveAllScenarios()
            .AddScenario(() =>
                new EquatableTestScenario<UiObject>
                {
                    Name = "Default Code Generated Scenario",
                    ReferenceObject = ReferenceObjectForEquatableTestScenarios,
                    ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new UiObject[]
                    {
                        new UiObject(
                                ReferenceObjectForEquatableTestScenarios.Value,
                                (UiObjectType?)ReferenceObjectForEquatableTestScenarios.UiObjectType,
                                ReferenceObjectForEquatableTestScenarios.AssemblyQualifiedName),
                    },
                    ObjectsThatAreNotEqualToReferenceObject = new UiObject[]
                    {
                        new UiObject(
                                A.Dummy<UiObject>().Whose(_ => !_.Value.IsEqualTo(ReferenceObjectForEquatableTestScenarios.Value) && _.UiObjectType == ReferenceObjectForEquatableTestScenarios.UiObjectType && _.AssemblyQualifiedName == ReferenceObjectForEquatableTestScenarios.AssemblyQualifiedName).Value,
                                (UiObjectType?)ReferenceObjectForEquatableTestScenarios.UiObjectType,
                                ReferenceObjectForEquatableTestScenarios.AssemblyQualifiedName),
                    },
                    ObjectsThatAreNotOfTheSameTypeAsReferenceObject = new object[]
                    {
                        A.Dummy<object>(),
                        A.Dummy<string>(),
                        A.Dummy<int>(),
                        A.Dummy<int?>(),
                        A.Dummy<Guid>(),
                    },
                });

            DeepCloneWithTestScenarios.RemoveAllScenarios()
            .AddScenario(() =>
                new DeepCloneWithTestScenario<UiObject>
                {
                    Name = "DeepCloneWithValue should deep clone object and replace Value with the provided value",
                    WithPropertyName = "Value",
                    SystemUnderTestDeepCloneWithValueFunc = () =>
                    {
                        var systemUnderTest = A.Dummy<UiObject>();

                        var referenceObject = A.Dummy<UiObject>().ThatIs(_ => !systemUnderTest.Value.IsEqualTo(_.Value) && systemUnderTest.UiObjectType == _.UiObjectType);

                        var result = new SystemUnderTestDeepCloneWithValue<UiObject>
                        {
                            SystemUnderTest = systemUnderTest,
                            DeepCloneWithValue = referenceObject.Value,
                        };

                        return result;
                    },
                });

            ConstructorArgumentValidationTestScenarios.RemoveAllScenarios()
            .AddScenario(() =>
                new ConstructorArgumentValidationTestScenario<UiObject>
                {
                    Name = "constructor should throw ArgumentOutOfRangeException when parameter 'uiObjectType' is UiObjectType.None scenario",
                    ConstructionFunc = () =>
                    {
                        var result = new UiObject(
                                             null,
                                             UiObjectType.None,
                                             null);

                        return result;
                    },
                    ExpectedExceptionType = typeof(ArgumentOutOfRangeException),
                    ExpectedExceptionMessageContains = new[] { "uiObjectType", },
                })
            .AddScenario(() =>
                new ConstructorArgumentValidationTestScenario<UiObject>
                {
                    Name = "constructor should throw ArgumentNullException when parameter 'uiObjectType' is null and 'assemblyQualifiedName' is not null scenario",
                    ConstructionFunc = () =>
                    {
                        var result = new UiObject(
                                             null,
                                             null,
                                             A.Dummy<string>());

                        return result;
                    },
                    ExpectedExceptionType = typeof(ArgumentNullException),
                    ExpectedExceptionMessageContains = new[] { "uiObjectType", },
                })
            .AddScenario(() =>
                new ConstructorArgumentValidationTestScenario<UiObject>
                {
                    Name = "constructor should throw ArgumentNullException when parameter 'uiObjectType' is null and 'value' is null scenario",
                    ConstructionFunc = () =>
                    {
                        var result = new UiObject(
                                             null,
                                             null,
                                             null);

                        return result;
                    },
                    ExpectedExceptionType = typeof(ArgumentNullException),
                    ExpectedExceptionMessageContains = new[] { "uiObjectType", },
                })
            .AddScenario(() =>
                new ConstructorArgumentValidationTestScenario<UiObject>
                {
                    Name = "constructor should throw ArgumentOutOfRangeException when parameter 'value' is not null and parameter 'uiObjectType' does not match the type of the 'value' parameter scenario",
                    ConstructionFunc = () =>
                    {
                        var result = new UiObject(
                                             123,
                                             UiObjectType.Bool);

                        return result;
                    },
                    ExpectedExceptionType = typeof(ArgumentOutOfRangeException),
                    ExpectedExceptionMessageContains = new[] { "uiObjectType" },
                })
                .AddScenario(() =>
                new ConstructorArgumentValidationTestScenario<UiObject>
                {
                    Name = "constructor should throw ArgumentOutOfRangeException when parameter 'value' is not null and parameter 'uiObjectType' is not null and parameter 'assemblyQualifiedName' does not match the AssemblyQualifiedName of the 'value' parameter scenario",
                    ConstructionFunc = () =>
                    {
                        var result = new UiObject(
                            123,
                            UiObjectType.Int,
                            A.Dummy<string>());

                        return result;
                    },
                    ExpectedExceptionType = typeof(ArgumentOutOfRangeException),
                    ExpectedExceptionMessageContains = new[] { "assemblyQualifiedName" },
                });
        }
    }
}