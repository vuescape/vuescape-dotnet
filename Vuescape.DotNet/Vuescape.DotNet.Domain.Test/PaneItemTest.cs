

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
    public static partial class PaneItemTest
    {
        [SuppressMessage("Microsoft.Maintainability", "CA1505:AvoidUnmaintainableCode", Justification = ObcSuppressBecause.CA1505_AvoidUnmaintainableCode_DisagreeWithAssessment)]
        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        static PaneItemTest()
        {
        ConstructorArgumentValidationTestScenarios
            .RemoveAllScenarios()
            .AddScenario(() =>
                new ConstructorArgumentValidationTestScenario<PaneItem>
                {
                    Name = "constructor should throw ArgumentNullException when parameter 'components' is null scenario",
                    ConstructionFunc = () =>
                    {
                        var referenceObject = A.Dummy<PaneItem>();

                        var result = new PaneItem(
                                             null,
                                             referenceObject.Width,
                                             referenceObject.HorizontalAlignment,
                                             referenceObject.VerticalAlignment);

                        return result;
                    },
                    ExpectedExceptionType = typeof(ArgumentNullException),
                    ExpectedExceptionMessageContains = new[] { "components", },
                })
            .AddScenario(() =>
                new ConstructorArgumentValidationTestScenario<PaneItem>
                {
                    Name = "constructor should throw ArgumentException when parameter 'components' contains a null element scenario",
                    ConstructionFunc = () =>
                    {
                        var referenceObject = A.Dummy<PaneItem>();

                        var result = new PaneItem(
                                             new PaneComponentBase[0].Concat(referenceObject.Components).Concat(new PaneComponentBase[] { null }).Concat(referenceObject.Components).ToList(),
                                             referenceObject.Width,
                                             referenceObject.HorizontalAlignment,
                                             referenceObject.VerticalAlignment);

                        return result;
                    },
                    ExpectedExceptionType = typeof(ArgumentException),
                    ExpectedExceptionMessageContains = new[] { "components", "contains at least one null element", },
                })
            .AddScenario(() =>
                new ConstructorArgumentValidationTestScenario<PaneItem>
                {
                    Name = "constructor should throw ArgumentOutOfRangeException when parameter 'horizontalAlignment' is HorizontalAlignment.Unknown",
                    ConstructionFunc = () =>
                    {
                        var referenceObject = A.Dummy<PaneItem>();

                        var result = new PaneItem(
                                             referenceObject.Components,
                                             referenceObject.Width,
                                             HorizontalAlignment.Unknown,
                                             referenceObject.VerticalAlignment);

                        return result;
                    },
                    ExpectedExceptionType = typeof(ArgumentOutOfRangeException),
                    ExpectedExceptionMessageContains = new[] { "horizontalAlignment", "Unknown", },
                })
            .AddScenario(() =>
                new ConstructorArgumentValidationTestScenario<PaneItem>
                {
                    Name = "constructor should throw ArgumentOutOfRangeException when parameter 'verticalAlignment' is VerticalAlignment.Unknown",
                    ConstructionFunc = () =>
                    {
                        var referenceObject = A.Dummy<PaneItem>();

                        var result = new PaneItem(
                                             referenceObject.Components,
                                             referenceObject.Width,
                                             referenceObject.HorizontalAlignment,
                                             VerticalAlignment.Unknown);

                        return result;
                    },
                    ExpectedExceptionType = typeof(ArgumentOutOfRangeException),
                    ExpectedExceptionMessageContains = new[] { "verticalAlignment", "Unknown", },
                });
    }
}
}