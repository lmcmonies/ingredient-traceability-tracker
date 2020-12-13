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
        readonly string IngredientFile = "Ingredients.csv";
        readonly string ProductsFile = "Products.csv";
        HashSet<IngredientModel> Ingredients = new HashSet<IngredientModel>();
        HashSet<string> ProductIngredients = new HashSet<string>();
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
                Ingredients = connection.GetAllIngredients(IngredientFile);
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

        public void DisplayProductIngredients()
        {
            if (ProductIngredients != null)
            {
                ProductIngredientsListBox.DataSource = ProductIngredients.ToList();
                ProductIngredientsListBox.DisplayMember = "DisplayIngredient";
            }
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            IngredientModel Ingredient = (IngredientModel)AllIngredientsListBox.SelectedItem;
            ProductIngredients.Add(Ingredient.IngredientName);
            ProductIngredientsListBox.DataSource = ProductIngredients.ToList();
        }

        private void DeleteProduct_Click(object sender, EventArgs e)
        {
            string Ingredient = (string)ProductIngredientsListBox.SelectedItem;
            if (Ingredient != null)
            {
                ProductIngredients.Remove(Ingredient);
            }
            DisplayProductIngredients();
        }

        private void CreateProduct_Click(object sender, EventArgs e)
        {
            ProductModel Product = new ProductModel
            {
                ProductName = ProductTextBox.Text.Trim(),
            };
            AddProduct(ProductIngredients, Product, ProductsFile);
        }

        public void AddProduct(HashSet<string> Ingredients, ProductModel ProductName, string FileName)
        {
            foreach (IFileConnection txtConnection in GlobalConfig.Connection)
            {
                txtConnection.AddProduct(Ingredients, ProductName, FileName);
            }
        }
    }
}
