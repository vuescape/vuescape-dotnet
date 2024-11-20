// <copyright file="ObcRowBaseExtensions.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    using System.Collections.Generic;
    using System.Linq;
    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.CodeAnalysis.Recipes;
    using OBeautifulCode.DataStructure;

    /// <summary>
    /// Extension methods on all subtypes of <see cref="OBeautifulCode.DataStructure.RowBase"/>.
    /// </summary>
    public static partial class ObcRowBaseExtensions
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
        /// <param name="isLastRow">Is this the last row in the header.  Used to apply sorting to only the last row.</param>
        /// <param name="obcToVuescapeConversionContext">The conversion context.</param>
        /// <returns>A <see cref="TreeTableHeaderRow"/>.</returns>
        public static TreeTableHeaderRow ToVuescapeTreeTableHeaderRow(
            this OBeautifulCode.DataStructure.FlatRow obcHeaderRow,
            TableFormat obcTableFormat,
            RowFormat obcRowsFormat,
            HeaderRowsFormat obcHeaderRowsFormat,
            RowFormat obcHeaderRowFormat,
            ColumnFormat obcColumnFormat,
            IReadOnlyList<Column> obcColumns,
            bool isLastRow,
            ObcToVuescapeConversionContext obcToVuescapeConversionContext)
        {
            new { obcHeaderRow }.AsArg().Must().NotBeNull();

            // TODO: Apply formatting.
            var cssClasses = string.Empty;
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
                        obcColumns[actualColumnIndex],
                        isLastRow,
                        obcToVuescapeConversionContext),
                };

                var columnsSpanned = obcHeaderRowCell.ColumnsSpanned ?? 1;
                actualColumnIndex += columnsSpanned;

                for (var additionalColumnIndex = 1; additionalColumnIndex < columnsSpanned; additionalColumnIndex++)
                {
                    // make cell visible but hidden to allow colspan sizing to work properly
                    headerCells.Add(TreeTableHeaderCell.CreateHiddenCell());
                }

                return headerCells;
            }).ToList();

            // TODO: classes/styles
            // TODO: Renderer? Is there a default?
            var result = new TreeTableHeaderRow(rowId, treeTableHeaderCells, cssClasses);
            return result;
        }

        /// <summary>
        /// Convert a Footer <see cref="FlatRow"/> to a <see cref="TreeTableRow"/>.
        /// </summary>
        /// <param name="obcFooterRow">The header row.</param>
        /// <param name="obcTableFormat">The table format.</param>
        /// <param name="obcRowsFormat">The table rows format.</param>
        /// <param name="obcFooterRowsFormat">The footer rows format.</param>
        /// <param name="obcFooterRowFormat">The footer row format.</param>
        /// <param name="obcColumnFormat">The column format.</param>
        /// <param name="obcColumns">The list of Columns.</param>
        /// <param name="obcToVuescapeConversionContext">The conversion context.</param>
        /// <returns>A <see cref="TreeTableHeaderRow"/>.</returns>
        public static TreeTableRow ToVuescapeTreeTableFooterRow(
            this OBeautifulCode.DataStructure.FlatRow obcFooterRow,
            TableFormat obcTableFormat,
            RowFormat obcRowsFormat,
            FooterRowsFormat obcFooterRowsFormat,
            RowFormat obcFooterRowFormat,
            ColumnFormat obcColumnFormat,
            IReadOnlyList<Column> obcColumns,
            ObcToVuescapeConversionContext obcToVuescapeConversionContext)
        {
            new { obcFooterRow }.AsArg().Must().NotBeNull();

            // TODO: Apply formatting.
            var cssClasses = string.Empty;
            var rowId = obcFooterRow.Id;

            var actualColumnIndex = 0;
            var treeTableFooterCells = obcFooterRow.Cells.SelectMany((obcHeaderRowCell, columnIndex) =>
            {
                var headerCells = new List<TreeTableCell>
                {
                    obcHeaderRowCell.ToVuescapeTreeTableCell(
                        obcTableFormat,
                        obcRowsFormat,
                        obcFooterRowsFormat != null
                            ? new DataRowsFormat(
                                obcFooterRowsFormat.OuterBorders,
                                obcFooterRowsFormat.InnerBorders,
                                obcFooterRowsFormat.RowsFormat)
                            : null,
                        obcFooterRowFormat,
                        obcColumnFormat,
                        obcColumns[actualColumnIndex],
                        obcToVuescapeConversionContext),
                };

                var columnsSpanned = obcHeaderRowCell.ColumnsSpanned ?? 1;
                actualColumnIndex += columnsSpanned;

                for (var additionalColumnIndex = 1; additionalColumnIndex < columnsSpanned; additionalColumnIndex++)
                {
                    // make cell visible but hidden to allow colspan sizing to work properly
                    headerCells.Add(TreeTableCell.CreateHiddenCell());
                }

                return headerCells;
            }).ToList();

            // TODO: classes/styles
            // TODO: Renderer? Is there a default?
            var result = new TreeTableRow(
                rowId,
                treeTableFooterCells,
                null,
                cssClasses,
                null,
                null,
                false,
                false,
                true,
                false,
                false,
                null,
                null);

            return result;
        }

        /// <summary>
        /// Convert a <see cref="Row"/> to a <see cref="TreeTableRow"/>.
        /// </summary>
        /// <param name="obcRowBase">The row.</param>
        /// <param name="obcTableFormat">The table format.</param>
        /// <param name="obcRowsFormat">The table rows format.</param>
        /// <param name="obcDataRowsFormat">The data rows format.</param>
        /// <param name="obcRowFormat">The header row format.</param>
        /// <param name="obcColumnFormat">The column format.</param>
        /// <param name="obcColumns">The list of Columns.</param>
        /// <param name="depth">The depth in the TreeTable hierarchy.</param>
        /// <param name="shouldIncludeSummaryRows">Should the summary rows be included in the conversion.</param>
        /// <param name="obcToVuescapeConversionContext">The conversion context.</param>
        /// <returns>A <see cref="TreeTableHeaderRow"/>.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling", Justification = ObcSuppressBecause.CA1506_AvoidExcessiveClassCoupling_DisagreeWithAssessment)]
        public static TreeTableRow ToVuescapeTreeTableRow(
            this OBeautifulCode.DataStructure.RowBase obcRowBase,
            TableFormat obcTableFormat,
            RowFormat obcRowsFormat,
            DataRowsFormat obcDataRowsFormat,
            RowFormat obcRowFormat,
            ColumnFormat obcColumnFormat,
            IReadOnlyList<Column> obcColumns,
            int? depth,
            bool shouldIncludeSummaryRows,
            ObcToVuescapeConversionContext obcToVuescapeConversionContext)
        {
            new { obcRowBase }.AsArg().Must().NotBeNull();

            var rowIndentLevel = depth ?? 0;

            // TODO: Apply formatting.
            var rowId = obcRowBase.Id;

            var treeTableCells = new List<TreeTableCell>();
            var columnIndex = 0;
            foreach (var obcRowCell in obcRowBase.Cells)
            {
                var treeTableCell = obcRowCell.ToVuescapeTreeTableCell(
                    obcTableFormat,
                    obcRowsFormat,
                    obcDataRowsFormat,
                    obcRowFormat,
                    obcColumnFormat,
                    obcColumns[columnIndex],
                    obcToVuescapeConversionContext);

                var columnsSpanned = obcRowCell.ColumnsSpanned ?? 1;

                treeTableCells.Add(treeTableCell);
                columnIndex += columnsSpanned;

                for (var additionalColumnIndex = 1; additionalColumnIndex < columnsSpanned; additionalColumnIndex++)
                {
                    // make cell visible but hidden to allow colspan sizing to work properly
                    treeTableCells.Add(TreeTableCell.CreateHiddenCell());
                }
            }

            // TODO: classes/styles
            // TODO: Renderer? Is there a default?
            // TODO: isSelected
            // TODO: isFocused
            // TODO: links
            string cssStyles = null;

            // cssStyles += "tree-table__display--none";
            var hasChildRows = obcRowBase.HasChildRows();
            var isExpandable = hasChildRows && (!obcRowBase.Format?.Options.IsNotExpandable() ?? false);
            var shouldAlignChildRowsWithParent = obcRowBase.Format?.Options.ShouldAlignChildRowsWithParent() ?? false;
            var isVisible = obcRowBase.Format?.Options.IsVisible() ?? true;
            var isExpanded = !isVisible && shouldAlignChildRowsWithParent;

            IReadOnlyList<TreeTableRow> children = null;
            IReadOnlyList<TreeTableRow> collapsedSummaryRows = null;
            IReadOnlyList<TreeTableRow> expandedSummaryRows = null;

            if (obcRowBase is Row obcRow)
            {
                if (hasChildRows)
                {
                    var childIndentLevel = shouldAlignChildRowsWithParent ? rowIndentLevel : rowIndentLevel + 1;
                    children = obcRow.ChildRows.Select(_ =>
                            _.ToVuescapeTreeTableRow(
                                obcTableFormat,
                                obcRowsFormat,
                                obcDataRowsFormat,
                                _.Format,
                                obcColumnFormat,
                                obcColumns,
                                childIndentLevel,
                                shouldIncludeSummaryRows,
                                obcToVuescapeConversionContext))
                        .ToList();
                }

                if (obcRow.HasExpandedSummaryRows() && shouldIncludeSummaryRows)
                {
                    expandedSummaryRows = obcRow.ExpandedSummaryRows.Select(_ =>
                    {
                        var row = new Row(_.Cells, _.Id, _.Format);
                        return row.ToVuescapeTreeTableRow(
                            obcTableFormat,
                            obcRowsFormat,
                            obcDataRowsFormat,
                            _.Format,
                            obcColumnFormat,
                            obcColumns,
                            rowIndentLevel,
                            true,
                            obcToVuescapeConversionContext);
                    }).ToList();
                }

                if (obcRow.HasCollapsedSummaryRows() && shouldIncludeSummaryRows)
                {
                    collapsedSummaryRows = obcRow.CollapsedSummaryRows.Select(_ =>
                    {
                        var row = new Row(_.Cells, _.Id, _.Format);
                        return row.ToVuescapeTreeTableRow(
                            obcTableFormat,
                            obcRowsFormat,
                            obcDataRowsFormat,
                            _.Format,
                            obcColumnFormat,
                            obcColumns,
                            rowIndentLevel,
                            true,
                            obcToVuescapeConversionContext);
                    }).ToList();
                }
            }

            var result = new TreeTableRow(
                rowId,
                treeTableCells,
                rowIndentLevel,
                cssStyles,
                null,
                null,
                isExpandable,
                isExpanded,
                isVisible,
                false,
                false,
                null,
                children,
                true,
                expandedSummaryRows,
                collapsedSummaryRows);

            return result;
        }

        private static bool HasChildRows(
            this OBeautifulCode.DataStructure.RowBase obcRowBase)
        {
            if (obcRowBase is Row obcRow)
            {
                var result = obcRow.ChildRows != null && obcRow.ChildRows.Any();
                return result;
            }

            return false;
        }

        private static bool HasExpandedSummaryRows(
            this OBeautifulCode.DataStructure.Row obcRow)
        {
            var result = obcRow.ExpandedSummaryRows != null && obcRow.ExpandedSummaryRows.Any();
            return result;
        }

        private static bool HasCollapsedSummaryRows(
            this OBeautifulCode.DataStructure.Row obcRow)
        {
            var result = obcRow.CollapsedSummaryRows != null && obcRow.CollapsedSummaryRows.Any();
            return result;
        }
    }
}