using System;
using System.Windows.Forms;
using DevExpress.Data.PivotGrid;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraPivotGrid;

namespace PivotGridControl_CustomCellEdit {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        // Creates new repository items.
        RepositoryItemTextEdit riTextEdit = new RepositoryItemTextEdit();
        RepositoryItemProgressBar riProgressBar = new RepositoryItemProgressBar();

        private void Form1_Load(object sender, EventArgs e) {
            this.salesPersonTableAdapter.Fill(this.nwindDataSet.SalesPerson);

            // Specifies the type of data field and format settings.
            fieldQuantityPercent.SummaryDisplayType = PivotSummaryDisplayType.PercentOfColumn;
            fieldQuantityPercent.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            fieldQuantityPercent.CellFormat.FormatString = "{0}%";

            // Initializes cell editors for this Pivot Grid control.
            pivotGridControl1.RepositoryItems.AddRange(new RepositoryItem[] { riTextEdit, riProgressBar });
        }

        void pivotGridControl1_CustomCellEdit(object sender, PivotCustomCellEditEventArgs e) {
            // Specifies a cell editor which is used in both display and edit modes.
            if (e.DataField == fieldQuantityPercent & e.RowValueType == PivotGridValueType.Value)
                    e.RepositoryItem = riProgressBar;            
        }

        void pivotGridControl1_CustomCellEditForEditing(object sender, PivotCustomCellEditEventArgs e) {
            // Overrides the cell editor for the edit mode.
            if (e.DataField == fieldQuantityPercent & e.RowValueType == PivotGridValueType.Value) 
                    e.RepositoryItem = riTextEdit;            
        }
        
        private void pivotGridControl1_CustomCellValue(object sender, PivotCellValueEventArgs e) {
            if (e.DataField == fieldQuantityPercent)
                e.Value = Math.Round(Convert.ToDecimal(e.Value) * 100, 2);
        }

    }
}
