using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TraceabilityLibrary;

namespace TraceabilityUI
{
    public partial class SheetsForm : Form
    {
        string SheetFile = "Sheets.csv";
        HashSet<SheetModel> SheetsSet = new HashSet<SheetModel>();
        public SheetsForm()
        {
            InitializeComponent();
            LoadData();
            DisplayAllSheets();
        }

        private void LoadData()
        {
            foreach (IFileConnection connection in GlobalConfig.Connection)
            {
                SheetsSet = connection.GetAllSheets(SheetFile);
            }
        }

        public void DisplayAllSheets()
        {
            if (SheetsSet != null)
            {
                SheetsListBox.DataSource = SheetsSet.ToList();
                SheetsListBox.DisplayMember = "DisplaySheet";
            }
        }
        public void AddSheet(HashSet<SheetModel> Sheets, SheetModel Sheet, string FileName)
        {
            foreach (IFileConnection txtConnection in GlobalConfig.Connection)
            {
                txtConnection.AddSheet(Sheet, FileName);

                Sheets.Add(Sheet);
            }
        }

        private void AddNewSheetButton_Click(object sender, EventArgs e)
        {
            SheetModel Sheet = new SheetModel
            {
                SheetName = NewSheetTextBox.Text.Trim(),
                
            };
            
            
            AddSheet(SheetsSet, Sheet, SheetFile);
            LoadData();
            DisplayAllSheets();
        }
    }
}
