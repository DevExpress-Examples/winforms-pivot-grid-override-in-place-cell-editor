Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraPivotGrid

Namespace PivotGridControl_CustomCellEdit
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        ' Creates new repository items.
        Dim riProgressBar As New RepositoryItemProgressBar()
        Dim riTextEdit As New RepositoryItemTextEdit()

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            salesPersonTableAdapter.Fill(Me.nwindDataSet.SalesPerson)

            ' Specifies the type of data field and format settings.
            fieldQuantity1.SummaryDisplayType = DevExpress.Data.PivotGrid.PivotSummaryDisplayType.PercentOfColumn
            fieldQuantity1.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom
            fieldQuantity1.CellFormat.FormatString = "{0}%"

            ' Initializes cell editors for this Pivot Grid control.
            pivotGridControl1.RepositoryItems.AddRange(New RepositoryItem() {riProgressBar, riTextEdit})
        End Sub

        Private Sub pivotGridControl1_CustomCellEdit(ByVal sender As Object,
                            ByVal e As PivotCustomCellEditEventArgs) Handles pivotGridControl1.CustomCellEdit
            ' Specifies a cell editor which is used in both display and edit modes.
            If e.DataField Is fieldQuantity1 And e.RowValueType = PivotGridValueType.Value Then
                e.RepositoryItem = riProgressBar
            End If
        End Sub

        Private Sub pivotGridControl1_CustomCellEditForEditing(sender As Object,
                    ByVal e As PivotCustomCellEditEventArgs) Handles pivotGridControl1.CustomCellEditForEditing
            ' Overrides the cell editor for the edit mode.
            If e.DataField Is fieldQuantity1 And e.RowValueType = PivotGridValueType.Value Then
                e.RepositoryItem = riTextEdit
            End If
        End Sub

        Private Sub pivotGridControl1_CustomCellValue(ByVal sender As Object,
                            ByVal e As PivotCellValueEventArgs) Handles pivotGridControl1.CustomCellValue
            If e.DataField Is fieldQuantity1 Then
                e.Value = Math.Round(Convert.ToDecimal(e.Value) * 100, 2)
            End If
        End Sub
    End Class
End Namespace
