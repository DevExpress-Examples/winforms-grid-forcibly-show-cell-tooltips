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
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.recordBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.gridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colParentID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colText = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colInfo = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colValue = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDt = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colState = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colImage = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDetail = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.toolTipController1 = New DevExpress.Utils.ToolTipController(Me.components)
            Me.advBandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView()
            Me.gridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
            Me.colBoolProperty = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colStringProperty = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colCurrentDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colDoubleProperty = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.recordBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.advBandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.DataSource = Me.recordBindingSource
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.Location = New System.Drawing.Point(0, 0)
            Me.gridControl1.MainView = Me.gridView2
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Size = New System.Drawing.Size(592, 358)
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.ToolTipController = Me.toolTipController1
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView2, Me.advBandedGridView1})
            ' 
            ' recordBindingSource
            ' 
            Me.recordBindingSource.DataSource = GetType(AlwaysShowCellHints.Record)
            ' 
            ' gridView2
            ' 
            Me.gridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colID, Me.colParentID, Me.colText, Me.colInfo, Me.colValue, Me.colDt, Me.colState, Me.colImage, Me.colDetail})
            Me.gridView2.GridControl = Me.gridControl1
            Me.gridView2.Name = "gridView2"
            ' 
            ' colID
            ' 
            Me.colID.FieldName = "ID"
            Me.colID.Name = "colID"
            Me.colID.Visible = True
            Me.colID.VisibleIndex = 0
            ' 
            ' colParentID
            ' 
            Me.colParentID.FieldName = "ParentID"
            Me.colParentID.Name = "colParentID"
            Me.colParentID.Visible = True
            Me.colParentID.VisibleIndex = 1
            ' 
            ' colText
            ' 
            Me.colText.FieldName = "Text"
            Me.colText.Name = "colText"
            Me.colText.Visible = True
            Me.colText.VisibleIndex = 2
            ' 
            ' colInfo
            ' 
            Me.colInfo.FieldName = "Info"
            Me.colInfo.Name = "colInfo"
            Me.colInfo.Visible = True
            Me.colInfo.VisibleIndex = 3
            ' 
            ' colValue
            ' 
            Me.colValue.FieldName = "Value"
            Me.colValue.Name = "colValue"
            Me.colValue.Visible = True
            Me.colValue.VisibleIndex = 4
            ' 
            ' colDt
            ' 
            Me.colDt.FieldName = "Dt"
            Me.colDt.Name = "colDt"
            Me.colDt.Visible = True
            Me.colDt.VisibleIndex = 5
            ' 
            ' colState
            ' 
            Me.colState.FieldName = "State"
            Me.colState.Name = "colState"
            Me.colState.Visible = True
            Me.colState.VisibleIndex = 6
            ' 
            ' colImage
            ' 
            Me.colImage.FieldName = "Image"
            Me.colImage.Name = "colImage"
            Me.colImage.Visible = True
            Me.colImage.VisibleIndex = 7
            ' 
            ' colDetail
            ' 
            Me.colDetail.FieldName = "Detail"
            Me.colDetail.Name = "colDetail"
            ' 
            ' toolTipController1
            ' 
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
            Me.gridBand1.VisibleIndex = 0
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
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.recordBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.advBandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region
        Private gridControl1 As DevExpress.XtraGrid.GridControl
        Private gridView2 As DevExpress.XtraGrid.Views.Grid.GridView
        Private advBandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
        Private gridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Private colBoolProperty As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Private colStringProperty As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Private colCurrentDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Private colDoubleProperty As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Private WithEvents toolTipController1 As DevExpress.Utils.ToolTipController
        Private recordBindingSource As System.Windows.Forms.BindingSource
        Private colID As DevExpress.XtraGrid.Columns.GridColumn
        Private colParentID As DevExpress.XtraGrid.Columns.GridColumn
        Private colText As DevExpress.XtraGrid.Columns.GridColumn
        Private colInfo As DevExpress.XtraGrid.Columns.GridColumn
        Private colValue As DevExpress.XtraGrid.Columns.GridColumn
        Private colDt As DevExpress.XtraGrid.Columns.GridColumn
        Private colState As DevExpress.XtraGrid.Columns.GridColumn
        Private colImage As DevExpress.XtraGrid.Columns.GridColumn
        Private colDetail As DevExpress.XtraGrid.Columns.GridColumn
    End Class
End Namespace

