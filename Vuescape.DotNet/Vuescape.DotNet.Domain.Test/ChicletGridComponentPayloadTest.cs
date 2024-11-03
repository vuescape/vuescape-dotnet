

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
    public static partial class ChicletGridComponentPayloadTest
    {
        [SuppressMessage("Microsoft.Maintainability", "CA1505:AvoidUnmaintainableCode", Justification = ObcSuppressBecause.CA1505_AvoidUnmaintainableCode_DisagreeWithAssessment)]
        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        static ChicletGridComponentPayloadTest()
        {
            ConstructorArgumentValidationTestScenarios.RemoveAllScenarios()
                        .AddScenario(() =>
                            new ConstructorArgumentValidationTestScenario<ChicletGridComponentPayload>
                            {
                                Name = "constructor should throw ArgumentNullException when parameter 'chiclets' is null scenario",
                                ConstructionFunc = () =>
                                {
                                    var result = new ChicletGridComponentPayload(
                                                         null);

                                    return result;
                                },
                                ExpectedExceptionType = typeof(ArgumentNullException),
                                ExpectedExceptionMessageContains = new[] { "chiclets", },
                            })
                        .AddScenario(() =>
                            new ConstructorArgumentValidationTestScenario<ChicletGridComponentPayload>
                            {
                                Name = "constructor should throw ArgumentException when parameter 'chiclets' contains a null element scenario",
                                ConstructionFunc = () =>
                                {
                                    var referenceObject = A.Dummy<ChicletGridComponentPayload>();

                                    var result = new ChicletGridComponentPayload(
                                                         new Chiclet[0].Concat(referenceObject.Chiclets).Concat(new Chiclet[] { null }).Concat(referenceObject.Chiclets).ToList());

                                    return result;
                                },
                                ExpectedExceptionType = typeof(ArgumentException),
                                ExpectedExceptionMessageContains = new[] { "chiclets", "contains at least one null element", },
                            });
        }
    }
}