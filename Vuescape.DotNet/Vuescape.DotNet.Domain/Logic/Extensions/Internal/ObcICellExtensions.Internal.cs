// <copyright file="ObcICellExtensions.Internal.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>

// ReSharper disable once CheckNamespace

namespace Vuescape.DotNet.Domain
{
    using System.Collections.Generic;

    using OBeautifulCode.DataStructure;

    /// <summary>
    /// Extension methods on <see cref="OBeautifulCode.DataStructure.ICell"/>.
    /// </summary>
    internal static partial class ObcICellExtensions
    {
        /// <summary>
        /// Convert an <see cref="ICell"/> to a <see cref="TreeTableCell"/>.
        /// </summary>
        /// <param name="obcRowCell">The cell.</param>
        /// <param name="obcTableFormat">The table format.</param>
        /// <param name="obcRowsFormat">The table rows format.</param>
        /// <param name="obcDataRowsFormat">The data rows format.</param>
        /// <param name="obcColumnFormat">The column format.</param>
        /// <param name="obcColumn">The Column.</param>
        /// <param name="treeTableConversionMode">The TreeTable conversion mode.</param>
        /// <returns>A <see cref="TreeTableCell"/>.</returns>
        internal static TreeTableCell ToVuescapeTreeTableCell(
            this ICell obcRowCell,
            TableFormat obcTableFormat,
            RowFormat obcRowsFormat,
            DataRowsFormat obcDataRowsFormat,
            ColumnFormat obcColumnFormat,
            Column obcColumn,
            TreeTableConversionMode treeTableConversionMode = TreeTableConversionMode.Relaxed)
        {
            var displayValue = string.Empty;
            var slots = new Dictionary<string, UiObject>();
            string defaultSlot = null;

            if (obcRowCell is IHaveDisplayValueCell displayValueCell)
            {
                displayValue = displayValueCell.DisplayValue;
            }

            if (obcRowCell is IHaveValueCell valueCell)
            {
                slots.Add("value", new UiObject(valueCell.GetCellValue()));
                defaultSlot = "value";
            }

            if (obcRowCell is SlottedCell slottedCell)
            {
                foreach (var kvp in slottedCell.SlotIdToCellMap)
                {
                    slots.Add(kvp.Key, new UiObject(kvp.Value.GetCellValue()));
                }

                defaultSlot = slottedCell.DefaultSlotName;
            }

            if (obcRowCell is ColumnSpanningSlottedCell columnSpanningSlottedCell)
            {
                foreach (var kvp in columnSpanningSlottedCell.SlotIdToCellMap)
                {
                    slots.Add(kvp.Key, new UiObject(kvp.Value.GetCellValue()));
                }

                defaultSlot = columnSpanningSlottedCell.DefaultSlotName;
            }

            var colspan = 1;
            if (obcRowCell is IColumnSpanningCell columnSpanningCell)
            {
                colspan = columnSpanningCell.ColumnsSpanned;
            }

            Hover hover = null;
            if (obcRowCell is IHaveHoverOverCell hoverOverCell)
            {
                var hoverOver = hoverOverCell.HoverOver;

                if (hoverOver is StringHoverOver stringHoverOver)
                {
                    hover = new Hover(null, stringHoverOver.Value, ContentKind.Plaintext);
                }
                else if (hoverOver is HtmlHoverOver htmlHover)
                {
                    hover = new Hover(null, htmlHover.Html, ContentKind.Html);
                }
            }

            var isVisible = obcColumn.Format.Options.IsVisible();

            // TODO: Renderer? Is there a default?
            // TODO: classes/styles (formatting)
            var cssClasses = "tree-table-cell__td";

            // TODO: Add links if applicable
            SlottedUiObject slottedUiObject = null;
            if (slots.Count > 0)
            {
                // TODO: Get active slot from OBC
                slottedUiObject = new SlottedUiObject(slots, defaultSlot);
            }

            var result = new TreeTableCell(obcRowCell.Id, displayValue, hover, null, cssClasses, null, colspan, isVisible, null, slottedUiObject);
            return result;
        }

        /// <summary>
        /// Convert an <see cref="ICell"/> to a <see cref="TreeTableHeaderCell"/>.
        /// </summary>
        /// <param name="obcHeaderRowCell">The header cell.</param>
        /// <param name="obcTableFormat">The table format.</param>
        /// <param name="obcRowsFormat">The table rows format.</param>
        /// <param name="obcHeaderRowsFormat">The header rows format.</param>
        /// <param name="obcColumnFormat">The column format.</param>
        /// <param name="obcColumn">The Column.</param>
        /// <param name="treeTableConversionMode">The TreeTable conversion mode.</param>
        /// <returns>A <see cref="TreeTableHeaderCell"/>.</returns>
        internal static TreeTableHeaderCell ToVuescapeTreeTableHeaderCell(
            this ICell obcHeaderRowCell,
            TableFormat obcTableFormat,
            RowFormat obcRowsFormat,
            HeaderRowsFormat obcHeaderRowsFormat,
            ColumnFormat obcColumnFormat,
            Column obcColumn,
            TreeTableConversionMode treeTableConversionMode = TreeTableConversionMode.Relaxed)
        {
            string displayValue = null;
            if (obcHeaderRowCell is IHaveDisplayValueCell displayValueCell)
            {
                displayValue = displayValueCell.DisplayValue;
            }

            if (displayValue == null && obcHeaderRowCell is IHaveValueCell valueCell)
            {
                // Assuming this cell value is string for header.
                displayValue = valueCell.GetCellValue().ToString();
            }

            var colspan = 1;
            if (obcHeaderRowCell is IColumnSpanningCell columnSpanningCell)
            {
                colspan = columnSpanningCell.ColumnsSpanned;
            }

            Hover hover = null;
            if (obcHeaderRowCell is IHaveHoverOverCell hoverOverCell)
            {
                var hoverOver = hoverOverCell.HoverOver;

                if (hoverOver is StringHoverOver stringHoverOver)
                {
                    hover = new Hover(null, stringHoverOver.Value, ContentKind.Plaintext);
                }
                else if (hoverOver is HtmlHoverOver htmlHover)
                {
                    hover = new Hover(null, htmlHover.Html, ContentKind.Html);
                }
            }

            var isVisible = obcColumn.Format.Options.IsVisible();
            var isSortable = obcColumn.Format.Options.IsSortable();

            ColumnSorter columnSorter = null;
            if (isSortable)
            {
                columnSorter = new ColumnSorter(obcColumn.Format.Options.GetSortDirection(), SortComparisonStrategy.Default);
            }

            // TODO: Renderer? Is there a default?
            // TODO: classes/styles (formatting)
            var cssClasses = "tree-table-cell__th";

            // TODO: Add links if applicable
            var result = new TreeTableHeaderCell(obcHeaderRowCell.Id, displayValue, hover, null, cssClasses, null, colspan, isVisible, columnSorter);
            return result;
        }
    }
}
