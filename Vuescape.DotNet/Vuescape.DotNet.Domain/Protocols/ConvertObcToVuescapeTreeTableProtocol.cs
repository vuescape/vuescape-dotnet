// <copyright file="ConvertObcToVuescapeTreeTableProtocol.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using OBeautifulCode.Type;

    using static System.FormattableString;

    /// <summary>
    /// Executes a <see cref="ConvertObcToVuescapeTreeTableOp"/>.
    /// </summary>
    public class ConvertObcToVuescapeTreeTableProtocol
        : SyncSpecificReturningProtocolBase<ConvertObcToVuescapeTreeTableOp, TreeTable>
    {
        /// <summary>
        /// Executes a <see cref="ConvertObcToVuescapeTreeTableOp"/>.
        /// </summary>
        /// <param name="operation">The operation to execute.</param>
        /// <returns>A TreeTable.</returns>
        public override TreeTable Execute(
            ConvertObcToVuescapeTreeTableOp operation)
        {
            var obcTreeTable = operation.ObcTreeTable;

            if (operation.TreeTableConversionMode == TreeTableConversionMode.Strict)
            {
                // Validate that only first column is frozen
                if (obcTreeTable.TableColumns.Columns.Skip(1).Any(_ => _.Format.Options.IsFrozen()))
                {
                    throw new InvalidOperationException(Invariant(
                        $"TreeTable only supports freezing the first column. One or more ColumnFormatOptions that are not the first column are defined as frozen. Either change the ColumnFormatOptions or set TreeTableConversionMode to Relaxed."));
                }
            }

            var columnDefinitions = ConvertToVuescapeColumnDefinitions(obcTreeTable, operation.TreeTableConversionMode);

            var treeTableHeaders = ConvertToVuescapeTreeTableHeaderRows(obcTreeTable, operation.TreeTableConversionMode);
            var treeTableRows = ConvertToVuescapeTreeTableRows(obcTreeTable, operation.TreeTableConversionMode);

            // Default to false
            var isFirstColumnFrozen = obcTreeTable.TableColumns?.Columns[0]?.Format?.Options.IsFrozen() ?? false;

            // Default to true
            var shouldSyncHeaderRow = obcTreeTable.TableRows?.HeaderRows?.Format?.RowsFormat?.Options.IsFrozen() ?? true;

            // TODO: cssStyle
            // TODO: cssClass
            var treeTableContent = new TreeTableContent(
                treeTableHeaders,
                treeTableRows,
                true, // Defaulting to allow scrolling
                true, // Defaulting to allow scrolling
                shouldSyncHeaderRow,
                false,
                false,
                isFirstColumnFrozen,
                null,
                null,
                null,
                null);

            // TODO: Add default behaviors.
            // TODO: Determine specific behaviors to add based on parameter data.
            return new TreeTable(null, columnDefinitions, treeTableContent);
        }

        private static IReadOnlyList<ColumnDefinition> ConvertToVuescapeColumnDefinitions(
            OBeautifulCode.DataStructure.TreeTable obcTreeTable,
            TreeTableConversionMode treeTableConversionMode)
        {
            var obcTableFormat = obcTreeTable.Format;
            var obcTableRowsFormat = obcTreeTable.TableRows.RowsFormat;
            var obcHeaderRowsFormat = obcTreeTable.TableRows.HeaderRows.Format;
            var obcTableColumns = obcTreeTable.TableColumns;
            var obcTableColumnsFormat = obcTableColumns.ColumnsFormat;

            // TODO: Is this the right order of formatting for column definition. Using same approach as elsewhere with rows before columns
            IReadOnlyList<ColumnDefinition> columnDefinitions =
                obcTreeTable.TableColumns.Columns.Select(
                    obcColumn => obcColumn.ToColumnDefinition(
                        null,
                        obcHeaderRowsFormat,
                        obcTableRowsFormat,
                        obcColumn.Format,
                        obcTableColumnsFormat,
                        obcTableFormat,
                        treeTableConversionMode))
                .ToList();

            return columnDefinitions;
        }

        private static IReadOnlyList<TreeTableHeaderRow> ConvertToVuescapeTreeTableHeaderRows(
            OBeautifulCode.DataStructure.TreeTable obcTreeTable,
            TreeTableConversionMode treeTableConversionMode)
        {
            var obcTableFormat = obcTreeTable.Format;
            var obcTableRowsFormat = obcTreeTable.TableRows.RowsFormat;
            var obcHeaderRowsFormat = obcTreeTable.TableRows.HeaderRows.Format;
            var obcTableColumns = obcTreeTable.TableColumns;
            var obcTableColumnsFormat = obcTableColumns.ColumnsFormat;

            IReadOnlyList<TreeTableHeaderRow> treeTableHeaderRows = obcTreeTable.TableRows.HeaderRows.Rows.Select(
                obcHeaderRow => obcHeaderRow.ToVuescapeTreeTableHeaderRow(
                    obcTableFormat,
                    obcTableRowsFormat,
                    obcHeaderRowsFormat,
                    obcHeaderRow.Format,
                    obcTableColumnsFormat,
                    obcTableColumns.Columns,
                    treeTableConversionMode))
                .ToList();

            return treeTableHeaderRows;
        }

        private static IReadOnlyList<TreeTableRow> ConvertToVuescapeTreeTableRows(
            OBeautifulCode.DataStructure.TreeTable obcTreeTable,
            TreeTableConversionMode treeTableConversionMode)
        {
            var obcTableFormat = obcTreeTable.Format;
            var obcTableRowsFormat = obcTreeTable.TableRows.RowsFormat;
            var obcDataRowsFormat = obcTreeTable.TableRows.DataRows.Format;
            var obcTableColumns = obcTreeTable.TableColumns;
            var obcTableColumnsFormat = obcTableColumns.ColumnsFormat;

            if (obcTreeTable?.TableRows?.DataRows?.Rows == null)
            {
                return null;
            }

            IReadOnlyList<TreeTableRow> treeTableRows = obcTreeTable.TableRows.DataRows.Rows.Select(
                obcDataRow => obcDataRow.ToVuescapeTreeTableRow(
                    obcTableFormat,
                    obcTableRowsFormat,
                    obcDataRowsFormat,
                    obcDataRow.Format,
                    obcTableColumnsFormat,
                    obcTableColumns.Columns,
                    null,
                    treeTableConversionMode))
                .ToList();

            return treeTableRows;
        }
    }
}
