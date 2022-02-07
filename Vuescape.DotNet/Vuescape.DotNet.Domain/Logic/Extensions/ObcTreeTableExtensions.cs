// <copyright file="ObcTreeTableExtensions.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>

// ReSharper disable once CheckNamespace

namespace Vuescape.DotNet.Domain
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using OBeautifulCode.Assertion.Recipes;

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
        public static TreeTable ConvertToVuescapeTreeTable(
            this OBeautifulCode.DataStructure.TreeTable obcTreeTable,
            ObcToVuescapeConversionContext obcToVuescapeConversionContext = null,
            IReadOnlyDictionary<string, string> tokenToSubstitutionMap = null)
        {
            new { obcTreeTable }.MustForArg().NotBeNull();

            if (obcToVuescapeConversionContext?.ReportConversionMode == ReportConversionMode.Strict)
            {
                // Validate that only first column is frozen
                if (obcTreeTable.TableColumns.Columns.Skip(1).Any(_ => _.IsFrozen()))
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
            var isFirstColumnFrozen = obcTreeTable.TableColumns?.Columns[0].IsFrozen() ?? false;

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
                null,
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

            IReadOnlyList<TreeTableHeaderRow> treeTableHeaderRows = obcTreeTable.TableRows.HeaderRows.Rows.Select(
                    obcHeaderRow => obcHeaderRow.ToVuescapeTreeTableHeaderRow(
                        obcTableFormat,
                        obcTableRowsFormat,
                        obcHeaderRowsFormat,
                        obcHeaderRow.Format,
                        obcTableColumnsFormat,
                        obcTableColumns?.Columns,
                        obcToVuescapeConversionContext))
                .ToList();

            return treeTableHeaderRows;
        }

        private static IReadOnlyList<TreeTableRow> ConvertToVuescapeTreeTableFooterRows(
            OBeautifulCode.DataStructure.TreeTable obcTreeTable,
            ObcToVuescapeConversionContext obcToVuescapeConversionContext)
        {
            var obcTableFormat = obcTreeTable?.Format;
            var obcTableRowsFormat = obcTreeTable?.TableRows?.RowsFormat;
            var obcFooterRowsFormat = obcTreeTable?.TableRows?.FooterRows?.Format;
            var obcTableColumns = obcTreeTable?.TableColumns;
            var obcTableColumnsFormat = obcTableColumns?.ColumnsFormat;

            IReadOnlyList<TreeTableRow> treeTableRows = obcTreeTable?.TableRows?.FooterRows?.Rows?.Select(
                obcFooterRow => obcFooterRow.ToVuescapeTreeTableFooterRow(
                    obcTableFormat,
                    obcTableRowsFormat,
                    obcFooterRowsFormat,
                    obcFooterRow?.Format,
                    obcTableColumnsFormat,
                    obcTableColumns?.Columns,
                    obcToVuescapeConversionContext))
                ?.ToList();

            return treeTableRows;
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

            IReadOnlyList<TreeTableRow> treeTableRows = obcTreeTable?.TableRows?.DataRows?.Rows?.Select(
                obcDataRow => obcDataRow.ToVuescapeTreeTableRow(
                    obcTableFormat,
                    obcTableRowsFormat,
                    obcDataRowsFormat,
                    obcDataRow.Format,
                    obcTableColumnsFormat,
                    obcTableColumns?.Columns,
                    null,
                    obcToVuescapeConversionContext))
                ?.ToList();

            return treeTableRows;
        }
    }
}
