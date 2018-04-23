namespace AlwaysShowCellHints {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet11 = new AlwaysShowCellHints.DataSet1();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colBoolProperty1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStringProperty1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrentDate1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDoubleProperty1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            this.advBandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colBoolProperty = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colStringProperty = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colCurrentDate = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colDoubleProperty = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.dataSet11;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.dataTable1BindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView2;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(592, 358);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ToolTipController = this.toolTipController1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2,
            this.advBandedGridView1});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBoolProperty1,
            this.colStringProperty1,
            this.colCurrentDate1,
            this.colDoubleProperty1});
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            // 
            // colBoolProperty1
            // 
            this.colBoolProperty1.Caption = "BoolProperty";
            this.colBoolProperty1.FieldName = "BoolProperty";
            this.colBoolProperty1.Name = "colBoolProperty1";
            this.colBoolProperty1.Visible = true;
            this.colBoolProperty1.VisibleIndex = 0;
            // 
            // colStringProperty1
            // 
            this.colStringProperty1.Caption = "StringProperty";
            this.colStringProperty1.FieldName = "StringProperty";
            this.colStringProperty1.Name = "colStringProperty1";
            this.colStringProperty1.Visible = true;
            this.colStringProperty1.VisibleIndex = 1;
            // 
            // colCurrentDate1
            // 
            this.colCurrentDate1.Caption = "CurrentDate";
            this.colCurrentDate1.FieldName = "CurrentDate";
            this.colCurrentDate1.Name = "colCurrentDate1";
            this.colCurrentDate1.Visible = true;
            this.colCurrentDate1.VisibleIndex = 2;
            // 
            // colDoubleProperty1
            // 
            this.colDoubleProperty1.Caption = "DoubleProperty";
            this.colDoubleProperty1.FieldName = "DoubleProperty";
            this.colDoubleProperty1.Name = "colDoubleProperty1";
            this.colDoubleProperty1.Visible = true;
            this.colDoubleProperty1.VisibleIndex = 3;
            // 
            // toolTipController1
            // 
            this.toolTipController1.GetActiveObjectInfo += new DevExpress.Utils.ToolTipControllerGetActiveObjectInfoEventHandler(this.toolTipController1_GetActiveObjectInfo);
            // 
            // advBandedGridView1
            // 
            this.advBandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1});
            this.advBandedGridView1.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colBoolProperty,
            this.colStringProperty,
            this.colCurrentDate,
            this.colDoubleProperty});
            this.advBandedGridView1.GridControl = this.gridControl1;
            this.advBandedGridView1.Name = "advBandedGridView1";
            this.advBandedGridView1.OptionsSelection.MultiSelect = true;
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "gridBand1";
            this.gridBand1.Columns.Add(this.colBoolProperty);
            this.gridBand1.Columns.Add(this.colStringProperty);
            this.gridBand1.Columns.Add(this.colCurrentDate);
            this.gridBand1.Columns.Add(this.colDoubleProperty);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.Width = 464;
            // 
            // colBoolProperty
            // 
            this.colBoolProperty.Caption = "BoolProperty";
            this.colBoolProperty.FieldName = "BoolProperty";
            this.colBoolProperty.Name = "colBoolProperty";
            this.colBoolProperty.Visible = true;
            this.colBoolProperty.Width = 116;
            // 
            // colStringProperty
            // 
            this.colStringProperty.Caption = "StringProperty";
            this.colStringProperty.FieldName = "StringProperty";
            this.colStringProperty.Name = "colStringProperty";
            this.colStringProperty.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colStringProperty.Visible = true;
            this.colStringProperty.Width = 116;
            // 
            // colCurrentDate
            // 
            this.colCurrentDate.Caption = "CurrentDate";
            this.colCurrentDate.FieldName = "CurrentDate";
            this.colCurrentDate.Name = "colCurrentDate";
            this.colCurrentDate.Visible = true;
            this.colCurrentDate.Width = 116;
            // 
            // colDoubleProperty
            // 
            this.colDoubleProperty.Caption = "DoubleProperty";
            this.colDoubleProperty.FieldName = "DoubleProperty";
            this.colDoubleProperty.Name = "colDoubleProperty";
            this.colDoubleProperty.Visible = true;
            this.colDoubleProperty.Width = 116;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 358);
            this.Controls.Add(this.gridControl1);
            this.Name = "Form1";
            this.Text = "How to force the Grid to show a hint for a cell even if the cell\'s content is com" +
                "pletely visible";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataSet1 dataSet11;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView advBandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colBoolProperty;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colStringProperty;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colCurrentDate;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colDoubleProperty;
        private DevExpress.XtraGrid.Columns.GridColumn colBoolProperty1;
        private DevExpress.XtraGrid.Columns.GridColumn colStringProperty1;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrentDate1;
        private DevExpress.XtraGrid.Columns.GridColumn colDoubleProperty1;
        private DevExpress.Utils.ToolTipController toolTipController1;
    }
}

