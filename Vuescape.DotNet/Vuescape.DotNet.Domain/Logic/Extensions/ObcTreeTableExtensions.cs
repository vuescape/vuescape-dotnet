// <copyright file="ObcTreeTableExtensions.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;

    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.CodeAnalysis.Recipes;

    using static System.FormattableString;

    /// <summary>
    /// Extension methods on <see cref="OBeautifulCode.DataStructure.TreeTable"/>.
    /// </summary>
    public static partial class ObcTreeTableExtensions
    {
        /// <summary>
        /// Convert a <see cref="OBeautifulCode.DataStructure.TreeTable"/> to a <see cref="TreeTable"/>.
        /// </summary>
        /// <param name="obcTreeTable">The OBC TreeTable to convert.</param>
        /// <param name="obcToVuescapeConversionContext">The conversion context.</param>
        /// <param name="tokenToSubstitutionMap">TODO:.</param>
        /// <returns>A TreeTable.</returns>
        [SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "tokenToSubstitutionMap", Justification = "Future-proof from protocol.")]
        [SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling", Justification = ObcSuppressBecause.CA1506_AvoidExcessiveClassCoupling_DisagreeWithAssessment)]
        public static TreeTable ConvertToVuescapeTreeTable(
            this OBeautifulCode.DataStructure.TreeTable obcTreeTable,
            ObcToVuescapeConversionContext obcToVuescapeConversionContext = null,
            IReadOnlyDictionary<string, string> tokenToSubstitutionMap = null)
        {
            new { obcTreeTable }.Must().NotBeNull();

            if (obcToVuescapeConversionContext?.ReportConversionMode == ReportConversionMode.Strict)
            {
                // Validate that only first column is frozen
                // This ignores freezing on TableColumns
                if (obcTreeTable.TableColumns.Columns.Skip(1).Any(_ => _?.Format?.Options.IsFrozen() ?? false) ||
                    (obcTreeTable.TableColumns?.ColumnsFormat.Options.IsFrozen() ?? false))
                {
                    throw new InvalidOperationException(Invariant(
                        $"TreeTable only supports freezing the first column. One or more ColumnFormatOptions that are not the first column are defined as frozen. Either change the ColumnFormatOptions or set ReportConversionMode to Relaxed."));
                }
            }

            var columnDefinitions = ConvertToVuescapeColumnDefinitions(obcTreeTable, obcToVuescapeConversionContext);

            var treeTableHeaders = ConvertToVuescapeTreeTableHeaderRows(obcTreeTable, obcToVuescapeConversionContext);
            var treeTableRows = ConvertToVuescapeTreeTableRows(obcTreeTable, obcToVuescapeConversionContext);
            var treeTableFooters = ConvertToVuescapeTreeTableFooterRows(obcTreeTable, obcToVuescapeConversionContext);

            // Default to false
            var isFirstColumnFrozen = ColumnFormatOptionsHelper.IsFrozen(obcTreeTable.TableColumns?.Columns[0], obcTreeTable.TableColumns?.ColumnsFormat, null, obcToVuescapeConversionContext);

            // Default to true
            var shouldSyncHeaderRow = obcTreeTable.TableRows?.HeaderRows?.Format?.RowsFormat?.Options.IsFrozen() ?? true;
            var shouldIncludeFooter = treeTableFooters != null && treeTableFooters.Any();

            // TODO: cssStyle
            // TODO: cssClass
            var areAnyChildren = treeTableRows.Any(_ => _.Children != null && _.Children.Any());
            var sortLevel = areAnyChildren ? SortLevel.Children : SortLevel.Parent;

            var treeTableContent = new TreeTableContent(
                treeTableHeaders,
                treeTableRows,
                treeTableFooters,
                true, // Defaulting to allow scrolling
                true, // Defaulting to allow scrolling
                shouldSyncHeaderRow,
                false,
                shouldIncludeFooter,
                isFirstColumnFrozen,
                null,
                null,
                "cell-border",
                null,
                sortLevel);

            // TODO: Add default behaviors.
            // TODO: Determine specific behaviors to add based on parameter data.
            return new TreeTable(null, columnDefinitions, treeTableContent);
        }

        private static IReadOnlyList<ColumnDefinition> ConvertToVuescapeColumnDefinitions(
            OBeautifulCode.DataStructure.TreeTable obcTreeTable,
            ObcToVuescapeConversionContext obcToVuescapeConversionContext)
        {
            var obcTableFormat = obcTreeTable?.Format;
            var obcTableRowsFormat = obcTreeTable?.TableRows?.RowsFormat;
            var obcHeaderRowsFormat = obcTreeTable?.TableRows?.HeaderRows?.Format;
            var obcTableColumns = obcTreeTable?.TableColumns;
            var obcTableColumnsFormat = obcTableColumns?.ColumnsFormat;

            // TODO: Is this the right order of formatting for column definition. Using same approach as elsewhere with rows before columns
            IReadOnlyList<ColumnDefinition> columnDefinitions =
                obcTreeTable?.TableColumns?.Columns?.Select(
                    obcColumn =>
                    {
                        var columnDefinition = obcColumn.ToColumnDefinition(
                            null,
                            obcHeaderRowsFormat,
                            obcTableRowsFormat,
                            obcColumn.Format,
                            obcTableColumnsFormat,
                            obcTableFormat,
                            obcToVuescapeConversionContext) ?? new ColumnDefinition(ColumnWidthBehavior.DynamicallySizeToContent, ColumnWrapBehavior.None, null, null);

                        return columnDefinition;
                    })
                .ToList();

            return columnDefinitions;
        }

        private static IReadOnlyList<TreeTableHeaderRow> ConvertToVuescapeTreeTableHeaderRows(
            OBeautifulCode.DataStructure.TreeTable obcTreeTable,
            ObcToVuescapeConversionContext obcToVuescapeConversionContext)
        {
            var obcTableFormat = obcTreeTable?.Format;
            var obcTableRowsFormat = obcTreeTable?.TableRows?.RowsFormat;
            var obcHeaderRowsFormat = obcTreeTable?.TableRows?.HeaderRows?.Format;
            var obcTableColumns = obcTreeTable?.TableColumns;
            var obcTableColumnsFormat = obcTableColumns?.ColumnsFormat;

            if (obcTreeTable?.TableRows?.HeaderRows?.Rows == null)
            {
                return null;
            }

            var totalRows = obcTreeTable.TableRows.HeaderRows.Rows.Count;
            var rowNumber = 1;
            var treeTableHeaderRows = obcTreeTable.TableRows.HeaderRows.Rows.Select(
                    obcHeaderRow => obcHeaderRow.ToVuescapeTreeTableHeaderRow(
                        obcTableFormat,
                        obcTableRowsFormat,
                        obcHeaderRowsFormat,
                        obcHeaderRow.Format,
                        obcTableColumnsFormat,
                        obcTableColumns?.Columns,
                        rowNumber++ == totalRows,
                        obcToVuescapeConversionContext))
                .ToList();

            return treeTableHeaderRows;
        }

        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity", Justification = "Handling all conditions.")]
        private static IReadOnlyList<TreeTableRow> ConvertToVuescapeTreeTableFooterRows(
            OBeautifulCode.DataStructure.TreeTable obcTreeTable,
            ObcToVuescapeConversionContext obcToVuescapeConversionContext)
        {
            var obcTableFormat = obcTreeTable?.Format;
            var obcTableRowsFormat = obcTreeTable?.TableRows?.RowsFormat;
            var obcFooterRowsFormat = obcTreeTable?.TableRows?.FooterRows?.Format;
            var obcTableColumns = obcTreeTable?.TableColumns;
            var obcTableColumnsFormat = obcTableColumns?.ColumnsFormat;

            IReadOnlyList<OBeautifulCode.DataStructure.FlatRow> summaryRowsForFooter = null;
            if (obcTreeTable?.TableRows?.DataRows?.Rows?.Count == 1 && obcToVuescapeConversionContext.ShouldSummaryRowsDisplayInFooter)
            {
                var row = obcTreeTable.TableRows.DataRows.Rows.Single();
                if (row?.ExpandedSummaryRows?.Count > 0)
                {
                    summaryRowsForFooter = row.ExpandedSummaryRows;
                    row.ExpandedSummaryRows.ToList().Clear();

                    // TODO: Also move collapsed rows to the footer
                    row.CollapsedSummaryRows?.ToList().Clear();
                }
            }

            var footerRows = obcTreeTable?.TableRows?.FooterRows?.Rows?.ToList();
            if (summaryRowsForFooter != null)
            {
                if (footerRows == null)
                {
                    footerRows = summaryRowsForFooter.ToList();
                }
                else
                {
                    footerRows.InsertRange(0, summaryRowsForFooter);
                }
            }

            var result = footerRows?.Select(
                obcFooterRow => obcFooterRow.ToVuescapeTreeTableFooterRow(
                    obcTableFormat,
                    obcTableRowsFormat,
                    obcFooterRowsFormat,
                    obcFooterRow?.Format,
                    obcTableColumnsFormat,
                    obcTableColumns?.Columns,
                    obcToVuescapeConversionContext))
                ?.ToList();

            return result;
        }

        private static IReadOnlyList<TreeTableRow> ConvertToVuescapeTreeTableRows(
            OBeautifulCode.DataStructure.TreeTable obcTreeTable,
            ObcToVuescapeConversionContext obcToVuescapeConversionContext)
        {
            var obcTableFormat = obcTreeTable?.Format;
            var obcTableRowsFormat = obcTreeTable?.TableRows?.RowsFormat;
            var obcDataRowsFormat = obcTreeTable?.TableRows?.DataRows?.Format;
            var obcTableColumns = obcTreeTable?.TableColumns;
            var obcTableColumnsFormat = obcTableColumns?.ColumnsFormat;

            var shouldIncludeSummaryRows = !(obcTreeTable?.TableRows?.DataRows?.Rows?.Count == 1 &&
                                              obcToVuescapeConversionContext.ShouldSummaryRowsDisplayInFooter);

            IReadOnlyList<TreeTableRow> treeTableRows = obcTreeTable?.TableRows?.DataRows?.Rows?.Select(
                    obcDataRow => obcDataRow.ToVuescapeTreeTableRow(
                        obcTableFormat,
                        obcTableRowsFormat,
                        obcDataRowsFormat,
                        obcDataRow.Format,
                        obcTableColumnsFormat,
                        obcTableColumns?.Columns,
                        null,
                        shouldIncludeSummaryRows,
                        obcToVuescapeConversionContext))
                ?.ToList();

            return treeTableRows;
        }
    }
}
