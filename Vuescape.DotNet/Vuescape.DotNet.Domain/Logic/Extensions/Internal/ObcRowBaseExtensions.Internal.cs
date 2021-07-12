﻿// <copyright file="ObcRowBaseExtensions.Internal.cs" company="Vuescape">
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
        /// <param name="obcColumnFormat">The column format.</param>
        /// <param name="obcColumns">The list of Columns.</param>
        /// <param name="treeTableConversionMode">The TreeTable conversion mode.</param>
        /// <returns>A <see cref="TreeTableHeaderRow"/>.</returns>
        internal static TreeTableHeaderRow ToVuescapeTreeTableHeaderRow(
            this OBeautifulCode.DataStructure.FlatRow obcHeaderRow,
            TableFormat obcTableFormat,
            RowFormat obcRowsFormat,
            HeaderRowsFormat obcHeaderRowsFormat,
            ColumnFormat obcColumnFormat,
            IReadOnlyList<Column> obcColumns,
            TreeTableConversionMode treeTableConversionMode = TreeTableConversionMode.Relaxed)
        {
            // TODO: Apply formatting.
            var rowId = obcHeaderRow.Id;

            var treeTableHeaderCells = obcHeaderRow.Cells.Select((obcHeaderRowCell, columnIndex) => obcHeaderRowCell.ToVuescapeTreeTableHeaderCell(obcTableFormat, obcRowsFormat, obcHeaderRowsFormat, obcColumnFormat, obcColumns[columnIndex])).ToList();

            // TODO: classes/styles
            // TODO: Renderer? Is there a default?
            var result = new TreeTableHeaderRow(rowId, treeTableHeaderCells);
            return result;
        }

        /// <summary>
        /// Convert a <see cref="Row"/> to a <see cref="TreeTableRow"/>.
        /// </summary>
        /// <param name="obcRow">The row.</param>
        /// <param name="obcTableFormat">The table format.</param>
        /// <param name="obcRowsFormat">The table rows format.</param>
        /// <param name="obcDataRowsFormat">The data rows format.</param>
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
            ColumnFormat obcColumnFormat,
            IReadOnlyList<Column> obcColumns,
            int depth,
            TreeTableConversionMode treeTableConversionMode = TreeTableConversionMode.Relaxed)
        {
            // TODO: Apply formatting.
            var rowId = obcRow.Id;

            var treeTableCells = new List<TreeTableCell>();
            var columnIndex = 0;
            foreach (var obcRowCell in obcRow.Cells)
            {
                var treeTableCell = obcRowCell.ToVuescapeTreeTableCell(obcTableFormat, obcRowsFormat, obcDataRowsFormat, obcColumnFormat, obcColumns[columnIndex++]);
                treeTableCells.Add(treeTableCell);
            }

            // TODO: classes/styles
            // TODO: Renderer? Is there a default?
            // TODO: isSelected
            // TODO: isFocused
            // TODO: links
            var isVisible = obcRow.Format.Options.IsVisible();
            var isExpandable = obcRow.ChildRows.Count > 0 && !obcRow.Format.Options.IsNotExpandable();

            IReadOnlyList<TreeTableRow> children = null;
            if (obcRow.ChildRows.Count > 0)
            {
                children = obcRow.ChildRows.Select(_ => _.ToVuescapeTreeTableRow(obcTableFormat, obcRowsFormat, obcDataRowsFormat, obcColumnFormat, obcColumns, depth + 1)).ToList();
            }

            var result = new TreeTableRow(rowId, treeTableCells, depth, null, null, null, isExpandable, false, isVisible, false, false, null, children);
            return result;
        }
    }
}
