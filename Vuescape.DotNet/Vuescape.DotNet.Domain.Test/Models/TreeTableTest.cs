// <copyright file="TreeTableTest.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>

namespace Vuescape.DotNet.Domain.Test
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Globalization;

    using FakeItEasy;

    using OBeautifulCode.CodeAnalysis.Recipes;
    using OBeautifulCode.CodeGen.ModelObject.Recipes;

    using Xunit;

    [SuppressMessage("Microsoft.Maintainability", "CA1505:AvoidUnmaintainableCode", Justification = ObcSuppressBecause.CA1505_AvoidUnmaintainableCode_DisagreeWithAssessment)]
    public static partial class TreeTableTest
    {
        [SuppressMessage("Microsoft.Maintainability", "CA1505:AvoidUnmaintainableCode", Justification = ObcSuppressBecause.CA1505_AvoidUnmaintainableCode_DisagreeWithAssessment)]
        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        static TreeTableTest()
        {
            ConstructorArgumentValidationTestScenarios.RemoveAllScenarios()
            .AddScenario(() =>
                new ConstructorArgumentValidationTestScenario<TreeTable>
                {
                    Name = "constructor should throw ArgumentNullException when parameter 'content' is null scenario",
                    ConstructionFunc = () =>
                    {
                        var referenceObject = A.Dummy<TreeTable>();

                        var result = new TreeTable(
                                             A.Dummy<string>(),
                                             null);

                        return result;
                    },
                    ExpectedExceptionType = typeof(ArgumentNullException),
                    ExpectedExceptionMessageContains = new[] { "content", },
                });
        }

        [Fact]
        public static void Method___Should_do_something___When_called()
        {
            // Arrange

            // Act

            // Assert
            var startingYear = 2016;
            var endingYear = 2021;
            var numberOfPeriods = endingYear - startingYear + 1;

            var random = new Random();
            var headers = new List<TreeTableHeaderRow>();
            var items = new List<TreeTableHeaderCell>
            {
                new TreeTableHeaderCell("entityName", "Active Accounts", null, null, string.Empty, string.Empty, 1, true, new ColumnSorter(SortDirection.Ascending, SortComparisonStrategy.StringCaseInsensitive)),
            };

            for (var i = startingYear; i < startingYear + numberOfPeriods; i++)
            {
                var item = new TreeTableHeaderCell("reportingPeriod_" + i.ToString(CultureInfo.InvariantCulture), string.Empty,  null, null, null, string.Empty, 1, true, null, null);
                items.Add(item);
            }

            headers.Add(new TreeTableHeaderRow("header", items));

            var rows = new List<TreeTableRow>();

            foreach (var entityName in
                "American|ABC Processing|Warehousing|Steel Metals|Iron Butterfly|Mad Hatter|Florida Fabrication"
                    .Split('|'))
            {
                var treeTableCells = new List<TreeTableCell>();

                var treeTableCell = new TreeTableCell("entityName", entityName, null, null, "who-is-in-report-consolidated__td--entityName", string.Empty, 1, true);
                treeTableCells.Add(treeTableCell);
                for (var i = startingYear; i < startingYear + numberOfPeriods; i++)
                {
                    var status = random.Next(2) == 0 ? "Passed" : "Failed";
                    var cssStyles = status == "Passed" ? "positive" : "negative";
                    cssStyles += " who-is-in-report-consolidated__td--status";
                    treeTableCell = new TreeTableCell(entityName + "-" + i.ToString(CultureInfo.InvariantCulture), null, null, null, cssStyles, string.Empty, 1, true, null);
                    treeTableCells.Add(treeTableCell);
                }

                var row = new TreeTableRow("entityName-" + entityName, treeTableCells, 0, string.Empty, string.Empty, RowRenderer.DataRowRenderer, false, false, true, false, false, null, null);
                rows.Add(row);
            }

            var treeTable = new TreeTable(
                "id",
                new TreeTableContent(headers, rows, true, true, true, true, false, false, null, null, null, null));
            Assert.NotNull(treeTable);
        }
    }
}