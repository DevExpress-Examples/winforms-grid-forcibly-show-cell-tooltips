Imports Microsoft.VisualBasic
Imports System
Namespace AlwaysShowCellHints
	Partial Public Class Form1
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

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.dataTable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.dataSet11 = New AlwaysShowCellHints.DataSet1()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colBoolProperty1 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colStringProperty1 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colCurrentDate1 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colDoubleProperty1 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.toolTipController1 = New DevExpress.Utils.ToolTipController(Me.components)
			Me.advBandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView()
			Me.gridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
			Me.colBoolProperty = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colStringProperty = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colCurrentDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colDoubleProperty = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			CType(Me.dataTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.advBandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' dataTable1BindingSource
			' 
			Me.dataTable1BindingSource.DataMember = "DataTable1"
			Me.dataTable1BindingSource.DataSource = Me.dataSet11
			' 
			' dataSet11
			' 
			Me.dataSet11.DataSetName = "DataSet1"
			Me.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' gridControl1
			' 
			Me.gridControl1.DataSource = Me.dataTable1BindingSource
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.gridView2
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(592, 358)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ToolTipController = Me.toolTipController1
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView2, Me.advBandedGridView1})
			' 
			' gridView2
			' 
			Me.gridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colBoolProperty1, Me.colStringProperty1, Me.colCurrentDate1, Me.colDoubleProperty1})
			Me.gridView2.GridControl = Me.gridControl1
			Me.gridView2.Name = "gridView2"
			' 
			' colBoolProperty1
			' 
			Me.colBoolProperty1.Caption = "BoolProperty"
			Me.colBoolProperty1.FieldName = "BoolProperty"
			Me.colBoolProperty1.Name = "colBoolProperty1"
			Me.colBoolProperty1.Visible = True
			Me.colBoolProperty1.VisibleIndex = 0
			' 
			' colStringProperty1
			' 
			Me.colStringProperty1.Caption = "StringProperty"
			Me.colStringProperty1.FieldName = "StringProperty"
			Me.colStringProperty1.Name = "colStringProperty1"
			Me.colStringProperty1.Visible = True
			Me.colStringProperty1.VisibleIndex = 1
			' 
			' colCurrentDate1
			' 
			Me.colCurrentDate1.Caption = "CurrentDate"
			Me.colCurrentDate1.FieldName = "CurrentDate"
			Me.colCurrentDate1.Name = "colCurrentDate1"
			Me.colCurrentDate1.Visible = True
			Me.colCurrentDate1.VisibleIndex = 2
			' 
			' colDoubleProperty1
			' 
			Me.colDoubleProperty1.Caption = "DoubleProperty"
			Me.colDoubleProperty1.FieldName = "DoubleProperty"
			Me.colDoubleProperty1.Name = "colDoubleProperty1"
			Me.colDoubleProperty1.Visible = True
			Me.colDoubleProperty1.VisibleIndex = 3
			' 
			' toolTipController1
			' 
'			Me.toolTipController1.GetActiveObjectInfo += New DevExpress.Utils.ToolTipControllerGetActiveObjectInfoEventHandler(Me.toolTipController1_GetActiveObjectInfo);
			' 
			' advBandedGridView1
			' 
			Me.advBandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() { Me.gridBand1})
			Me.advBandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() { Me.colBoolProperty, Me.colStringProperty, Me.colCurrentDate, Me.colDoubleProperty})
			Me.advBandedGridView1.GridControl = Me.gridControl1
			Me.advBandedGridView1.Name = "advBandedGridView1"
			Me.advBandedGridView1.OptionsSelection.MultiSelect = True
			' 
			' gridBand1
			' 
			Me.gridBand1.Caption = "gridBand1"
			Me.gridBand1.Columns.Add(Me.colBoolProperty)
			Me.gridBand1.Columns.Add(Me.colStringProperty)
			Me.gridBand1.Columns.Add(Me.colCurrentDate)
			Me.gridBand1.Columns.Add(Me.colDoubleProperty)
			Me.gridBand1.Name = "gridBand1"
			Me.gridBand1.Width = 464
			' 
			' colBoolProperty
			' 
			Me.colBoolProperty.Caption = "BoolProperty"
			Me.colBoolProperty.FieldName = "BoolProperty"
			Me.colBoolProperty.Name = "colBoolProperty"
			Me.colBoolProperty.Visible = True
			Me.colBoolProperty.Width = 116
			' 
			' colStringProperty
			' 
			Me.colStringProperty.Caption = "StringProperty"
			Me.colStringProperty.FieldName = "StringProperty"
			Me.colStringProperty.Name = "colStringProperty"
			Me.colStringProperty.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True
			Me.colStringProperty.Visible = True
			Me.colStringProperty.Width = 116
			' 
			' colCurrentDate
			' 
			Me.colCurrentDate.Caption = "CurrentDate"
			Me.colCurrentDate.FieldName = "CurrentDate"
			Me.colCurrentDate.Name = "colCurrentDate"
			Me.colCurrentDate.Visible = True
			Me.colCurrentDate.Width = 116
			' 
			' colDoubleProperty
			' 
			Me.colDoubleProperty.Caption = "DoubleProperty"
			Me.colDoubleProperty.FieldName = "DoubleProperty"
			Me.colDoubleProperty.Name = "colDoubleProperty"
			Me.colDoubleProperty.Visible = True
			Me.colDoubleProperty.Width = 116
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(592, 358)
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "Form1"
			Me.Text = "How to force the Grid to show a hint for a cell even if the cell's content is com" & "pletely visible"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.dataTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.advBandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private dataSet11 As DataSet1
		Private dataTable1BindingSource As System.Windows.Forms.BindingSource
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView2 As DevExpress.XtraGrid.Views.Grid.GridView
		Private advBandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
		Private gridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
		Private colBoolProperty As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colStringProperty As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colCurrentDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colDoubleProperty As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colBoolProperty1 As DevExpress.XtraGrid.Columns.GridColumn
		Private colStringProperty1 As DevExpress.XtraGrid.Columns.GridColumn
		Private colCurrentDate1 As DevExpress.XtraGrid.Columns.GridColumn
		Private colDoubleProperty1 As DevExpress.XtraGrid.Columns.GridColumn
		Private WithEvents toolTipController1 As DevExpress.Utils.ToolTipController
	End Class
End Namespace

