

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
    public static partial class TableTabTest
    {
        [SuppressMessage("Microsoft.Maintainability", "CA1505:AvoidUnmaintainableCode", Justification = ObcSuppressBecause.CA1505_AvoidUnmaintainableCode_DisagreeWithAssessment)]
        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        static TableTabTest()
        {
            // A null table is valid when there is an onSelectAction to load the tab (a deferred tab),
            // so replace the generated 'table is null' scenario with one where both are null.
            ConstructorArgumentValidationTestScenarios.RemoveAllScenarios()
                .AddScenario(() =>
                    new ConstructorArgumentValidationTestScenario<TableTab>
                    {
                        Name = "constructor should throw ArgumentNullException when parameter 'id' is null scenario",
                        ConstructionFunc = () =>
                        {
                            var referenceObject = A.Dummy<TableTab>();

                            var result = new TableTab(
                                null,
                                referenceObject.Label,
                                referenceObject.Table,
                                referenceObject.Badge,
                                referenceObject.OnSelectAction);

                            return result;
                        },
                        ExpectedExceptionType = typeof(ArgumentNullException),
                        ExpectedExceptionMessageContains = new[] { "id", },
                    })
                .AddScenario(() =>
                    new ConstructorArgumentValidationTestScenario<TableTab>
                    {
                        Name = "constructor should throw ArgumentException when parameter 'id' is white space scenario",
                        ConstructionFunc = () =>
                        {
                            var referenceObject = A.Dummy<TableTab>();

                            var result = new TableTab(
                                Invariant($"  {Environment.NewLine}  "),
                                referenceObject.Label,
                                referenceObject.Table,
                                referenceObject.Badge,
                                referenceObject.OnSelectAction);

                            return result;
                        },
                        ExpectedExceptionType = typeof(ArgumentException),
                        ExpectedExceptionMessageContains = new[] { "id", "white space", },
                    })
                .AddScenario(() =>
                    new ConstructorArgumentValidationTestScenario<TableTab>
                    {
                        Name = "constructor should throw ArgumentNullException when parameter 'label' is null scenario",
                        ConstructionFunc = () =>
                        {
                            var referenceObject = A.Dummy<TableTab>();

                            var result = new TableTab(
                                referenceObject.Id,
                                null,
                                referenceObject.Table,
                                referenceObject.Badge,
                                referenceObject.OnSelectAction);

                            return result;
                        },
                        ExpectedExceptionType = typeof(ArgumentNullException),
                        ExpectedExceptionMessageContains = new[] { "label", },
                    })
                .AddScenario(() =>
                    new ConstructorArgumentValidationTestScenario<TableTab>
                    {
                        Name = "constructor should throw ArgumentException when parameter 'label' is white space scenario",
                        ConstructionFunc = () =>
                        {
                            var referenceObject = A.Dummy<TableTab>();

                            var result = new TableTab(
                                referenceObject.Id,
                                Invariant($"  {Environment.NewLine}  "),
                                referenceObject.Table,
                                referenceObject.Badge,
                                referenceObject.OnSelectAction);

                            return result;
                        },
                        ExpectedExceptionType = typeof(ArgumentException),
                        ExpectedExceptionMessageContains = new[] { "label", "white space", },
                    })
                .AddScenario(() =>
                    new ConstructorArgumentValidationTestScenario<TableTab>
                    {
                        Name = "constructor should throw ArgumentNullException when parameter 'table' is null and parameter 'onSelectAction' is null scenario",
                        ConstructionFunc = () =>
                        {
                            var referenceObject = A.Dummy<TableTab>();

                            var result = new TableTab(
                                referenceObject.Id,
                                referenceObject.Label,
                                null,
                                referenceObject.Badge,
                                null);

                            return result;
                        },
                        ExpectedExceptionType = typeof(ArgumentNullException),
                        ExpectedExceptionMessageContains = new[] { "onSelectAction", },
                    });
        }

        [Fact]
        public static void Constructor___Should_not_throw___When_parameter_table_is_null_and_parameter_onSelectAction_is_not_null()
        {
            // Arrange
            var referenceObject = A.Dummy<TableTab>();
            ActionBase selectAction = A.Dummy<NavigationAction>();

            // Act
            var actual = new TableTab(referenceObject.Id, referenceObject.Label, null, referenceObject.Badge, selectAction);

            // Assert
            actual.Table.AsTest().Must().BeNull();
            actual.OnSelectAction.AsTest().Must().BeSameReferenceAs(selectAction);
        }
    }
}