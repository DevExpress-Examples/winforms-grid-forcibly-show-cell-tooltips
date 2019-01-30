Imports System
Imports DevExpress.Utils
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Namespace AlwaysShowCellHints
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
            InitData()
        End Sub
        Public Sub InitData()
            recordBindingSource.DataSource = DataHelper.GetData(10)
        End Sub

        Private Sub toolTipController1_GetActiveObjectInfo(ByVal sender As Object, ByVal e As ToolTipControllerGetActiveObjectInfoEventArgs) Handles toolTipController1.GetActiveObjectInfo
            If e.Info Is Nothing AndAlso e.SelectedControl Is gridControl1 Then
                Dim view As GridView = TryCast(gridControl1.FocusedView, GridView)
                Dim info As GridHitInfo = view.CalcHitInfo(e.ControlMousePosition)
                If info.InRowCell Then

                    Dim text_Renamed As String = view.GetRowCellDisplayText(info.RowHandle, info.Column)
                    Dim cellKey As String = info.RowHandle.ToString() & " - " & info.Column.ToString()
                    e.Info = New ToolTipControlInfo(cellKey, text_Renamed)
                End If
            End If
        End Sub
    End Class
End Namespace
