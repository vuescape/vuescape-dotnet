// <copyright file="TreeTableTest.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>

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
    public static partial class TreeTableTest
    {
        [SuppressMessage("Microsoft.Maintainability", "CA1505:AvoidUnmaintainableCode", Justification = ObcSuppressBecause.CA1505_AvoidUnmaintainableCode_DisagreeWithAssessment)]
        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        static TreeTableTest()
        {
            ConstructorArgumentValidationTestScenarios.RemoveAllScenarios();
            ConstructorArgumentValidationTestScenarios.AddScenario(ConstructorArgumentValidationTestScenario<TreeTable>.ForceGeneratedTestsToPassAndWriteMyOwnScenario);
        }

        [Fact]
        public static void Constructor___Should_not_throw___When_headers_and_rows_are_provided()
        {
            // Arrange
            var headers = A.Dummy<IReadOnlyList<TreeTableHeaderRow>>();
            var rows = A.Dummy<IReadOnlyList<TreeTableRow>>();
            var shouldScrollVertical = A.Dummy<bool>();
            var shouldScrollHorizontal = A.Dummy<bool>();
            var shouldSyncHeaderScroll = A.Dummy<bool>();
            var shouldSyncFooterScroll = A.Dummy<bool>();
            var shouldIncludeFooter = A.Dummy<bool>();
            var shouldFreezeFirstColumn = A.Dummy<bool>();
            var deadAreaColor = A.Dummy<string>();
            var maxRows = A.Dummy<int?>();
            var cssStyle = A.Dummy<string>();

            // Act
            var ex = Record.Exception(() => new TreeTable(headers, rows, shouldScrollVertical, shouldScrollHorizontal, shouldSyncHeaderScroll, shouldSyncFooterScroll, shouldIncludeFooter, shouldFreezeFirstColumn, deadAreaColor, maxRows, cssStyle));

            // Assert
            ex.AsTest().Must().BeNull();
        }

        [Fact]
        public static void Constructor___Should_throw___When_headers_are_null()
        {
            // Arrange
            IReadOnlyList<TreeTableHeaderRow> headers = null;
            var rows = A.Dummy<IReadOnlyList<TreeTableRow>>();
            var shouldScrollVertical = A.Dummy<bool>();
            var shouldScrollHorizontal = A.Dummy<bool>();
            var shouldSyncHeaderScroll = A.Dummy<bool>();
            var shouldSyncFooterScroll = A.Dummy<bool>();
            var shouldIncludeFooter = A.Dummy<bool>();
            var shouldFreezeFirstColumn = A.Dummy<bool>();
            var deadAreaColor = A.Dummy<string>();
            var maxRows = A.Dummy<int?>();
            var cssStyle = A.Dummy<string>();

            // Act
            var ex = Record.Exception(() => new TreeTable(headers, rows, shouldScrollVertical, shouldScrollHorizontal, shouldSyncHeaderScroll, shouldSyncFooterScroll, shouldIncludeFooter, shouldFreezeFirstColumn, deadAreaColor, maxRows, cssStyle));

            // Assert
            ex.AsTest().Must().BeOfType<ArgumentNullException>();
            ex.Message.AsTest().Must().ContainString("headers");
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
                new TreeTableHeaderCell("entityName", string.Empty, 1, new ColumnSorter("entityName", SortDirection.Ascending), null, "Active Accounts"),
            };

            for (var i = startingYear; i < startingYear + numberOfPeriods; i++)
            {
                var item = new TreeTableHeaderCell("reportingPeriod_" + i, string.Empty, 1, null, null, i.ToString());
                items.Add(item);
            }

            headers.Add(new TreeTableHeaderRow("header", string.Empty, items));

            var rows = new List<TreeTableRow>();

            foreach (var entityName in
                "American|ABC Processing|Warehousing|Steel Metals|Iron Butterfly|Mad Hatter|Florida Fabrication"
                    .Split('|'))
            {
                var TreeTableCells = new List<TreeTableCell>();

                var TreeTableCell = new TreeTableCell("entityName", "who-is-in-report-consolidated__td--entityName", 1, null, true, CellRenderer.DefaultCellRenderer, entityName, null);
                TreeTableCells.Add(TreeTableCell);
                for (var i = startingYear; i < startingYear + numberOfPeriods; i++)
                {
                    var status = random.Next(2) == 0 ? "Passed" : "Failed";
                    var cssStyles = status == "Passed" ? "positive" : "negative";
                    cssStyles += " who-is-in-report-consolidated__td--status";
                    TreeTableCell = new TreeTableCell(entityName + "-" + i, cssStyles, 1, null, true, CellRenderer.DefaultCellRenderer, status, null);
                    TreeTableCells.Add(TreeTableCell);
                }

                var row = new TreeTableRow("entityName-" + entityName, "entityName", string.Empty, 0, false, false, null, false, true, TreeTableCells, RowRenderer.DataRowRenderer, null, null);
                rows.Add(row);
            }

            var treeTable = new TreeTable(headers, rows, true, true, true, true, false, false, null, null, null);
        }
    }
}