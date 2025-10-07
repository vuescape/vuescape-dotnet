

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
    public static partial class ActionButtonComponentPayloadTest
    {
        [SuppressMessage("Microsoft.Maintainability", "CA1505:AvoidUnmaintainableCode", Justification = ObcSuppressBecause.CA1505_AvoidUnmaintainableCode_DisagreeWithAssessment)]
        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        static ActionButtonComponentPayloadTest()
        {
            ConstructorArgumentValidationTestScenarios.RemoveAllScenarios()
                .AddScenario(() =>
                    new ConstructorArgumentValidationTestScenario<ActionButtonComponentPayload>
                    {
                        Name = "constructor should throw ArgumentNullException when parameter 'id' is null scenario",
                        ConstructionFunc = () =>
                        {
                            var referenceObject = A.Dummy<ActionButtonComponentPayload>();

                            var result = new ActionButtonComponentPayload(
                                null,
                                referenceObject.Label,
                                referenceObject.MenuItems,
                                referenceObject.IsDisabled,
                                referenceObject.Icons,
                                referenceObject.IconPosition);

                            return result;
                        },
                        ExpectedExceptionType = typeof(ArgumentNullException),
                        ExpectedExceptionMessageContains = new[] { "id", },
                    })
                .AddScenario(() =>
                    new ConstructorArgumentValidationTestScenario<ActionButtonComponentPayload>
                    {
                        Name = "constructor should throw ArgumentException when parameter 'id' is white space scenario",
                        ConstructionFunc = () =>
                        {
                            var referenceObject = A.Dummy<ActionButtonComponentPayload>();

                            var result = new ActionButtonComponentPayload(
                                Invariant($"  {Environment.NewLine}  "),
                                referenceObject.Label,
                                referenceObject.MenuItems,
                                referenceObject.IsDisabled,
                                referenceObject.Icons,
                                referenceObject.IconPosition);

                            return result;
                        },
                        ExpectedExceptionType = typeof(ArgumentException),
                        ExpectedExceptionMessageContains = new[] { "id", "white space", },
                    })
                .AddScenario(() =>
                    new ConstructorArgumentValidationTestScenario<ActionButtonComponentPayload>
                    {
                        Name = "constructor should throw ArgumentNullException when parameter 'label' is null scenario",
                        ConstructionFunc = () =>
                        {
                            var referenceObject = A.Dummy<ActionButtonComponentPayload>();

                            var result = new ActionButtonComponentPayload(
                                referenceObject.Id,
                                null,
                                referenceObject.MenuItems,
                                referenceObject.IsDisabled,
                                referenceObject.Icons,
                                referenceObject.IconPosition);

                            return result;
                        },
                        ExpectedExceptionType = typeof(ArgumentNullException),
                        ExpectedExceptionMessageContains = new[] { "label", },
                    })
                .AddScenario(() =>
                    new ConstructorArgumentValidationTestScenario<ActionButtonComponentPayload>
                    {
                        Name =
                            "constructor should throw ArgumentException when parameter 'label' is white space scenario",
                        ConstructionFunc = () =>
                        {
                            var referenceObject = A.Dummy<ActionButtonComponentPayload>();

                            var result = new ActionButtonComponentPayload(
                                referenceObject.Id,
                                Invariant($"  {Environment.NewLine}  "),
                                referenceObject.MenuItems,
                                referenceObject.IsDisabled,
                                referenceObject.Icons,
                                referenceObject.IconPosition);

                            return result;
                        },
                        ExpectedExceptionType = typeof(ArgumentException),
                        ExpectedExceptionMessageContains = new[] { "label", "white space", },
                    })
                .AddScenario(() =>
                    new ConstructorArgumentValidationTestScenario<ActionButtonComponentPayload>
                    {
                        Name =
                            "constructor should throw ArgumentNullException when parameter 'menuItems' is null scenario",
                        ConstructionFunc = () =>
                        {
                            var referenceObject = A.Dummy<ActionButtonComponentPayload>();

                            var result = new ActionButtonComponentPayload(
                                referenceObject.Id,
                                referenceObject.Label,
                                null,
                                referenceObject.IsDisabled,
                                referenceObject.Icons,
                                referenceObject.IconPosition);

                            return result;
                        },
                        ExpectedExceptionType = typeof(ArgumentNullException),
                        ExpectedExceptionMessageContains = new[] { "menuItems", },
                    })
                .AddScenario(() =>
                    new ConstructorArgumentValidationTestScenario<ActionButtonComponentPayload>
                    {
                        Name =
                            "constructor should throw ArgumentException when parameter 'menuItems' is an empty enumerable scenario",
                        ConstructionFunc = () =>
                        {
                            var referenceObject = A.Dummy<ActionButtonComponentPayload>();

                            var result = new ActionButtonComponentPayload(
                                referenceObject.Id,
                                referenceObject.Label,
                                new List<ActionMenuItem>(),
                                referenceObject.IsDisabled,
                                referenceObject.Icons,
                                referenceObject.IconPosition);

                            return result;
                        },
                        ExpectedExceptionType = typeof(ArgumentException),
                        ExpectedExceptionMessageContains = new[] { "menuItems", "is an empty enumerable", },
                    })
                .AddScenario(() =>
                    new ConstructorArgumentValidationTestScenario<ActionButtonComponentPayload>
                    {
                        Name =
                            "constructor should throw ArgumentException when parameter 'menuItems' contains a null element scenario",
                        ConstructionFunc = () =>
                        {
                            var referenceObject = A.Dummy<ActionButtonComponentPayload>();

                            var result = new ActionButtonComponentPayload(
                                referenceObject.Id,
                                referenceObject.Label,
                                new ActionMenuItem[0].Concat(referenceObject.MenuItems)
                                    .Concat(new ActionMenuItem[] { null }).Concat(referenceObject.MenuItems).ToList(),
                                referenceObject.IsDisabled,
                                referenceObject.Icons,
                                referenceObject.IconPosition);

                            return result;
                        },
                        ExpectedExceptionType = typeof(ArgumentException),
                        ExpectedExceptionMessageContains = new[] { "menuItems", "contains at least one null element", },
                    });
        }
    }
}