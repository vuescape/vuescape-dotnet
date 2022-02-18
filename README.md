# vuescape-dotnet
## Overview
vuescape-dotnet provides a .NET model for vuescape browser assets (e.g. Report, TreeTable).  This allows server side authoring in .NET of client side reports. Also supported is converting from [Obeautifulcode.Datastructure.Report](https://github.com/OBeautifulCode/OBeautifulCode.DataStructure/tree/main/OBeautifulCode.DataStructure) to a Vuescape Report.
##  OBeautifulcode.Datastructure Conversion
Note that not all features of OBeautifulcode.Datastructure are supported for conversion.  The following lists supported OBeautifulcode.Datastructure features:

### Rows
- Header Rows
- Data Rows
- Footer Rows
- ChildRows
- RowFormatOptions.AlignChildRowsWithParent
- Hidden rows
- ExpandedSummaryRows (if only 1 root data row will be placed in footer) 

### Cells/Columns
- FontColor (specified via TableFormat, ColumnFormat, RowsFormat, RowFormat, CellFormat)
- BackgroundColor (specified via TableFormat, ColumnFormat, RowsFormat, RowFormat, CellFormat)
- FontSize (specified via TableFormat, ColumnFormat, RowsFormat, RowFormat, CellFormat)
- HorizontalAlignment (specified via TableFormat, ColumnFormat, RowsFormat, RowFormat, CellFormat)
- SimpleLink conversion
- Hover over support (IHaveHoverOver) (rendering may need adjustment in vuescape)
- ColumnFormatOptions.Hide cell
- ColumnFormatOptions.Freeze (but only first column)
- ColumnFormatOptions.Sortable
- CellFormatOptions.WrapText
- Column width sizing: ColumnFormat.WidthInPixels, ColumnFormat.AutofitColumnWidth)
- ColumnsSpanned
