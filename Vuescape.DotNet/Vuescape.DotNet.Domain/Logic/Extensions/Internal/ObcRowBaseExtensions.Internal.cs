// <copyright file="ObcRowBaseExtensions.Internal.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    using System.Collections.Generic;
    using System.Linq;

    using OBeautifulCode.DataStructure;

    /// <summary>
    /// Extension methods on all subtypes of <see cref="OBeautifulCode.DataStructure.RowBase"/>.
    /// </summary>
    internal static partial class ObcRowBaseExtensions
    {
        /// <summary>
        /// Convert a header <see cref="FlatRow"/> to a <see cref="TreeTableHeaderRow"/>.
        /// </summary>
        /// <param name="obcHeaderRow">The header row.</param>
        /// <param name="obcTableFormat">The table format.</param>
        /// <param name="obcRowsFormat">The table rows format.</param>
        /// <param name="obcHeaderRowsFormat">The header rows format.</param>
        /// <param name="obcHeaderRowFormat">The header row format.</param>
        /// <param name="obcColumnFormat">The column format.</param>
        /// <param name="obcColumns">The list of Columns.</param>
        /// <param name="treeTableConversionMode">The TreeTable conversion mode.</param>
        /// <returns>A <see cref="TreeTableHeaderRow"/>.</returns>
        internal static TreeTableHeaderRow ToVuescapeTreeTableHeaderRow(
            this OBeautifulCode.DataStructure.FlatRow obcHeaderRow,
            TableFormat obcTableFormat,
            RowFormat obcRowsFormat,
            HeaderRowsFormat obcHeaderRowsFormat,
            RowFormat obcHeaderRowFormat,
            ColumnFormat obcColumnFormat,
            IReadOnlyList<Column> obcColumns,
            TreeTableConversionMode treeTableConversionMode = TreeTableConversionMode.Relaxed)
        {
            // TODO: Apply formatting.
            var cssClasses = "tree-table-row__tr";
            var rowId = obcHeaderRow.Id;

            var actualColumnIndex = 0;
            var treeTableHeaderCells = obcHeaderRow.Cells.SelectMany((obcHeaderRowCell, columnIndex) =>
            {
                var headerCells = new List<TreeTableHeaderCell>
                {
                    obcHeaderRowCell.ToVuescapeTreeTableHeaderCell(
                        obcTableFormat,
                        obcRowsFormat,
                        obcHeaderRowsFormat,
                        obcHeaderRowFormat,
                        obcColumnFormat,
                        obcColumns[actualColumnIndex]),
                };

                var columnsSpanned = obcHeaderRowCell.ColumnsSpanned ?? 1;
                actualColumnIndex += columnsSpanned;

                for (var additionalColumnIndex = 1; additionalColumnIndex < columnsSpanned; additionalColumnIndex++)
                {
                    // make cell visible but hidden to allow colspan sizing to work properly
                    headerCells.Add(new TreeTableHeaderCell(null, null, null, null, "tree-table__display--none", null, null, true, null));
                }

                return headerCells;
            }).ToList();

            // TODO: classes/styles
            // TODO: Renderer? Is there a default?
            var result = new TreeTableHeaderRow(rowId, treeTableHeaderCells, cssClasses);
            return result;
        }

        /// <summary>
        /// Convert a <see cref="Row"/> to a <see cref="TreeTableRow"/>.
        /// </summary>
        /// <param name="obcRow">The row.</param>
        /// <param name="obcTableFormat">The table format.</param>
        /// <param name="obcRowsFormat">The table rows format.</param>
        /// <param name="obcDataRowsFormat">The data rows format.</param>
        /// <param name="obcRowFormat">The header row format.</param>
        /// <param name="obcColumnFormat">The column format.</param>
        /// <param name="obcColumns">The list of Columns.</param>
        /// <param name="depth">The depth in the TreeTable hierarchy.</param>
        /// <param name="treeTableConversionMode">The TreeTable conversion mode.</param>
        /// <returns>A <see cref="TreeTableHeaderRow"/>.</returns>
        internal static TreeTableRow ToVuescapeTreeTableRow(
            this OBeautifulCode.DataStructure.Row obcRow,
            TableFormat obcTableFormat,
            RowFormat obcRowsFormat,
            DataRowsFormat obcDataRowsFormat,
            RowFormat obcRowFormat,
            ColumnFormat obcColumnFormat,
            IReadOnlyList<Column> obcColumns,
            int? depth,
            TreeTableConversionMode treeTableConversionMode = TreeTableConversionMode.Relaxed)
        {
            // TODO: Apply formatting.
            var rowId = obcRow.Id;

            var treeTableCells = new List<TreeTableCell>();
            var columnIndex = 0;
            foreach (var obcRowCell in obcRow.Cells)
            {
                var treeTableCell = obcRowCell.ToVuescapeTreeTableCell(obcTableFormat, obcRowsFormat, obcDataRowsFormat, obcRowFormat, obcColumnFormat, obcColumns[columnIndex]);
                var columnsSpanned = obcRowCell.ColumnsSpanned ?? 1;

                treeTableCells.Add(treeTableCell);
                columnIndex += columnsSpanned;

                for (var additionalColumnIndex = 1; additionalColumnIndex < columnsSpanned; additionalColumnIndex++)
                {
                    // make cell visible but hidden to allow colspan sizing to work properly
                    treeTableCells.Add(new TreeTableCell(null, null, null, null, "tree-table__display--none", null, null, true, null));
                }
            }

            // TODO: classes/styles
            // TODO: Renderer? Is there a default?
            // TODO: isSelected
            // TODO: isFocused
            // TODO: links
            var isVisible = obcRow.Format?.Options.IsVisible() ?? true;
            var hasChildRows = HasChildRows(obcRow);
            var isExpandable = hasChildRows && (!obcRow.Format?.Options.IsNotExpandable() ?? false);

            IReadOnlyList<TreeTableRow> children = null;
            if (hasChildRows)
            {
                if (depth == null)
                {
                    depth = 0;
                }

                children = obcRow.ChildRows.Select(_ => _.ToVuescapeTreeTableRow(obcTableFormat, obcRowsFormat, obcDataRowsFormat, obcRow.Format, obcColumnFormat, obcColumns, depth + 1)).ToList();
            }

            var result = new TreeTableRow(rowId, treeTableCells, depth, null, null, null, isExpandable, false, isVisible, false, false, null, children);
            return result;
        }

        private static bool HasChildRows(
            OBeautifulCode.DataStructure.Row obcRow)
        {
            var result = (obcRow.ChildRows?.Count ?? 0) > 0;
            return result;
        }
    }
}
