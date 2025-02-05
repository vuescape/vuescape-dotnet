

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
    public static partial class TableComponentPayloadTest
    {
        [SuppressMessage("Microsoft.Maintainability", "CA1505:AvoidUnmaintainableCode", Justification = ObcSuppressBecause.CA1505_AvoidUnmaintainableCode_DisagreeWithAssessment)]
        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        static TableComponentPayloadTest()
        {
            ConstructorArgumentValidationTestScenarios.RemoveAllScenarios()
            .AddScenario(() =>
                new ConstructorArgumentValidationTestScenario<TableComponentPayload>
                {
                    Name = "constructor should throw ArgumentNullException when parameter 'id' is null scenario",
                    ConstructionFunc = () =>
                    {
                        var referenceObject = A.Dummy<TableComponentPayload>();

                        var result = new TableComponentPayload(
                                             null,
                                             referenceObject.Columns,
                                             referenceObject.Rows);

                        return result;
                    },
                    ExpectedExceptionType = typeof(ArgumentNullException),
                    ExpectedExceptionMessageContains = new[] { "id", },
                })
            .AddScenario(() =>
                new ConstructorArgumentValidationTestScenario<TableComponentPayload>
                {
                    Name = "constructor should throw ArgumentException when parameter 'id' is white space scenario",
                    ConstructionFunc = () =>
                    {
                        var referenceObject = A.Dummy<TableComponentPayload>();

                        var result = new TableComponentPayload(
                                             Invariant($"  {Environment.NewLine}  "),
                                             referenceObject.Columns,
                                             referenceObject.Rows);

                        return result;
                    },
                    ExpectedExceptionType = typeof(ArgumentException),
                    ExpectedExceptionMessageContains = new[] { "id", "white space", },
                })
            .AddScenario(() =>
                new ConstructorArgumentValidationTestScenario<TableComponentPayload>
                {
                    Name = "constructor should throw ArgumentNullException when parameter 'columns' is null scenario",
                    ConstructionFunc = () =>
                    {
                        var referenceObject = A.Dummy<TableComponentPayload>();

                        var result = new TableComponentPayload(
                                             referenceObject.Id,
                                             null,
                                             referenceObject.Rows);

                        return result;
                    },
                    ExpectedExceptionType = typeof(ArgumentNullException),
                    ExpectedExceptionMessageContains = new[] { "columns", },
                })
            .AddScenario(() =>
                new ConstructorArgumentValidationTestScenario<TableComponentPayload>
                {
                    Name = "constructor should throw ArgumentException when parameter 'columns' is an empty enumerable scenario",
                    ConstructionFunc = () =>
                    {
                        var referenceObject = A.Dummy<TableComponentPayload>();

                        var result = new TableComponentPayload(
                                             referenceObject.Id,
                                             new List<TableColumn>(),
                                             referenceObject.Rows);

                        return result;
                    },
                    ExpectedExceptionType = typeof(ArgumentException),
                    ExpectedExceptionMessageContains = new[] { "columns", "is an empty enumerable", },
                })
            .AddScenario(() =>
                new ConstructorArgumentValidationTestScenario<TableComponentPayload>
                {
                    Name = "constructor should throw ArgumentException when parameter 'columns' contains a null element scenario",
                    ConstructionFunc = () =>
                    {
                        var referenceObject = A.Dummy<TableComponentPayload>();

                        var result = new TableComponentPayload(
                                             referenceObject.Id,
                                             new TableColumn[0].Concat(referenceObject.Columns).Concat(new TableColumn[] { null }).Concat(referenceObject.Columns).ToList(),
                                             referenceObject.Rows);

                        return result;
                    },
                    ExpectedExceptionType = typeof(ArgumentException),
                    ExpectedExceptionMessageContains = new[] { "columns", "contains at least one null element", },
                })
            .AddScenario(() =>
                new ConstructorArgumentValidationTestScenario<TableComponentPayload>
                {
                    Name = "constructor should throw ArgumentNullException when parameter 'rows' is null scenario",
                    ConstructionFunc = () =>
                    {
                        var referenceObject = A.Dummy<TableComponentPayload>();

                        var result = new TableComponentPayload(
                                             referenceObject.Id,
                                             referenceObject.Columns,
                                             null);

                        return result;
                    },
                    ExpectedExceptionType = typeof(ArgumentNullException),
                    ExpectedExceptionMessageContains = new[] { "rows", },
                })
            .AddScenario(() =>
                new ConstructorArgumentValidationTestScenario<TableComponentPayload>
                {
                    Name = "constructor should throw ArgumentException when parameter 'rows' contains a null element scenario",
                    ConstructionFunc = () =>
                    {
                        var referenceObject = A.Dummy<TableComponentPayload>();

                        var result = new TableComponentPayload(
                                             referenceObject.Id,
                                             referenceObject.Columns,
                                             new TableRow[0].Concat(referenceObject.Rows).Concat(new TableRow[] { null }).Concat(referenceObject.Rows).ToList());

                        return result;
                    },
                    ExpectedExceptionType = typeof(ArgumentException),
                    ExpectedExceptionMessageContains = new[] { "rows", "contains at least one null element", },
                });
        }
    }
}