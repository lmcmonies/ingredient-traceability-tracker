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
    public partial class BatchNumberForm : Form
    {
        readonly string BatchNumbersFile = "BatchNumbers.csv";
        Dictionary<IngredientModel, Tuple<BatchNumberModel, DateModel>> BatchNumbers =
            new Dictionary<IngredientModel, Tuple<BatchNumberModel,DateModel>>();
        //List<Tuple<string, string>> BatchNums = new List<Tuple<string, string>>();
        List<string> BatchNums = new List<string>();

        public BatchNumberForm()
        {
            InitializeComponent();
            LoadData();
            DisplayAllBatchNumbers();
        }

        private void LoadData()
        {
            foreach (IFileConnection connection in GlobalConfig.Connection)
            {
                BatchNumbers = connection.GetAllBatchNumbers(BatchNumbersFile);
            }
        }

        public void DisplayAllBatchNumbers()
        {

            string formatted = "";
            foreach (KeyValuePair<IngredientModel, Tuple<BatchNumberModel, DateModel>> entry in BatchNumbers)
            {
                formatted += entry.Key.IngredientName + "    ";
                formatted += entry.Value.Item1.BatchNumber + "      ";
                formatted += entry.Value.Item2.Date;
                BatchNums.Add(formatted);
                formatted = "";
            }
            if (BatchNums != null)
            {
                BatchNumberListBox.DataSource = null;
                BatchNumberListBox.DataSource = BatchNums;
                BatchNumberListBox.DisplayMember = "DisplayBatchNumber";
            }
        }

        private void UpdateBatch(string FileName,string Ingredient, string BatchNumber, string Date )
        {
            foreach (IFileConnection txtConnection in GlobalConfig.Connection)
            {
                BatchNumbers = txtConnection.UpdateBatchNumber(FileName, Ingredient, BatchNumber, Date);
            }
            DisplayAllBatchNumbers();
            
        }

        private void UpdateBatchNumberButton_Click(object sender, EventArgs e)
        {
            try
            {
                string item = (string)BatchNumberListBox.SelectedItem;
                BatchNums.Clear();
                string[] values = item.Split(' ');
                string ing = values[0];
                string bat = values[1];
                string dat = values[2];
                string date = DateTextBox.Text;
                string batch = IngredientTextBox.Text;
                UpdateBatch(BatchNumbersFile, ing, batch, date);
                
            }
            catch (NullReferenceException a)
            {
                Console.WriteLine(a);
            }
            
        }

        public string EvenColumns(int desiredWidth, IEnumerable<IEnumerable<string>> lists)
        {
            return string.Join(Environment.NewLine, EvenColumns(desiredWidth, true, lists));
        }

        public IEnumerable<string> EvenColumns(int desiredWidth, bool rightOrLeft, IEnumerable<IEnumerable<string>> lists)
        {
            return lists.Select(o => EvenColumns(desiredWidth, rightOrLeft, o.ToArray()));
        }

        public string EvenColumns(int desiredWidth, bool rightOrLeftAlignment, string[] list, bool fitToItems = false)
        {
            // right alignment needs "-X" 'width' vs left alignment which is just "X" in the `string.Format` format string
            int columnWidth = (rightOrLeftAlignment ? -1 : 1) *
                                // fit to actual items? this could screw up "evenness" if
                                // one column is longer than the others
                                // and you use this with multiple rows
                                (fitToItems
                                    ? Math.Max(desiredWidth, list.Select(o => o.Length).Max())
                                    : desiredWidth
                                );

            // make columns for all but the "last" (or first) one
            string format = string.Concat(Enumerable.Range(rightOrLeftAlignment ? 0 : 1, list.Length - 1).Select(i => string.Format("{{{0},{1}}}", i, columnWidth)));

            // then add the "last" one without Alignment
            if (rightOrLeftAlignment)
            {
                format += "{" + (list.Length - 1) + "}";
            }
            else
            {
                format = "{0}" + format;
            }

            return string.Format(format, list);
        }
    }
}
