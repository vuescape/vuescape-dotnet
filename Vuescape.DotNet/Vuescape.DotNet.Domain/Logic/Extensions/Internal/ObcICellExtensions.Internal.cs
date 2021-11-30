// <copyright file="ObcICellExtensions.Internal.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;

    using OBeautifulCode.DataStructure;

    using static System.FormattableString;

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
        /// <param name="obcRowFormat">The row format.</param>
        /// <param name="obcColumnFormat">The column format.</param>
        /// <param name="obcColumn">The Column.</param>
        /// <param name="treeTableConversionMode">The TreeTable conversion mode.</param>
        /// <returns>A <see cref="TreeTableCell"/>.</returns>
        internal static TreeTableCell ToVuescapeTreeTableCell(
            this ICell obcRowCell,
            TableFormat obcTableFormat,
            RowFormat obcRowsFormat,
            DataRowsFormat obcDataRowsFormat,
            RowFormat obcRowFormat,
            ColumnFormat obcColumnFormat,
            Column obcColumn,
            TreeTableConversionMode treeTableConversionMode = TreeTableConversionMode.Relaxed)
        {
            var displayValue = string.Empty;
            var slots = new Dictionary<string, UiObject>();
            string defaultSlot = null;

            // if (obcRowCell is IHaveDisplayValueCell displayValueCell)
            // {
            //    displayValue = displayValueCell.DisplayValue;
            // }

            // if (obcRowCell is IHaveValueCell valueCell)
            // {
            //    slots.Add("value", new UiObject(valueCell.GetCellValue()));
            //    defaultSlot = "value";
            // }

            if (obcRowCell is SlottedCell slottedCell)
            {
                foreach (var kvp in slottedCell.SlotIdToCellMap)
                {
                    // slots.Add(kvp.Key, new UiObject(kvp.Value.GetCellValue()));
                }

                // defaultSlot = slottedCell.DefaultSlotName;
            }

            // if (obcRowCell is ColumnSpanningSlottedCell columnSpanningSlottedCell)
            // {
            //    foreach (var kvp in columnSpanningSlottedCell.SlotIdToCellMap)
            //    {
            //        slots.Add(kvp.Key, new UiObject(kvp.Value.GetCellValue()));
            //    }

            // defaultSlot = columnSpanningSlottedCell.DefaultSlotName;
            // }

            var colspan = 1;
            // if (obcRowCell is IColumnSpanningCell columnSpanningCell)
            // {
            //    colspan = columnSpanningCell.ColumnsSpanned;
            // }

            Hover hover = null;
            // if (obcRowCell is IHaveHoverOverCell hoverOverCell)
            // {
            //    var hoverOver = hoverOverCell.HoverOver;

            // if (hoverOver is StringHoverOver stringHoverOver)
            //    {
            //        hover = new Hover(null, stringHoverOver.Value, ContentKind.Plaintext);
            //    }
            //    else if (hoverOver is HtmlHoverOver htmlHover)
            //    {
            //        hover = new Hover(null, htmlHover.Html, ContentKind.Html);
            //    }
            // }

            var isVisible = obcColumn.Format.Options.IsVisible();

            // TODO: Renderer? Is there a default?
            // TODO: classes/styles (formatting)
            var cssClasses = GetCellFormatOptionsCssClasses(
                obcRowCell,
                obcRowFormat,
                obcDataRowsFormat?.RowsFormat,
                obcRowsFormat,
                obcColumn.Format,
                obcColumnFormat,
                obcTableFormat,
                "tree-table-cell__td",
                treeTableConversionMode);

            // TODO: Add links if applicable
            SlottedUiObject slottedUiObject = null;
            if (slots.Count > 0)
            {
                // TODO: Get active slot from OBC
                slottedUiObject = new SlottedUiObject(slots, defaultSlot);
            }

            var cellFormat = GetCellFormat(
                obcRowCell,
                obcRowFormat,
                obcDataRowsFormat?.RowsFormat,
                obcRowsFormat,
                obcColumn.Format,
                obcColumnFormat,
                obcTableFormat,
                treeTableConversionMode);

            var links = new Dictionary<string, Link>()
            {
                { "__vs_self",  new Link("source", LinkTarget.CenterPane, null, new CssStyles(new CssStyleWrapper("test: bold;"), null, null, null, null, null)) },
            };

            var result = new TreeTableCell(obcRowCell.Id, displayValue, hover, null, cssClasses, null, colspan, isVisible, cellFormat, links, slottedUiObject);
            return result;
        }

        /// <summary>
        /// Convert an <see cref="ICell"/> to a <see cref="TreeTableHeaderCell"/>.
        /// </summary>
        /// <param name="obcHeaderRowCell">The header cell.</param>
        /// <param name="obcTableFormat">The table format.</param>
        /// <param name="obcRowsFormat">The table rows format.</param>
        /// <param name="obcHeaderRowsFormat">The header rows format.</param>
        /// <param name="obcRowFormat">The row format.</param>
        /// <param name="obcColumnFormat">The column format.</param>
        /// <param name="obcColumn">The Column.</param>
        /// <param name="treeTableConversionMode">The TreeTable conversion mode.</param>
        /// <returns>A <see cref="TreeTableHeaderCell"/>.</returns>
        internal static TreeTableHeaderCell ToVuescapeTreeTableHeaderCell(
            this ICell obcHeaderRowCell,
            TableFormat obcTableFormat,
            RowFormat obcRowsFormat,
            HeaderRowsFormat obcHeaderRowsFormat,
            RowFormat obcRowFormat,
            ColumnFormat obcColumnFormat,
            Column obcColumn,
            TreeTableConversionMode treeTableConversionMode = TreeTableConversionMode.Relaxed)
        {
            string displayValue = null;
            // if (obcHeaderRowCell is IHaveDisplayValueCell displayValueCell)
            // {
            //    displayValue = displayValueCell.DisplayValue;
            // }

            // if (displayValue == null && obcHeaderRowCell is IHaveValueCell valueCell)
            // {
            //    // Assuming this cell value is string for header.
            //    displayValue = valueCell.GetCellValue().ToString();
            // }

            var colspan = 1;
            // if (obcHeaderRowCell is IColumnSpanningCell columnSpanningCell)
            // {
            //    colspan = columnSpanningCell.ColumnsSpanned;
            // }

            Hover hover = null;
            // if (obcHeaderRowCell is IHaveHoverOverCell hoverOverCell)
            // {
            //    var hoverOver = hoverOverCell.HoverOver;

            // if (hoverOver is StringHoverOver stringHoverOver)
            //    {
            //        hover = new Hover(null, stringHoverOver.Value, ContentKind.Plaintext);
            //    }
            //    else if (hoverOver is HtmlHoverOver htmlHover)
            //    {
            //        hover = new Hover(null, htmlHover.Html, ContentKind.Html);
            //    }
            // }

            var isVisible = obcColumn.Format.Options.IsVisible();
            var isSortable = obcColumn.Format.Options.IsSortable();

            ColumnSorter columnSorter = null;
            if (isSortable)
            {
                columnSorter = new ColumnSorter(obcColumn.Format.Options.GetSortDirection(), SortComparisonStrategy.Default);
            }

            // TODO: Renderer? Is there a default?
            // TODO: classes/styles (formatting)
            var cssClasses = GetCellFormatOptionsCssClasses(
                obcHeaderRowCell,
                obcRowFormat,
                obcHeaderRowsFormat?.RowsFormat,
                obcRowsFormat,
                obcColumn.Format,
                obcColumnFormat,
                obcTableFormat,
                "tree-table-cell__th",
                treeTableConversionMode);

            var cellFormat = GetCellFormat(
                obcHeaderRowCell,
                obcRowFormat,
                obcHeaderRowsFormat?.RowsFormat,
                obcRowsFormat,
                obcColumn.Format,
                obcColumnFormat,
                obcTableFormat,
                treeTableConversionMode);

            // TODO: Add links if applicable
            var result = new TreeTableHeaderCell(obcHeaderRowCell.Id, displayValue, hover, null, cssClasses, null, colspan, isVisible, columnSorter, cellFormat);
            return result;
        }

        /// <summary>
        /// Convert a <see cref="Column"/> to a <see cref="ColumnDefinition"/>.
        /// </summary>
        /// <param name="obcColumn">The Column.</param>
        /// <param name="obcRowFormat">The row format.</param>
        /// <param name="obcHeaderRowsFormat">The header rows format.</param>
        /// <param name="obcRowsFormat">The table rows format.</param>
        /// <param name="obcSpecificColumnFormat">The specific column format.</param>
        /// <param name="obcColumnFormat">The column format.</param>
        /// <param name="obcTableFormat">The table format.</param>
        /// <param name="treeTableConversionMode">The TreeTable conversion mode.</param>
        /// <returns>A <see cref="TreeTableHeaderCell"/>.</returns>
        internal static ColumnDefinition ToColumnDefinition(
            this Column obcColumn,
            RowFormat obcRowFormat,
            HeaderRowsFormat obcHeaderRowsFormat,
            RowFormat obcRowsFormat,
            ColumnFormat obcSpecificColumnFormat,
            ColumnFormat obcColumnFormat,
            TableFormat obcTableFormat,
            TreeTableConversionMode treeTableConversionMode = TreeTableConversionMode.Relaxed)
        {
            var shouldCellWrap = ShouldCellWrap(
                null,
                obcRowFormat,
                obcHeaderRowsFormat,
                obcRowsFormat,
                obcSpecificColumnFormat,
                obcColumnFormat,
                obcTableFormat,
                treeTableConversionMode);
            var columnWrapBehavior = shouldCellWrap ? ColumnWrapBehavior.Wrap : ColumnWrapBehavior.NoWrapAndDisplayEllipsis;

            var result = GetColumnDefinition(obcColumn.Format, columnWrapBehavior) ?? GetColumnDefinition(obcColumnFormat, columnWrapBehavior);
            return result;
        }

        private static ColumnDefinition GetColumnDefinition(ColumnFormat obcColumnFormat, ColumnWrapBehavior columnWrapBehavior)
        {
            ColumnDefinition result = null;

            if (obcColumnFormat != null)
            {
                decimal? width = null;
                UnitOfMeasure? widthUnits = null;
                var columnWidthBehavior = ColumnWidthBehavior.None;

                if (obcColumnFormat.AutofitColumnWidth != null && obcColumnFormat.AutofitColumnWidth.Value)
                {
                    columnWrapBehavior = ColumnWrapBehavior.None;
                    columnWidthBehavior = ColumnWidthBehavior.DynamicallySizeToContent;
                }

                if (obcColumnFormat.WidthInPixels != null)
                {
                    if (columnWidthBehavior != ColumnWidthBehavior.DynamicallySizeToContent)
                    {
                        columnWidthBehavior = ColumnWidthBehavior.UseSpecifiedWidth;
                    }

                    width = obcColumnFormat.WidthInPixels;
                    widthUnits = UnitOfMeasure.Pixel;
                }

                result = new ColumnDefinition(columnWidthBehavior, columnWrapBehavior, width, widthUnits);
            }

            return result;
        }

        private static readonly Dictionary<OBeautifulCode.DataStructure.CellFormatOptions, string> CellFormatToCssClassMap =
            new Dictionary<OBeautifulCode.DataStructure.CellFormatOptions, string>()
            {
                { OBeautifulCode.DataStructure.CellFormatOptions.WrapText, "white-space__wrap" },
                // { OBeautifulCode.DataStructure.CellFormatOptions.Bold, "font-weight__bold" },
                // { OBeautifulCode.DataStructure.CellFormatOptions.Italics, "font-style__italic" },
                // { OBeautifulCode.DataStructure.CellFormatOptions.Underline, "text-decoration__underline" },
            };

        private static string GetCellFormatOptionsCssClasses(
            ICell cell,
            RowFormat obcRowFormat,
            RowFormat obcDataOrHeaderRowsFormat,
            RowFormat obcRowsFormat,
            ColumnFormat obcSpecificColumnFormat,
            ColumnFormat obcColumnFormat,
            TableFormat obcTableFormat,
            string additionalCssClasses,
            TreeTableConversionMode treeTableConversionMode)
        {
            OBeautifulCode.DataStructure.CellFormatOptions? applicableCellFormatOptions = null;
            // ReSharper disable once IdentifierTypo
            // if (cell is IFormattableCell formattableCell && formattableCell.Format?.Options != null)
            // {
            //    applicableCellFormatOptions = formattableCell.Format.Options;
            // }
            // else if (obcRowFormat?.CellsFormat?.Options != null)
            // {
            //    applicableCellFormatOptions = obcRowFormat.CellsFormat.Options;
            // }
            // else if (obcDataOrHeaderRowsFormat?.CellsFormat?.Options != null)
            // {
            //    applicableCellFormatOptions = obcDataOrHeaderRowsFormat.CellsFormat.Options;
            // }
            // else if (obcRowsFormat?.CellsFormat?.Options != null)
            // {
            //    applicableCellFormatOptions = obcRowsFormat.CellsFormat.Options;
            // }
            // else if (obcSpecificColumnFormat?.CellsFormat?.Options != null)
            // {
            //    applicableCellFormatOptions = obcSpecificColumnFormat.CellsFormat.Options;
            // }
            // else if (obcColumnFormat?.CellsFormat?.Options != null)
            // {
            //    applicableCellFormatOptions = obcColumnFormat.CellsFormat.Options;
            // }
            // else if (obcTableFormat?.CellsFormat?.Options != null)
            // {
            //    applicableCellFormatOptions = obcTableFormat.CellsFormat.Options;
            // }
            // else if (treeTableConversionMode == TreeTableConversionMode.Strict)
            // {
            //    // throw new InvalidOperationException(Invariant(
            //    //    $"One of the CellFormats must be non-null. Either change the CellFormat to not be null or set TreeTableConversionMode to Relaxed."));
            // }

            var result = string.IsNullOrWhiteSpace(additionalCssClasses) ? null : additionalCssClasses + " ";

            if (applicableCellFormatOptions != null)
            {
                var allOptions = ((OBeautifulCode.DataStructure.CellFormatOptions[])Enum.GetValues(typeof(OBeautifulCode.DataStructure.CellFormatOptions))).ToList();
                result += string.Join(" ", allOptions.Select(_ => (applicableCellFormatOptions.Value & _) != 0 ? CellFormatToCssClassMap[_] : string.Empty));
            }

            return result;
        }

        private static CellFormat GetCellFormat(
            ICell cell,
            RowFormat obcRowFormat,
            RowFormat obcDataOrHeaderRowsFormat,
            RowFormat obcRowsFormat,
            ColumnFormat obcSpecificColumnFormat,
            ColumnFormat obcColumnFormat,
            TableFormat obcTableFormat,
            TreeTableConversionMode treeTableConversionMode)
        {
            var color = GetCellColor(
                cell,
                obcRowFormat,
                obcRowFormat,
                obcRowsFormat,
                obcSpecificColumnFormat,
                obcColumnFormat,
                obcTableFormat,
                treeTableConversionMode);

            var fontSize = GetCellFontSizeInPixels(
                cell,
                obcRowFormat,
                obcRowFormat,
                obcRowsFormat,
                obcSpecificColumnFormat,
                obcColumnFormat,
                obcTableFormat,
                treeTableConversionMode);

            if (color == null && fontSize == null)
            {
                return null;
            }

            var result = new CellFormat(color?.ToHex(), fontSize);
            return result;
        }

        private static Color? GetCellColor(
            ICell cell,
            RowFormat obcRowFormat,
            RowFormat obcDataOrHeaderRowsFormat,
            RowFormat obcRowsFormat,
            ColumnFormat obcSpecificColumnFormat,
            ColumnFormat obcColumnFormat,
            TableFormat obcTableFormat,
            TreeTableConversionMode treeTableConversionMode)
        {
            Color? result = null;
            // ReSharper disable once IdentifierTypo
            // if (cell is IFormattableCell formattableCell && formattableCell.Format?.FontColor != null)
            // {
            //    result = formattableCell.Format.FontColor;
            // }
            // else if (obcRowFormat?.CellsFormat.FontColor != null)
            // {
            //    result = obcRowFormat.CellsFormat.FontColor;
            // }
            // else if (obcDataOrHeaderRowsFormat?.CellsFormat.FontColor != null)
            // {
            //    result = obcDataOrHeaderRowsFormat.CellsFormat.FontColor;
            // }
            // else if (obcRowsFormat?.CellsFormat.FontColor != null)
            // {
            //    result = obcRowsFormat.CellsFormat.FontColor;
            // }
            // else if (obcSpecificColumnFormat?.CellsFormat?.Options != null)
            // {
            //    result = obcSpecificColumnFormat.CellsFormat.FontColor;
            // }
            // else if (obcColumnFormat?.CellsFormat != null)
            // {
            //    result = obcColumnFormat.CellsFormat.FontColor;
            // }
            // else if (obcTableFormat?.CellsFormat.FontColor != null)
            // {
            //    result = obcTableFormat.CellsFormat.FontColor;
            // }
            // else if (treeTableConversionMode == TreeTableConversionMode.Strict)
            // {
            //    throw new InvalidOperationException(Invariant(
            //        $"One of the CellFormats must be non-null. Either change the CellFormat to not be null or set TreeTableConversionMode to Relaxed."));
            // }

            return result;
        }

        private static string GetCellFontSizeInPixels(
            ICell cell,
            RowFormat obcRowFormat,
            RowFormat obcDataOrHeaderRowsFormat,
            RowFormat obcRowsFormat,
            ColumnFormat obcSpecificColumnFormat,
            ColumnFormat obcColumnFormat,
            TableFormat obcTableFormat,
            TreeTableConversionMode treeTableConversionMode)
        {
            decimal? fontSizeInPoints = null;

            // ReSharper disable once IdentifierTypo
            // if (cell is IFormattableCell formattableCell && formattableCell.Format?.FontSizeInPoints != null)
            // {
            //    fontSizeInPoints = formattableCell.Format.FontSizeInPoints;
            // }
            // else if (obcRowFormat?.CellsFormat.FontSizeInPoints != null)
            // {
            //    fontSizeInPoints = obcRowFormat.CellsFormat.FontSizeInPoints;
            // }
            // else if (obcDataOrHeaderRowsFormat?.CellsFormat.FontSizeInPoints != null)
            // {
            //    fontSizeInPoints = obcDataOrHeaderRowsFormat.CellsFormat.FontSizeInPoints;
            // }
            // else if (obcRowsFormat?.CellsFormat.FontSizeInPoints != null)
            // {
            //    fontSizeInPoints = obcRowsFormat.CellsFormat.FontSizeInPoints;
            // }
            // else if (obcSpecificColumnFormat?.CellsFormat?.FontSizeInPoints != null)
            // {
            //    fontSizeInPoints = obcSpecificColumnFormat.CellsFormat.FontSizeInPoints;
            // }
            // else if (obcColumnFormat?.CellsFormat.FontSizeInPoints != null)
            // {
            //    fontSizeInPoints = obcColumnFormat.CellsFormat.FontSizeInPoints;
            // }
            // else if (obcTableFormat?.CellsFormat.FontSizeInPoints != null)
            // {
            //    fontSizeInPoints = obcTableFormat.CellsFormat.FontSizeInPoints;
            // }
            // else if (treeTableConversionMode == TreeTableConversionMode.Strict)
            // {
            //    throw new InvalidOperationException(Invariant(
            //        $"One of the CellFormats must be non-null. Either change the CellFormat to not be null or set TreeTableConversionMode to Relaxed."));
            // }

            var fontSizeInPixels  = fontSizeInPoints * 4 / 3;
            var result = Invariant($"{fontSizeInPixels}px");
            return result;
        }

        private static bool ShouldCellWrap(
            ICell cell,
            RowFormat obcRowFormat,
            HeaderRowsFormat obcHeaderRowsFormat,
            RowFormat obcRowsFormat,
            ColumnFormat obcSpecificColumnFormat,
            ColumnFormat obcColumnFormat,
            TableFormat obcTableFormat,
            TreeTableConversionMode treeTableConversionMode)
        {
            var result = false;

            // ReSharper disable once IdentifierTypo
            // if (cell is IFormattableCell formattableCell && formattableCell.Format?.Options != null)
            // {
            //    result = formattableCell.Format.Options.IsCellWrapped();
            // }
            // else if (obcRowFormat?.CellsFormat?.Options != null)
            // {
            //    result = obcRowFormat.CellsFormat.Options.IsCellWrapped();
            // }
            // else if (obcHeaderRowsFormat?.RowsFormat?.CellsFormat?.Options != null)
            // {
            //    result = obcHeaderRowsFormat.RowsFormat.CellsFormat.Options.IsCellWrapped();
            // }
            // else if (obcRowsFormat?.CellsFormat?.Options != null)
            // {
            //    result = obcRowsFormat.CellsFormat.Options.IsCellWrapped();
            // }
            // else if (obcSpecificColumnFormat?.CellsFormat?.Options != null)
            // {
            //    result = obcSpecificColumnFormat.CellsFormat.Options.IsCellWrapped();
            // }
            // else if (obcColumnFormat?.CellsFormat?.Options != null)
            // {
            //    result = obcColumnFormat.CellsFormat.Options.IsCellWrapped();
            // }
            // else if (obcTableFormat?.CellsFormat?.Options != null)
            // {
            //    result = obcTableFormat.CellsFormat.Options.IsCellWrapped();
            // }
            // else if (treeTableConversionMode == TreeTableConversionMode.Strict)
            // {
            //    throw new InvalidOperationException(Invariant(
            //        $"One of the CellFormatOptions must be non-null. Either change the CellFormatOptions or set TreeTableConversionMode to Relaxed."));
            // }

            return result;
        }
    }
}
