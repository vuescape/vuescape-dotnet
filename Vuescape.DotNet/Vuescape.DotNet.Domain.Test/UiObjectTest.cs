// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UiObjectTest.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Vuescape.DotNet.Domain.Test
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;

    using FakeItEasy;

    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.AutoFakeItEasy;
    using OBeautifulCode.CodeAnalysis.Recipes;
    using OBeautifulCode.CodeGen.ModelObject.Recipes;
    using OBeautifulCode.Equality.Recipes;
    using OBeautifulCode.Math.Recipes;

    using Xunit;

    [SuppressMessage("Microsoft.Maintainability", "CA1505:AvoidUnmaintainableCode", Justification = ObcSuppressBecause.CA1505_AvoidUnmaintainableCode_DisagreeWithAssessment)]
    public static partial class UiObjectTest
    {
        [SuppressMessage("Microsoft.Maintainability", "CA1505:AvoidUnmaintainableCode", Justification = ObcSuppressBecause.CA1505_AvoidUnmaintainableCode_DisagreeWithAssessment)]
        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        static UiObjectTest()
        {
            EquatableTestScenarios
                .RemoveAllScenarios()
                .AddScenario(() =>
                {
                    var referenceObjectForEquatableTestScenarios = new UiObject(null);

                    var result = new EquatableTestScenario<UiObject>
                    {
                        Name = "Null Value Scenario",
                        ReferenceObject = referenceObjectForEquatableTestScenarios,
                        ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new UiObject[]
                        {
                            new UiObject(
                                referenceObjectForEquatableTestScenarios.Value,
                                referenceObjectForEquatableTestScenarios.UiObjectType,
                                referenceObjectForEquatableTestScenarios.AssemblyQualifiedName),
                        },
                        ObjectsThatAreNotEqualToReferenceObject = new UiObject[]
                        {
                        },
                        ObjectsThatAreNotOfTheSameTypeAsReferenceObject = new object[]
                        {
                            A.Dummy<object>(),
                            A.Dummy<string>(),
                            A.Dummy<int>(),
                            A.Dummy<int?>(),
                            A.Dummy<Guid>(),
                        },
                    };

                    return result;
                })
                .AddScenario(() =>
                {
                    var referenceObjectForEquatableTestScenarios = A.Dummy<UiObject>().Whose(_ => (_.Value != null) && (!_.UiObjectType.RequiresAssemblyQualifiedName()));

                    var result = new EquatableTestScenario<UiObject>
                    {
                        Name = "Well-Known Type Scenario",
                        ReferenceObject = referenceObjectForEquatableTestScenarios,
                        ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new[]
                        {
                            new UiObject(
                                referenceObjectForEquatableTestScenarios.Value,
                                referenceObjectForEquatableTestScenarios.UiObjectType,
                                referenceObjectForEquatableTestScenarios.AssemblyQualifiedName),
                        },
                        ObjectsThatAreNotEqualToReferenceObject = new[]
                        {
                            new UiObject(
                                A.Dummy<UiObject>().Whose(_=> (_.Value != null) && (!_.UiObjectType.RequiresAssemblyQualifiedName()) && (!_.Value.IsEqualTo(referenceObjectForEquatableTestScenarios.Value))).Value,
                                referenceObjectForEquatableTestScenarios.UiObjectType,
                                referenceObjectForEquatableTestScenarios.AssemblyQualifiedName),
                            new UiObject(
                                referenceObjectForEquatableTestScenarios.Value,
                                A.Dummy<UiObject>().Whose(_=> (_.Value != null) && (!_.UiObjectType.RequiresAssemblyQualifiedName()) && (_.UiObjectType != referenceObjectForEquatableTestScenarios.UiObjectType)).UiObjectType,
                                referenceObjectForEquatableTestScenarios.AssemblyQualifiedName),
                        },
                        ObjectsThatAreNotOfTheSameTypeAsReferenceObject = new object[]
                        {
                            A.Dummy<object>(),
                            A.Dummy<string>(),
                            A.Dummy<int>(),
                            A.Dummy<int?>(),
                            A.Dummy<Guid>(),
                        },
                    };

                    return result;
                })
                .AddScenario(() =>
                {
                    var referenceObjectForEquatableTestScenarios = A.Dummy<UiObject>().Whose(_ => (_.Value != null) && _.UiObjectType.RequiresAssemblyQualifiedName());

                    var result = new EquatableTestScenario<UiObject>
                    {
                        Name = "Well-Known Type Scenario",
                        ReferenceObject = referenceObjectForEquatableTestScenarios,
                        ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new UiObject[]
                        {
                            new UiObject(
                                referenceObjectForEquatableTestScenarios.Value,
                                referenceObjectForEquatableTestScenarios.UiObjectType,
                                referenceObjectForEquatableTestScenarios.AssemblyQualifiedName),
                        },
                        ObjectsThatAreNotEqualToReferenceObject = new UiObject[]
                        {
                            new UiObject(
                                A.Dummy<UiObject>().Whose(_=> (_.Value != null) && _.UiObjectType.RequiresAssemblyQualifiedName() && (!_.Value.IsEqualTo(referenceObjectForEquatableTestScenarios.Value))).Value,
                                referenceObjectForEquatableTestScenarios.UiObjectType,
                                referenceObjectForEquatableTestScenarios.AssemblyQualifiedName),
                            new UiObject(
                                referenceObjectForEquatableTestScenarios.Value,
                                A.Dummy<UiObject>().Whose(_=> (_.Value != null) && _.UiObjectType.RequiresAssemblyQualifiedName() && (_.UiObjectType != referenceObjectForEquatableTestScenarios.UiObjectType)).UiObjectType,
                                referenceObjectForEquatableTestScenarios.AssemblyQualifiedName),
                            new UiObject(
                                referenceObjectForEquatableTestScenarios.Value,
                                referenceObjectForEquatableTestScenarios.UiObjectType,
                                A.Dummy<UiObject>().Whose(_=> (_.Value != null) && _.UiObjectType.RequiresAssemblyQualifiedName() && (_.AssemblyQualifiedName != referenceObjectForEquatableTestScenarios.AssemblyQualifiedName)).AssemblyQualifiedName),
                        },
                        ObjectsThatAreNotOfTheSameTypeAsReferenceObject = new object[]
                        {
                            A.Dummy<object>(),
                            A.Dummy<string>(),
                            A.Dummy<int>(),
                            A.Dummy<int?>(),
                            A.Dummy<Guid>(),
                        },
                    };

                    return result;
                });

            DeepCloneWithTestScenarios
                .RemoveAllScenarios()
                .AddScenario(() =>
                    new DeepCloneWithTestScenario<UiObject>
                    {
                        Name = "DeepCloneWithValue should deep clone object and replace Value with the provided value",
                        WithPropertyName = "Value",
                        SystemUnderTestDeepCloneWithValueFunc = () =>
                        {
                            var systemUnderTest = A.Dummy<UiObject>().Whose(_ => _.UiObjectType != null);

                            var referenceObject = A.Dummy<UiObject>().ThatIs(_ => !systemUnderTest.Value.IsEqualTo(_.Value));

                            var result = new SystemUnderTestDeepCloneWithValue<UiObject>
                            {
                                SystemUnderTest = systemUnderTest,
                                DeepCloneWithValue = referenceObject.Value,
                            };

                            return result;
                        },
                    })
                .AddScenario(() =>
                    new DeepCloneWithTestScenario<UiObject>
                    {
                        Name = "DeepCloneWithValue should deep clone object and replace AssemblyQualifiedName with the provided assemblyQualifiedName",
                        WithPropertyName = "AssemblyQualifiedName",
                        SystemUnderTestDeepCloneWithValueFunc = () =>
                        {
                            var systemUnderTest = A.Dummy<UiObject>().Whose(_ => _.UiObjectType.RequiresAssemblyQualifiedName());

                            var referenceObject = A.Dummy<UiObject>().ThatIs(_ => _.UiObjectType.RequiresAssemblyQualifiedName() && (!systemUnderTest.AssemblyQualifiedName.IsEqualTo(_.AssemblyQualifiedName)));

                            var result = new SystemUnderTestDeepCloneWithValue<UiObject>
                            {
                                SystemUnderTest = systemUnderTest,
                                DeepCloneWithValue = referenceObject.AssemblyQualifiedName,
                            };

                            return result;
                        },
                    });

            ConstructorArgumentValidationTestScenarios
                .RemoveAllScenarios()
                .AddScenario(() =>
                    new ConstructorArgumentValidationTestScenario<UiObject>
                    {
                        Name = "constructor should throw ArgumentException when parameter 'value' is null and parameter 'uiObjectType' is not null",
                        ConstructionFunc = () =>
                        {
                            var result = new UiObject(
                                                 null,
                                                 A.Dummy<UiObjectType>(),
                                                 null);

                            return result;
                        },
                        ExpectedExceptionType = typeof(ArgumentException),
                        ExpectedExceptionMessageEquals = "value is null but uiObjectType is not null.",
                    })
                .AddScenario(() =>
                    new ConstructorArgumentValidationTestScenario<UiObject>
                    {
                        Name = "constructor should throw ArgumentException when parameter 'value' is not null and parameter 'uiObjectType' is null",
                        ConstructionFunc = () =>
                        {
                            var result = new UiObject(
                                A.Dummy<object>(),
                                null,
                                null);

                            return result;
                        },
                        ExpectedExceptionType = typeof(ArgumentException),
                        ExpectedExceptionMessageEquals = "value is not null but uiObjectType is null.",
                    })
                .AddScenario(() =>
                    new ConstructorArgumentValidationTestScenario<UiObject>
                    {
                        Name = "constructor should throw ArgumentException when parameter 'assemblyQualifiedName' is null and parameter 'uiObjectType' is either Enum or SpecifiedType",
                        ConstructionFunc = () =>
                        {
                            var uiObjectTypes = new[] { UiObjectType.Enum, UiObjectType.SpecifiedType };

                            var uiObjectType = uiObjectTypes[ThreadSafeRandom.Next(0, 2)];

                            var result = new UiObject(
                                A.Dummy<object>(),
                                uiObjectType,
                                null);

                            return result;
                        },
                        ExpectedExceptionType = typeof(ArgumentException),
                        ExpectedExceptionMessageEquals = "assemblyQualifiedName is expected when uiObjectType is in this set: [Enum, SpecifiedType].",
                    })
                .AddScenario(() =>
                    new ConstructorArgumentValidationTestScenario<UiObject>
                    {
                        Name = "constructor should throw ArgumentException when parameter 'assemblyQualifiedName' is white space and parameter 'uiObjectType' is either Enum or SpecifiedType",
                        ConstructionFunc = () =>
                        {
                            var uiObjectTypes = new[] { UiObjectType.Enum, UiObjectType.SpecifiedType };

                            var uiObjectType = uiObjectTypes[ThreadSafeRandom.Next(0, 2)];

                            var result = new UiObject(
                                A.Dummy<object>(),
                                uiObjectType,
                                "   \r\n  ");

                            return result;
                        },
                        ExpectedExceptionType = typeof(ArgumentException),
                        ExpectedExceptionMessageEquals = "assemblyQualifiedName is expected when uiObjectType is in this set: [Enum, SpecifiedType].",
                    });
        }

        [Fact]
        public static void Constructor___Should_set_all_properties_to_null___When_value_is_null()
        {
            // Arrange, Act
            var actual = new UiObject(null);

            // Assert
            actual.AssemblyQualifiedName.AsTest().Must().BeNull();
            actual.UiObjectType.AsTest().Must().BeNull();
            actual.Value.AsTest().Must().BeNull();
        }

        [Fact]
        public static void Constructor___Should_create_expected_object___When_value_is_not_null_and_a_well_known_type()
        {
            // Arrange
            var values = new object[]
            {
                A.Dummy<bool>(),
                A.Dummy<DateTime>(),
                A.Dummy<decimal>(),
                A.Dummy<Guid>(),
                A.Dummy<int>(),
                A.Dummy<long>(),
                A.Dummy<short>(),
                A.Dummy<string>(),
            };

            var expectedUiObjectType = new UiObjectType?[]
            {
                UiObjectType.Bool,
                UiObjectType.DateTime,
                UiObjectType.Decimal,
                UiObjectType.Guid,
                UiObjectType.Int,
                UiObjectType.Long,
                UiObjectType.Short,
                UiObjectType.String,
            };

            // Act
            var actual = values.Select(_ => new UiObject(_)).ToList();

            // Assert
            actual.Select(_ => _.AssemblyQualifiedName).AsTest().Must().Each().BeNull();
            actual.Select(_ => _.Value).ToArray().AsTest().Must().BeEqualTo(values);
            actual.Select(_ => _.UiObjectType).ToArray().AsTest().Must().BeEqualTo(expectedUiObjectType);
        }

        [Fact]
        public static void Constructor___Should_create_expected_object___When_value_is_not_null_and_not_a_well_known_type()
        {
            // Arrange
            var values = new object[]
            {
                A.Dummy<UiObjectType>(),
                A.Dummy<Link>(),
            };

            var expectedUiObjectType = new UiObjectType?[]
            {
                UiObjectType.Enum,
                UiObjectType.SpecifiedType,
            };

            var expectedAssemblyQualifiedName = new[]
            {
                "Vuescape.DotNet.Domain.UiObjectType, Vuescape.DotNet.Domain",
                "Vuescape.DotNet.Domain.Link, Vuescape.DotNet.Domain",
            };

            // Act
            var actual = values.Select(_ => new UiObject(_)).ToList();

            // Assert
            actual.Select(_ => _.AssemblyQualifiedName).ToArray().AsTest().Must().BeEqualTo(expectedAssemblyQualifiedName);
            actual.Select(_ => _.Value).ToArray().AsTest().Must().BeEqualTo(values);
            actual.Select(_ => _.UiObjectType).ToArray().AsTest().Must().BeEqualTo(expectedUiObjectType);
        }
    }
}