

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
    public static partial class TreeTableRowDependencyTest
    {
        [SuppressMessage("Microsoft.Maintainability", "CA1505:AvoidUnmaintainableCode", Justification = ObcSuppressBecause.CA1505_AvoidUnmaintainableCode_DisagreeWithAssessment)]
        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        static TreeTableRowDependencyTest()
        {
            ConstructorArgumentValidationTestScenarios.RemoveAllScenarios()
                .AddScenario(() =>
                    new ConstructorArgumentValidationTestScenario<TreeTableRowDependency>
                    {
                        Name = "constructor should throw ArgumentNullException when parameter 'targetId' is null scenario",
                        ConstructionFunc = () =>
                        {
                            var referenceObject = A.Dummy<TreeTableRowDependency>();

                            var result = new TreeTableRowDependency(
                                                 null,
                                                 referenceObject.DependencyTypeName,
                                                 referenceObject.Payload);

                            return result;
                        },
                        ExpectedExceptionType = typeof(ArgumentNullException),
                        ExpectedExceptionMessageContains = new[] { "targetId", },
                    })
                .AddScenario(() =>
                    new ConstructorArgumentValidationTestScenario<TreeTableRowDependency>
                    {
                        Name = "constructor should throw ArgumentException when parameter 'targetId' is white space scenario",
                        ConstructionFunc = () =>
                        {
                            var referenceObject = A.Dummy<TreeTableRowDependency>();

                            var result = new TreeTableRowDependency(
                                                 Invariant($"  {Environment.NewLine}  "),
                                                 referenceObject.DependencyTypeName,
                                                 referenceObject.Payload);

                            return result;
                        },
                        ExpectedExceptionType = typeof(ArgumentException),
                        ExpectedExceptionMessageContains = new[] { "targetId", "white space", },
                    })
                .AddScenario(() =>
                    new ConstructorArgumentValidationTestScenario<TreeTableRowDependency>
                    {
                        Name = "constructor should throw ArgumentNullException when parameter 'dependencyTypeName' is null scenario",
                        ConstructionFunc = () =>
                        {
                            var referenceObject = A.Dummy<TreeTableRowDependency>();

                            var result = new TreeTableRowDependency(
                                                 referenceObject.TargetId,
                                                 null,
                                                 referenceObject.Payload);

                            return result;
                        },
                        ExpectedExceptionType = typeof(ArgumentNullException),
                        ExpectedExceptionMessageContains = new[] { "dependencyTypeName", },
                    })
                .AddScenario(() =>
                    new ConstructorArgumentValidationTestScenario<TreeTableRowDependency>
                    {
                        Name = "constructor should throw ArgumentException when parameter 'dependencyTypeName' is white space scenario",
                        ConstructionFunc = () =>
                        {
                            var referenceObject = A.Dummy<TreeTableRowDependency>();

                            var result = new TreeTableRowDependency(
                                                 referenceObject.TargetId,
                                                 Invariant($"  {Environment.NewLine}  "),
                                                 referenceObject.Payload);

                            return result;
                        },
                        ExpectedExceptionType = typeof(ArgumentException),
                        ExpectedExceptionMessageContains = new[] { "dependencyTypeName", "white space", },
                    });
        }
    }
}