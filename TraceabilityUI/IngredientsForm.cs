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
    public partial class IngredientsForm : Form
    {
        string ingredientFile = "Ingredients.csv";
        HashSet<IngredientModel> Ingredients = new HashSet<IngredientModel>(); 
        public IngredientsForm()
        {
            InitializeComponent();
            LoadData();
            DisplayIngredients();
        }

        private void LoadData()
        {
            foreach (IFileConnection connection in GlobalConfig.Connection)
            {
                Ingredients = connection.GetAllIngredients(ingredientFile);
            }
        }

        public void DisplayIngredients()
        {
            if (Ingredients != null)
            {
                IngredientsListBox.DataSource = Ingredients.ToList();
                IngredientsListBox.DisplayMember = "DisplayIngredient";
            }
        }

        public void AddIngredient(HashSet<IngredientModel> Ingredients , IngredientModel Ingredient, string FileName)
        {
            foreach (IFileConnection txtConnection in GlobalConfig.Connection)
            {
                txtConnection.AddIngredient(Ingredient, FileName);
                Ingredients.Add(Ingredient);
            }
        }

        private void AddIngredientButton_Click(object sender, EventArgs e)
        {
            IngredientModel Ingredient = new IngredientModel
            {
                IngredientName = IngredientTextBox.Text.Trim(),
            };
            AddIngredient(Ingredients, Ingredient, ingredientFile);
            LoadData();
            DisplayIngredients();
        }

        private void DeleteIngredientButton_Click(object sender, EventArgs e)
        {
            IngredientModel Ingredient = (IngredientModel)IngredientsListBox.SelectedItem;
            if (Ingredient != null)
            {
                foreach (IFileConnection txtConnection in GlobalConfig.Connection)
                {
                    txtConnection.DeleteIngredient(Ingredient, ingredientFile);
                }
            }
            LoadData();
            DisplayIngredients();
        }
    }
}
