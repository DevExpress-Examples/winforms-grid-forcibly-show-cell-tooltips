using System;
using DevExpress.Utils;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace AlwaysShowCellHints {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            InitData();
        }
        public void InitData() {
            for(int i = 1; i <= 5; i++)
                dataSet11.DataTable1.Rows.Add(i % 2, "Row " + i.ToString(), DateTime.Today, i / 3.0);
        }

        private void toolTipController1_GetActiveObjectInfo(object sender, ToolTipControllerGetActiveObjectInfoEventArgs e) {
            if(e.Info == null && e.SelectedControl == gridControl1) {
                GridView view = gridControl1.FocusedView as GridView;
                GridHitInfo info = view.CalcHitInfo(e.ControlMousePosition);
                if(info.InRowCell) {
                    string text = view.GetRowCellDisplayText(info.RowHandle, info.Column);
                    string cellKey = info.RowHandle.ToString() + " - " + info.Column.ToString();
                    e.Info = new DevExpress.Utils.ToolTipControlInfo(cellKey, text);
                }
            }
        }
    }
}
