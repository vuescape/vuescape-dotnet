// <copyright file="ObcICellExtensions.Internal.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Globalization;
    using System.Linq;

    using OBeautifulCode.DataStructure;
    using OBeautifulCode.Math.Recipes;
    using OBeautifulCode.Type.Recipes;

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
        /// <param name="obcToVuescapeConversionContext">The conversion context.</param>
        /// <returns>A <see cref="TreeTableCell"/>.</returns>
        internal static TreeTableCell ToVuescapeTreeTableCell(
            this ICell obcRowCell,
            TableFormat obcTableFormat,
            RowFormat obcRowsFormat,
            DataRowsFormat obcDataRowsFormat,
            RowFormat obcRowFormat,
            ColumnFormat obcColumnFormat,
            Column obcColumn,
            ObcToVuescapeConversionContext obcToVuescapeConversionContext)
        {
            var slots = new Dictionary<string, UiObject>();
            string defaultSlot = null;

            var displayValue = GetDisplayValue(obcRowCell) ?? string.Empty;
            if (obcRowCell is IGetCellValue valueCell)
            {
                slots.Add("__vs-value", new UiObject(valueCell.GetCellObjectValue()));
                defaultSlot = "__vs-value";
            }

            // TODO: Not handling slotted cells.  OBC and Vuescape have different idea of slotted cell. In OBC a slotted cell has a dictionary of other cells
            // while in Vuescape a slot is dictionary of UiObject Values
            // if (obcRowCell is ISlottedCell slottedCell)
            // {
            //    foreach (var kvp in slottedCell.SlotIdToCellMap)
            //    {
            //        slots.Add(kvp.Key, new UiObject(kvp.Value.GetCellValue()));
            //    }
            //
            //    // defaultSlot = slottedCell.DefaultSlotName;
            // }
            var colspan = obcRowCell.ColumnsSpanned ?? 1;

            Hover hover = null;
            if (obcRowCell is IHaveHoverOver hoverOverCell)
            {
                var hoverOver = hoverOverCell.HoverOver;

                if (hoverOver is StringHoverOver stringHoverOver)
                {
                    hover = new Hover(null, stringHoverOver.Value, HoverContentKind.Plaintext);
                }
                else if (hoverOver is HtmlHoverOver htmlHover)
                {
                    hover = new Hover(null, htmlHover.Html, HoverContentKind.Html);
                }
            }

            var isVisible = ColumnFormatOptionsHelper.IsVisible(obcColumn, obcColumn.Format, obcColumnFormat, obcToVuescapeConversionContext);

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
                obcToVuescapeConversionContext);

            cssClasses += GetFontFormatOptionsCssClasses(
                obcRowCell,
                obcRowFormat,
                obcDataRowsFormat?.RowsFormat,
                obcRowsFormat,
                obcColumn.Format,
                obcColumnFormat,
                obcTableFormat,
                "tree-table-cell__td",
                obcToVuescapeConversionContext);

            // TODO: Add links if applicable
            SlottedUiObject slottedUiObject = null;
            if (slots.Count > 0)
            {
                // TODO: Get active slot from OBC
                slottedUiObject = new SlottedUiObject(slots, defaultSlot);
            }

            // TODO: instead of fontCssClasses add FontFormat (e.g. bold, italic, underline) to CellFormat?
            var cellFormat = GetCellFormat(
                obcRowCell,
                obcRowFormat,
                obcDataRowsFormat?.RowsFormat,
                obcRowsFormat,
                obcColumn.Format,
                obcColumnFormat,
                obcTableFormat,
                obcToVuescapeConversionContext);

            var links = new Dictionary<string, Link>();
            if (obcRowCell is IHaveLink linkedCell && linkedCell.Link != null)
            {
                var vuescapeLink = linkedCell.Link.ToVuescapeLink(obcToVuescapeConversionContext);
                links.Add(LinkName.Self, vuescapeLink);
            }

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
        /// <param name="isLastRow">Is this the last row in the header.  Used to apply sorting to only the last row.</param>
        /// <param name="obcToVuescapeConversionContext">The conversion context.</param>
        /// <returns>A <see cref="TreeTableHeaderCell"/>.</returns>
        internal static TreeTableHeaderCell ToVuescapeTreeTableHeaderCell(
            this ICell obcHeaderRowCell,
            TableFormat obcTableFormat,
            RowFormat obcRowsFormat,
            HeaderRowsFormat obcHeaderRowsFormat,
            RowFormat obcRowFormat,
            ColumnFormat obcColumnFormat,
            Column obcColumn,
            bool isLastRow,
            ObcToVuescapeConversionContext obcToVuescapeConversionContext)
        {
            var displayValue = GetDisplayValue(obcHeaderRowCell);
            var colspan = obcHeaderRowCell.ColumnsSpanned ?? 1;
            var hover = GetHover(obcHeaderRowCell);
            var isVisible = ColumnFormatOptionsHelper.IsVisible(obcColumn, obcColumn.Format, obcColumnFormat, obcToVuescapeConversionContext);

            ColumnSorter columnSorter = null;
            if (isLastRow)
            {
                var isSortable = ColumnFormatOptionsHelper.IsSortable(obcColumn, obcColumn.Format, obcColumnFormat, obcToVuescapeConversionContext);
                if (isSortable)
                {
                    // Default to not be sorted
                    columnSorter = new ColumnSorter(SortDirection.None, SortComparisonStrategy.Default);
                }
            }

            // TODO: Renderer? Is there a default?
            // TODO: classes/styles (formatting)
            var cssClasses = GetCellFormatOptionsCssClasses(
                obcHeaderRowCell,
                obcRowFormat,
                obcHeaderRowsFormat?.RowsFormat,
                obcRowsFormat,
                obcColumn?.Format,
                obcColumnFormat,
                obcTableFormat,
                "tree-table-cell__th",
                obcToVuescapeConversionContext);

            var cellFormat = GetCellFormat(
                obcHeaderRowCell,
                obcRowFormat,
                obcHeaderRowsFormat?.RowsFormat,
                obcRowsFormat,
                obcColumn?.Format,
                obcColumnFormat,
                obcTableFormat,
                obcToVuescapeConversionContext);

            // TODO: Add links if applicable
            var result = new TreeTableHeaderCell(obcHeaderRowCell.Id, displayValue, hover, null, cssClasses, null, colspan, isVisible, columnSorter, cellFormat);
            return result;
        }

        private static Hover GetHover(this ICell obcHeaderRowCell)
        {
            if (!(obcHeaderRowCell is IHaveHoverOver hoverOverCell))
            {
                return null;
            }

            var hoverOver = hoverOverCell.HoverOver;
            switch (hoverOver)
            {
                case StringHoverOver stringHoverOver:
                    return new Hover(null, stringHoverOver.Value, HoverContentKind.Plaintext);
                case HtmlHoverOver htmlHover:
                    return new Hover(null, htmlHover.Html, HoverContentKind.Html);
            }

            throw new NotImplementedException(Invariant($"The only supported {nameof(hoverOverCell.HoverOver)} are {nameof(StringHoverOver)} and {nameof(HtmlHoverOver)}."));
        }

        private static string GetDisplayValue(this ICell obcHeaderRowCell)
        {
            if (!(obcHeaderRowCell is IGetCellValue valueCell))
            {
                return null;
            }

            string displayValue = null;

            if (obcHeaderRowCell is IHaveCellValueFormat displayValueCell)
            {
                var valueFormat = displayValueCell.GetCellValueFormat();
                if (valueFormat is PercentCellValueFormat percentCellValueFormat)
                {
                    if (percentCellValueFormat.PercentDisplayKind != null ||
                        percentCellValueFormat.DecimalSeparator != null ||
                        percentCellValueFormat.DigitGroupKind != null ||
                        percentCellValueFormat.DigitGroupSeparator != null ||
                        percentCellValueFormat.MissingValueText != null ||
                        percentCellValueFormat.NegativeNumberDisplayKind != null)
                    {
                        // TODO: Get property names dynamically
                        throw new NotImplementedException(Invariant(
                            $"The only currently supported properties of {nameof(PercentCellValueFormat)} are 'RoundingStrategy' and 'NumberOfDecimalPlaces': {percentCellValueFormat}."));
                    }

                    var roundingStrategy = percentCellValueFormat.RoundingStrategy ?? MidpointRounding.AwayFromZero;
                    var numberOfDecimalPlaces = percentCellValueFormat.NumberOfDecimalPlaces ?? 0;

                    // PercentCellValueFormat is a NumberCellFormatBase<Decimal>
                    var cellValue = (decimal)valueCell.GetCellObjectValue() * 100;
                    displayValue = cellValue.Round(numberOfDecimalPlaces, roundingStrategy)
                        .ToString(CultureInfo.InvariantCulture);
                }
                else
                {
                    throw new NotImplementedException(Invariant(
                        $"This {nameof(ICellValueFormat)} is not yet implemented: {valueFormat.GetType().ToStringReadable()}."));
                }
            }
            else
            {
                // Assuming this cell value is string for header.
                displayValue = valueCell.GetCellObjectValue().ToString();
            }

            return displayValue;
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
        /// <param name="obcToVuescapeConversionContext">The conversion context.</param>
        /// <returns>A <see cref="TreeTableHeaderCell"/>.</returns>
        internal static ColumnDefinition ToColumnDefinition(
            this Column obcColumn,
            RowFormat obcRowFormat,
            HeaderRowsFormat obcHeaderRowsFormat,
            RowFormat obcRowsFormat,
            ColumnFormat obcSpecificColumnFormat,
            ColumnFormat obcColumnFormat,
            TableFormat obcTableFormat,
            ObcToVuescapeConversionContext obcToVuescapeConversionContext)
        {
            var shouldCellWrap = ShouldCellWrap(
                null,
                obcRowFormat,
                obcHeaderRowsFormat,
                obcRowsFormat,
                obcSpecificColumnFormat,
                obcColumnFormat,
                obcTableFormat,
                obcToVuescapeConversionContext);
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
                var columnWidthBehavior = ColumnWidthBehavior.DynamicallySizeToContent;

                if (obcColumnFormat.AutofitColumnWidth != null && obcColumnFormat.AutofitColumnWidth.Value)
                {
                    columnWrapBehavior = ColumnWrapBehavior.None;
                }

                if (obcColumnFormat.WidthInPixels != null)
                {
                    columnWidthBehavior = ColumnWidthBehavior.UseSpecifiedWidth;
                    width = obcColumnFormat.WidthInPixels;
                    widthUnits = UnitOfMeasure.Pixel;
                }

                var isFrozen = obcColumnFormat.Options.IsFrozen();
                result = new ColumnDefinition(columnWidthBehavior, columnWrapBehavior, width, widthUnits, isFrozen);
            }

            return result;
        }

        private static readonly Dictionary<OBeautifulCode.DataStructure.CellFormatOptions, string> CellFormatToCssClassMap =
            new Dictionary<OBeautifulCode.DataStructure.CellFormatOptions, string>()
            {
                 { OBeautifulCode.DataStructure.CellFormatOptions.WrapText, "white-space__wrap" },
            };

        private static readonly Dictionary<OBeautifulCode.DataStructure.FontFormatOptions, string> FontFormatToCssClassMap =
            new Dictionary<OBeautifulCode.DataStructure.FontFormatOptions, string>()
            {
                { OBeautifulCode.DataStructure.FontFormatOptions.Bold, "font-weight__bold" },
                { OBeautifulCode.DataStructure.FontFormatOptions.Italics, "font-style__italic" },
                { OBeautifulCode.DataStructure.FontFormatOptions.Underline, "text-decoration__underline" },
            };

        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity", Justification = "Handling all conditions.")]
        [SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "obcToVuescapeConversionContext", Justification = "Future-proof usage.")]
        private static string GetCellFormatOptionsCssClasses(
            ICell cell,
            RowFormat obcRowFormat,
            RowFormat obcDataOrHeaderRowsFormat,
            RowFormat obcRowsFormat,
            ColumnFormat obcSpecificColumnFormat,
            ColumnFormat obcColumnFormat,
            TableFormat obcTableFormat,
            string additionalCssClasses,
            ObcToVuescapeConversionContext obcToVuescapeConversionContext)
        {
            OBeautifulCode.DataStructure.CellFormatOptions? applicableCellFormatOptions = null;

            // ReSharper disable once IdentifierTypo
            if (cell is IHaveCellFormat formattableCell && formattableCell.Format?.Options != null)
            {
                applicableCellFormatOptions = formattableCell.Format.Options;
            }
            else if (obcRowFormat?.CellsFormat?.Options != null)
            {
                applicableCellFormatOptions = obcRowFormat.CellsFormat.Options;
            }
            else if (obcDataOrHeaderRowsFormat?.CellsFormat?.Options != null)
            {
                applicableCellFormatOptions = obcDataOrHeaderRowsFormat.CellsFormat.Options;
            }
            else if (obcRowsFormat?.CellsFormat?.Options != null)
            {
                applicableCellFormatOptions = obcRowsFormat.CellsFormat.Options;
            }
            else if (obcSpecificColumnFormat?.CellsFormat?.Options != null)
            {
                applicableCellFormatOptions = obcSpecificColumnFormat.CellsFormat.Options;
            }
            else if (obcColumnFormat?.CellsFormat?.Options != null)
            {
                applicableCellFormatOptions = obcColumnFormat.CellsFormat.Options;
            }
            else if (obcTableFormat?.CellsFormat?.Options != null)
            {
                applicableCellFormatOptions = obcTableFormat.CellsFormat.Options;
            }
            else if (obcToVuescapeConversionContext?.ReportConversionMode == ReportConversionMode.Strict)
            {
                // throw new InvalidOperationException(Invariant(
                //    $"One of the CellFormats must be non-null. Either change the CellFormat to not be null or set ReportConversionMode to Relaxed."));
            }

            var result = string.IsNullOrWhiteSpace(additionalCssClasses) ? null : additionalCssClasses + " ";

            if (applicableCellFormatOptions != null)
            {
                var allOptions = ((OBeautifulCode.DataStructure.CellFormatOptions[])Enum.GetValues(typeof(OBeautifulCode.DataStructure.CellFormatOptions))).ToList();
                result += string.Join(" ", allOptions.Select(_ => (applicableCellFormatOptions.Value & _) != 0 ? CellFormatToCssClassMap[_] : string.Empty));
            }

            return result;
        }

        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity", Justification = "Handling all conditions.")]
        private static string GetFontFormatOptionsCssClasses(
            ICell cell,
            RowFormat obcRowFormat,
            RowFormat obcDataOrHeaderRowsFormat,
            RowFormat obcRowsFormat,
            ColumnFormat obcSpecificColumnFormat,
            ColumnFormat obcColumnFormat,
            TableFormat obcTableFormat,
            string additionalCssClasses,
            ObcToVuescapeConversionContext obcToVuescapeConversionContext)
        {
            OBeautifulCode.DataStructure.FontFormatOptions? applicableFontFormatOptions = null;

            // ReSharper disable once IdentifierTypo
            if (cell is IHaveCellFormat formattableCell && formattableCell.Format?.FontFormat?.Options != null)
            {
                applicableFontFormatOptions = formattableCell.Format.FontFormat.Options;
            }
            else if (obcRowFormat?.CellsFormat?.FontFormat?.Options != null)
            {
                applicableFontFormatOptions = obcRowFormat.CellsFormat.FontFormat.Options;
            }
            else if (obcDataOrHeaderRowsFormat?.CellsFormat?.FontFormat?.Options != null)
            {
                applicableFontFormatOptions = obcDataOrHeaderRowsFormat.CellsFormat.FontFormat.Options;
            }
            else if (obcRowsFormat?.CellsFormat?.FontFormat?.Options != null)
            {
                applicableFontFormatOptions = obcRowsFormat.CellsFormat.FontFormat.Options;
            }
            else if (obcSpecificColumnFormat?.CellsFormat?.FontFormat?.Options != null)
            {
                applicableFontFormatOptions = obcSpecificColumnFormat.CellsFormat.FontFormat.Options;
            }
            else if (obcColumnFormat?.CellsFormat?.FontFormat?.Options != null)
            {
                applicableFontFormatOptions = obcColumnFormat.CellsFormat.FontFormat.Options;
            }
            else if (obcTableFormat?.CellsFormat?.FontFormat?.Options != null)
            {
                applicableFontFormatOptions = obcTableFormat.CellsFormat.FontFormat.Options;
            }
            else if (obcToVuescapeConversionContext?.ReportConversionMode == ReportConversionMode.Strict)
            {
                throw new InvalidOperationException(Invariant(
                   $"One of the CellFormats must be non-null. Either change the CellFormat to not be null or set ReportConversionMode to Relaxed."));
            }

            var result = string.IsNullOrWhiteSpace(additionalCssClasses) ? null : additionalCssClasses + " ";

            if (applicableFontFormatOptions != null)
            {
                var allOptions = ((OBeautifulCode.DataStructure.FontFormatOptions[])Enum.GetValues(typeof(OBeautifulCode.DataStructure.FontFormatOptions))).ToList();
                result += string.Join(" ", allOptions.Select(_ => (applicableFontFormatOptions.Value & _) != 0 ? FontFormatToCssClassMap[_] : string.Empty));
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
            ObcToVuescapeConversionContext obcToVuescapeConversionContext)
        {
            var color = GetFontColor(
                cell,
                obcRowFormat,
                obcDataOrHeaderRowsFormat,
                obcRowsFormat,
                obcSpecificColumnFormat,
                obcColumnFormat,
                obcTableFormat,
                obcToVuescapeConversionContext);

            var fontSize = GetCellFontSizeInPixels(
                cell,
                obcRowFormat,
                obcDataOrHeaderRowsFormat,
                obcRowsFormat,
                obcSpecificColumnFormat,
                obcColumnFormat,
                obcTableFormat,
                obcToVuescapeConversionContext);

            var backgroundColor = GetCellBackgroundColor(
                cell,
                obcRowFormat,
                obcDataOrHeaderRowsFormat,
                obcRowsFormat,
                obcSpecificColumnFormat,
                obcColumnFormat,
                obcTableFormat,
                obcToVuescapeConversionContext);

            var horizontalAlignment = GetHorizontalAlignment(
                    cell,
                    obcRowFormat,
                    obcDataOrHeaderRowsFormat,
                    obcRowsFormat,
                    obcSpecificColumnFormat,
                    obcColumnFormat,
                    obcTableFormat,
                    obcToVuescapeConversionContext);

            if (color == null && fontSize == null && backgroundColor == null && horizontalAlignment == null)
            {
                return null;
            }

            var result = new CellFormat(color?.ToHex(), fontSize, backgroundColor?.ToHex(), horizontalAlignment);
            return result;
        }

        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity", Justification = "Handling all conditions.")]
        private static Color? GetCellBackgroundColor(
            ICell cell,
            RowFormat obcRowFormat,
            RowFormat obcDataOrHeaderRowsFormat,
            RowFormat obcRowsFormat,
            ColumnFormat obcSpecificColumnFormat,
            ColumnFormat obcColumnFormat,
            TableFormat obcTableFormat,
            ObcToVuescapeConversionContext obcToVuescapeConversionContext)
        {
            Color? result = null;

            // ReSharper disable once IdentifierTypo
            if (cell is IHaveCellFormat formattableCell && formattableCell.Format?.BackgroundColor != null)
            {
                result = formattableCell.Format.BackgroundColor;
            }
            else if (obcRowFormat?.CellsFormat?.BackgroundColor != null)
            {
                result = obcRowFormat.CellsFormat.BackgroundColor;
            }
            else if (obcDataOrHeaderRowsFormat?.CellsFormat?.BackgroundColor != null)
            {
                result = obcDataOrHeaderRowsFormat.CellsFormat.BackgroundColor;
            }
            else if (obcRowsFormat?.CellsFormat?.BackgroundColor != null)
            {
                result = obcRowsFormat.CellsFormat.BackgroundColor;
            }
            else if (obcSpecificColumnFormat?.CellsFormat?.BackgroundColor != null)
            {
                result = obcSpecificColumnFormat.CellsFormat.BackgroundColor;
            }
            else if (obcColumnFormat?.CellsFormat?.BackgroundColor != null)
            {
                result = obcColumnFormat.CellsFormat.BackgroundColor;
            }
            else if (obcTableFormat?.CellsFormat?.BackgroundColor != null)
            {
                result = obcTableFormat.CellsFormat.BackgroundColor;
            }
            else if (obcToVuescapeConversionContext?.ReportConversionMode == ReportConversionMode.Strict)
            {
                throw new InvalidOperationException(Invariant(
                    $"One of the 'BackgroundColor' properties must be non-null. Either change the BackgroundColor to not be null or set ReportConversionMode to Relaxed."));
            }

            return result;
        }

        [SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "obcToVuescapeConversionContext", Justification = "Future-proof usage.")]
        private static HorizontalAlignment? GetHorizontalAlignment(
            ICell cell,
            RowFormat obcRowFormat,
            RowFormat obcDataOrHeaderRowsFormat,
            RowFormat obcRowsFormat,
            ColumnFormat obcSpecificColumnFormat,
            ColumnFormat obcColumnFormat,
            TableFormat obcTableFormat,
            ObcToVuescapeConversionContext obcToVuescapeConversionContext)
        {
            HorizontalAlignment? result = null;

            // ReSharper disable once IdentifierTypo
            if (cell is IHaveCellFormat formattableCell && formattableCell.Format?.HorizontalAlignment != null)
            {
                result = formattableCell.Format.HorizontalAlignment.ToVuescapeHorizontalAlignment();
            }
            else if (obcRowFormat?.CellsFormat?.HorizontalAlignment != null)
            {
                result = obcRowFormat.CellsFormat.HorizontalAlignment.ToVuescapeHorizontalAlignment();
            }
            else if (obcDataOrHeaderRowsFormat?.CellsFormat?.HorizontalAlignment != null)
            {
                result = obcDataOrHeaderRowsFormat.CellsFormat.HorizontalAlignment.ToVuescapeHorizontalAlignment();
            }
            else if (obcRowsFormat?.CellsFormat?.HorizontalAlignment != null)
            {
                result = obcRowsFormat.CellsFormat.HorizontalAlignment.ToVuescapeHorizontalAlignment();
            }
            else if (obcSpecificColumnFormat?.CellsFormat?.HorizontalAlignment != null)
            {
                result = obcSpecificColumnFormat.CellsFormat.HorizontalAlignment.ToVuescapeHorizontalAlignment();
            }
            else if (obcColumnFormat?.CellsFormat?.HorizontalAlignment != null)
            {
                result = obcColumnFormat.CellsFormat.HorizontalAlignment.ToVuescapeHorizontalAlignment();
            }
            else if (obcTableFormat?.CellsFormat?.HorizontalAlignment != null)
            {
                result = obcTableFormat.CellsFormat.HorizontalAlignment.ToVuescapeHorizontalAlignment();
            }

            return result;
        }

        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity", Justification = "Handling all conditions.")]
        private static Color? GetFontColor(
            ICell cell,
            RowFormat obcRowFormat,
            RowFormat obcDataOrHeaderRowsFormat,
            RowFormat obcRowsFormat,
            ColumnFormat obcSpecificColumnFormat,
            ColumnFormat obcColumnFormat,
            TableFormat obcTableFormat,
            ObcToVuescapeConversionContext obcToVuescapeConversionContext)
        {
            Color? result = null;

            // ReSharper disable once IdentifierTypo
            if (cell is IHaveCellFormat formattableCell && formattableCell.Format?.FontFormat?.FontColor != null)
            {
                result = formattableCell.Format.FontFormat.FontColor;
            }
            else if (obcRowFormat?.CellsFormat?.FontFormat?.FontColor != null)
            {
                result = obcRowFormat.CellsFormat.FontFormat.FontColor;
            }
            else if (obcDataOrHeaderRowsFormat?.CellsFormat?.FontFormat?.FontColor != null)
            {
                result = obcDataOrHeaderRowsFormat.CellsFormat.FontFormat.FontColor;
            }
            else if (obcRowsFormat?.CellsFormat?.FontFormat?.FontColor != null)
            {
                result = obcRowsFormat.CellsFormat.FontFormat.FontColor;
            }
            else if (obcSpecificColumnFormat?.CellsFormat?.FontFormat?.FontColor != null)
            {
                result = obcSpecificColumnFormat.CellsFormat.FontFormat.FontColor;
            }
            else if (obcColumnFormat?.CellsFormat?.FontFormat?.FontColor != null)
            {
                result = obcColumnFormat.CellsFormat.FontFormat.FontColor;
            }
            else if (obcTableFormat?.CellsFormat?.FontFormat?.FontColor != null)
            {
                result = obcTableFormat.CellsFormat.FontFormat.FontColor;
            }
            else if (obcToVuescapeConversionContext?.ReportConversionMode == ReportConversionMode.Strict)
            {
                throw new InvalidOperationException(Invariant(
                    $"One of the CellFormats must be non-null. Either change the CellFormat to not be null or set ReportConversionMode to Relaxed."));
            }

            return result;
        }

        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity", Justification = "Handling all conditions.")]
        [SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "obcToVuescapeConversionContext", Justification = "Future-proof usage.")]
        private static string GetCellFontSizeInPixels(
            ICell cell,
            RowFormat obcRowFormat,
            RowFormat obcDataOrHeaderRowsFormat,
            RowFormat obcRowsFormat,
            ColumnFormat obcSpecificColumnFormat,
            ColumnFormat obcColumnFormat,
            TableFormat obcTableFormat,
            ObcToVuescapeConversionContext obcToVuescapeConversionContext)
        {
            decimal? fontFormatFontSizeInPoints = null;

            // ReSharper disable once IdentifierTypo
            if (cell is IHaveCellFormat formattableCell && formattableCell.Format?.FontFormat?.FontSizeInPoints != null)
            {
                fontFormatFontSizeInPoints = formattableCell.Format.FontFormat.FontSizeInPoints;
            }
            else if (obcRowFormat?.CellsFormat?.FontFormat?.FontSizeInPoints != null)
            {
                fontFormatFontSizeInPoints = obcRowFormat.CellsFormat.FontFormat.FontSizeInPoints;
            }
            else if (obcDataOrHeaderRowsFormat?.CellsFormat?.FontFormat?.FontSizeInPoints != null)
            {
                fontFormatFontSizeInPoints = obcDataOrHeaderRowsFormat.CellsFormat.FontFormat.FontSizeInPoints;
            }
            else if (obcRowsFormat?.CellsFormat?.FontFormat?.FontSizeInPoints != null)
            {
                fontFormatFontSizeInPoints = obcRowsFormat.CellsFormat.FontFormat.FontSizeInPoints;
            }
            else if (obcSpecificColumnFormat?.CellsFormat?.FontFormat?.FontSizeInPoints != null)
            {
                fontFormatFontSizeInPoints = obcSpecificColumnFormat.CellsFormat.FontFormat.FontSizeInPoints;
            }
            else if (obcColumnFormat?.CellsFormat?.FontFormat?.FontSizeInPoints != null)
            {
                fontFormatFontSizeInPoints = obcColumnFormat.CellsFormat.FontFormat.FontSizeInPoints;
            }
            else if (obcTableFormat?.CellsFormat?.FontFormat?.FontSizeInPoints != null)
            {
                fontFormatFontSizeInPoints = obcTableFormat.CellsFormat.FontFormat.FontSizeInPoints;
            }
            else if (obcToVuescapeConversionContext?.ReportConversionMode == ReportConversionMode.Strict)
            {
                throw new InvalidOperationException(Invariant(
                    $"One of the CellFormats must be non-null. Either change the CellFormat to not be null or set ReportConversionMode to Relaxed."));
            }

            if (fontFormatFontSizeInPoints == null)
            {
                return null;
            }

            fontFormatFontSizeInPoints = fontFormatFontSizeInPoints * 4 / 3;
            var result = Invariant($"{fontFormatFontSizeInPoints}px");
            return result;
        }

        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity", Justification = "Handling all conditions.")]
        private static bool ShouldCellWrap(
            ICell cell,
            RowFormat obcRowFormat,
            HeaderRowsFormat obcHeaderRowsFormat,
            RowFormat obcRowsFormat,
            ColumnFormat obcSpecificColumnFormat,
            ColumnFormat obcColumnFormat,
            TableFormat obcTableFormat,
            ObcToVuescapeConversionContext obcToVuescapeConversionContext)
        {
            var result = false;

            // ReSharper disable once IdentifierTypo
            if (cell is IHaveCellFormat formattableCell && formattableCell?.Format?.Options != null)
            {
                result = formattableCell.Format.Options.IsCellWrapped();
            }
            else if (obcRowFormat?.CellsFormat?.Options != null)
            {
                result = obcRowFormat.CellsFormat.Options.IsCellWrapped();
            }
            else if (obcHeaderRowsFormat?.RowsFormat?.CellsFormat?.Options != null)
            {
                result = obcHeaderRowsFormat.RowsFormat.CellsFormat.Options.IsCellWrapped();
            }
            else if (obcRowsFormat?.CellsFormat?.Options != null)
            {
                result = obcRowsFormat.CellsFormat.Options.IsCellWrapped();
            }
            else if (obcSpecificColumnFormat?.CellsFormat?.Options != null)
            {
                result = obcSpecificColumnFormat.CellsFormat.Options.IsCellWrapped();
            }
            else if (obcColumnFormat?.CellsFormat?.Options != null)
            {
                result = obcColumnFormat.CellsFormat.Options.IsCellWrapped();
            }
            else if (obcTableFormat?.CellsFormat?.Options != null)
            {
                result = obcTableFormat.CellsFormat.Options.IsCellWrapped();
            }
            else if (obcToVuescapeConversionContext?.ReportConversionMode == ReportConversionMode.Strict)
            {
                throw new InvalidOperationException(Invariant(
                    $"One of the CellFormatOptions must be non-null. Either change the CellFormatOptions or set ReportConversionMode to Relaxed."));
            }

            return result;
        }
    }
}
