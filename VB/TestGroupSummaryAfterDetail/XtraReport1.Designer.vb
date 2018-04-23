Namespace TestGroupSummaryAfterDetail
	Partial Public Class XtraReport1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim tableQuery1 As New DevExpress.DataAccess.Sql.TableQuery()
			Dim tableInfo1 As New DevExpress.DataAccess.Sql.TableInfo()
			Dim columnInfo1 As New DevExpress.DataAccess.Sql.ColumnInfo()
			Dim columnInfo2 As New DevExpress.DataAccess.Sql.ColumnInfo()
			Dim columnInfo3 As New DevExpress.DataAccess.Sql.ColumnInfo()
			Dim columnInfo4 As New DevExpress.DataAccess.Sql.ColumnInfo()
			Dim columnInfo5 As New DevExpress.DataAccess.Sql.ColumnInfo()
			Dim columnInfo6 As New DevExpress.DataAccess.Sql.ColumnInfo()
			Dim columnInfo7 As New DevExpress.DataAccess.Sql.ColumnInfo()
			Dim columnInfo8 As New DevExpress.DataAccess.Sql.ColumnInfo()
			Dim columnInfo9 As New DevExpress.DataAccess.Sql.ColumnInfo()
			Dim columnInfo10 As New DevExpress.DataAccess.Sql.ColumnInfo()
			Dim columnInfo11 As New DevExpress.DataAccess.Sql.ColumnInfo()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(XtraReport1))
			Dim xrSummary1 As New DevExpress.XtraReports.UI.XRSummary()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
			Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource()
			Me.DetailReport = New DevExpress.XtraReports.UI.DetailReportBand()
			Me.Detail1 = New DevExpress.XtraReports.UI.DetailBand()
			Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
			Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
			Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTable2 = New DevExpress.XtraReports.UI.XRTable()
			Me.xrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTable3 = New DevExpress.XtraReports.UI.XRTable()
			Me.xrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTable4 = New DevExpress.XtraReports.UI.XRTable()
			Me.xrTableRow4 = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.DetailReport2 = New DevExpress.XtraReports.UI.DetailReportBand()
			Me.Detail3 = New DevExpress.XtraReports.UI.DetailBand()
			Me.ReportHeader2 = New DevExpress.XtraReports.UI.ReportHeaderBand()
			Me.GroupHeader2 = New DevExpress.XtraReports.UI.GroupHeaderBand()
			Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
			Me.xrLine1 = New DevExpress.XtraReports.UI.XRLine()
			DirectCast(Me.xrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.xrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.xrTable3, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.xrTable4, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.Expanded = False
			Me.Detail.HeightF = 25F
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' TopMargin
			' 
			Me.TopMargin.HeightF = 100F
			Me.TopMargin.Name = "TopMargin"
			Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' BottomMargin
			' 
			Me.BottomMargin.HeightF = 100F
			Me.BottomMargin.Name = "BottomMargin"
			Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' sqlDataSource1
			' 
			Me.sqlDataSource1.ConnectionName = "nwind"
			Me.sqlDataSource1.Name = "sqlDataSource1"
			tableQuery1.Name = "Products"
			tableInfo1.Name = "Products"
			columnInfo1.Name = "ProductID"
			columnInfo2.Name = "ProductName"
			columnInfo3.Name = "SupplierID"
			columnInfo4.Name = "CategoryID"
			columnInfo5.Name = "QuantityPerUnit"
			columnInfo6.Name = "UnitPrice"
			columnInfo7.Name = "UnitsInStock"
			columnInfo8.Name = "UnitsOnOrder"
			columnInfo9.Name = "ReorderLevel"
			columnInfo10.Name = "Discontinued"
			columnInfo11.Name = "EAN13"
			tableInfo1.SelectedColumns.AddRange(New DevExpress.DataAccess.Sql.ColumnInfo() { columnInfo1, columnInfo2, columnInfo3, columnInfo4, columnInfo5, columnInfo6, columnInfo7, columnInfo8, columnInfo9, columnInfo10, columnInfo11})
			tableQuery1.Tables.AddRange(New DevExpress.DataAccess.Sql.TableInfo() { tableInfo1})
			Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() { tableQuery1})
			Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
			' 
			' DetailReport
			' 
			Me.DetailReport.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail1, Me.ReportHeader, Me.ReportFooter})
			Me.DetailReport.DataMember = "Products"
			Me.DetailReport.DataSource = Me.sqlDataSource1
			Me.DetailReport.Level = 0
			Me.DetailReport.Name = "DetailReport"
			' 
			' Detail1
			' 
			Me.Detail1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTable2})
			Me.Detail1.HeightF = 25F
			Me.Detail1.Name = "Detail1"
			' 
			' ReportHeader
			' 
			Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTable1})
			Me.ReportHeader.HeightF = 25F
			Me.ReportHeader.Name = "ReportHeader"
			' 
			' xrTable1
			' 
			Me.xrTable1.Font = New System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold)
			Me.xrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.xrTable1.Name = "xrTable1"
			Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow1})
			Me.xrTable1.SizeF = New System.Drawing.SizeF(650F, 25F)
			Me.xrTable1.StylePriority.UseFont = False
			Me.xrTable1.StylePriority.UseTextAlignment = False
			Me.xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
			' 
			' xrTableRow1
			' 
			Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell1, Me.xrTableCell2, Me.xrTableCell3})
			Me.xrTableRow1.Name = "xrTableRow1"
			Me.xrTableRow1.Weight = 11.5R
			' 
			' xrTableCell1
			' 
			Me.xrTableCell1.Name = "xrTableCell1"
			Me.xrTableCell1.Text = "Product Name"
			Me.xrTableCell1.Weight = 0.2857142857142857R
			' 
			' xrTableCell2
			' 
			Me.xrTableCell2.Name = "xrTableCell2"
			Me.xrTableCell2.Text = "Quantity Per Unit"
			Me.xrTableCell2.Weight = 0.2857142857142857R
			' 
			' xrTableCell3
			' 
			Me.xrTableCell3.Name = "xrTableCell3"
			Me.xrTableCell3.Text = "Unit Price"
			Me.xrTableCell3.Weight = 0.2857142857142857R
			' 
			' xrTable2
			' 
			Me.xrTable2.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.xrTable2.Name = "xrTable2"
			Me.xrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow2})
			Me.xrTable2.SizeF = New System.Drawing.SizeF(650F, 25F)
			Me.xrTable2.StylePriority.UseTextAlignment = False
			Me.xrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
			' 
			' xrTableRow2
			' 
			Me.xrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell4, Me.xrTableCell5, Me.xrTableCell6})
			Me.xrTableRow2.Name = "xrTableRow2"
			Me.xrTableRow2.Weight = 11.5R
			' 
			' xrTableCell4
			' 
			Me.xrTableCell4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.ProductName")})
			Me.xrTableCell4.Name = "xrTableCell4"
			Me.xrTableCell4.Text = "xrTableCell4"
			Me.xrTableCell4.Weight = 0.2857142857142857R
			' 
			' xrTableCell5
			' 
			Me.xrTableCell5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.QuantityPerUnit")})
			Me.xrTableCell5.Name = "xrTableCell5"
			Me.xrTableCell5.Text = "xrTableCell5"
			Me.xrTableCell5.Weight = 0.2857142857142857R
			' 
			' xrTableCell6
			' 
			Me.xrTableCell6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.UnitPrice")})
			Me.xrTableCell6.Name = "xrTableCell6"
			Me.xrTableCell6.Text = "xrTableCell6"
			Me.xrTableCell6.Weight = 0.2857142857142857R
			' 
			' xrTable3
			' 
			Me.xrTable3.Font = New System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold)
			Me.xrTable3.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.xrTable3.Name = "xrTable3"
			Me.xrTable3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow3})
			Me.xrTable3.SizeF = New System.Drawing.SizeF(650F, 25F)
			Me.xrTable3.StylePriority.UseFont = False
			Me.xrTable3.StylePriority.UseTextAlignment = False
			Me.xrTable3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
			' 
			' xrTableRow3
			' 
			Me.xrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell7, Me.xrTableCell8})
			Me.xrTableRow3.Name = "xrTableRow3"
			Me.xrTableRow3.Weight = 11.5R
			' 
			' xrTableCell7
			' 
			Me.xrTableCell7.Name = "xrTableCell7"
			Me.xrTableCell7.Text = "Category ID"
			Me.xrTableCell7.Weight = 0.22222222222222221R
			' 
			' xrTableCell8
			' 
			Me.xrTableCell8.Name = "xrTableCell8"
			Me.xrTableCell8.Text = "Count"
			Me.xrTableCell8.Weight = 0.22222222222222221R
			' 
			' xrTable4
			' 
			Me.xrTable4.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.xrTable4.Name = "xrTable4"
			Me.xrTable4.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow4})
			Me.xrTable4.SizeF = New System.Drawing.SizeF(650F, 25F)
			Me.xrTable4.StylePriority.UseTextAlignment = False
			Me.xrTable4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
			' 
			' xrTableRow4
			' 
			Me.xrTableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell9, Me.xrTableCell10})
			Me.xrTableRow4.Name = "xrTableRow4"
			Me.xrTableRow4.Weight = 11.5R
			' 
			' xrTableCell9
			' 
			Me.xrTableCell9.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.CategoryID")})
			Me.xrTableCell9.Name = "xrTableCell9"
			Me.xrTableCell9.Text = "xrTableCell9"
			Me.xrTableCell9.Weight = 0.22222222222222221R
			' 
			' xrTableCell10
			' 
			Me.xrTableCell10.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.ProductName")})
			Me.xrTableCell10.Name = "xrTableCell10"
			xrSummary1.Func = DevExpress.XtraReports.UI.SummaryFunc.Count
			xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
			Me.xrTableCell10.Summary = xrSummary1
			Me.xrTableCell10.Weight = 0.22222222222222221R
			' 
			' DetailReport2
			' 
			Me.DetailReport2.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail3, Me.ReportHeader2, Me.GroupHeader2})
			Me.DetailReport2.DataMember = "Products"
			Me.DetailReport2.DataSource = Me.sqlDataSource1
			Me.DetailReport2.Level = 1
			Me.DetailReport2.Name = "DetailReport2"
			' 
			' Detail3
			' 
			Me.Detail3.HeightF = 19.79167F
			Me.Detail3.Name = "Detail3"
			' 
			' ReportHeader2
			' 
			Me.ReportHeader2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTable3})
			Me.ReportHeader2.HeightF = 25F
			Me.ReportHeader2.Name = "ReportHeader2"
			' 
			' GroupHeader2
			' 
			Me.GroupHeader2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTable4})
			Me.GroupHeader2.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() { New DevExpress.XtraReports.UI.GroupField("CategoryID", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
			Me.GroupHeader2.HeightF = 25F
			Me.GroupHeader2.Name = "GroupHeader2"
			' 
			' ReportFooter
			' 
			Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLine1})
			Me.ReportFooter.HeightF = 23F
			Me.ReportFooter.Name = "ReportFooter"
			' 
			' xrLine1
			' 
			Me.xrLine1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.xrLine1.Name = "xrLine1"
			Me.xrLine1.SizeF = New System.Drawing.SizeF(650F, 23F)
			' 
			' XtraReport1
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin, Me.DetailReport, Me.DetailReport2})
			Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() { Me.sqlDataSource1})
			Me.Version = "15.1"
			DirectCast(Me.xrTable1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.xrTable2, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.xrTable3, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.xrTable4, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
		Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
		Private sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
		Private DetailReport As DevExpress.XtraReports.UI.DetailReportBand
		Private Detail1 As DevExpress.XtraReports.UI.DetailBand
		Private xrTable2 As DevExpress.XtraReports.UI.XRTable
		Private xrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
		Private xrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTable3 As DevExpress.XtraReports.UI.XRTable
		Private xrTableRow3 As DevExpress.XtraReports.UI.XRTableRow
		Private xrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTable4 As DevExpress.XtraReports.UI.XRTable
		Private xrTableRow4 As DevExpress.XtraReports.UI.XRTableRow
		Private xrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
		Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
		Private xrTable1 As DevExpress.XtraReports.UI.XRTable
		Private xrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
		Private xrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
		Private DetailReport2 As DevExpress.XtraReports.UI.DetailReportBand
		Private Detail3 As DevExpress.XtraReports.UI.DetailBand
		Private ReportHeader2 As DevExpress.XtraReports.UI.ReportHeaderBand
		Private GroupHeader2 As DevExpress.XtraReports.UI.GroupHeaderBand
		Private ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
		Private xrLine1 As DevExpress.XtraReports.UI.XRLine
	End Class
End Namespace
