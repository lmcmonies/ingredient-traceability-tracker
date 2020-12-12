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
    public partial class ProductsForm : Form
    {
        string ingredientFile = "Ingredients.csv";
        HashSet<IngredientModel> Ingredients = new HashSet<IngredientModel>();
        public ProductsForm()
        {
            InitializeComponent();
            LoadData();
            DisplayAllIngredients();
        }

        private void LoadData()
        {
            foreach (IFileConnection connection in GlobalConfig.Connection)
            {
                Ingredients = connection.GetAllIngredients(ingredientFile);
            }
        }

        public void DisplayAllIngredients()
        {
            if (Ingredients != null)
            {
                AllIngredientsListBox.DataSource = Ingredients.ToList();
                AllIngredientsListBox.DisplayMember = "DisplayIngredient";
            }
        }


    }
}
