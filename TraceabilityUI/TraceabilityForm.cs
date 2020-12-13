using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using FontAwesome.Sharp;
using TraceabilityLibrary;

namespace TraceabilityUI
{
    public partial class TraceabilityForm : Form
    {
        readonly string ProductsFile = "Products.csv";
        Dictionary<ProductModel,HashSet<string>> Products = new Dictionary<ProductModel,HashSet<string>>();
        List<ProductModel> ProductsList = new List<ProductModel>();
        HashSet<string> BakedProducts = new HashSet<string>();
        public TraceabilityForm()
        {
            InitializeComponent();
            customiseDesign();
            LoadData();
            DisplayAllProducts();
            
            //this.Text = String.Empty;
            //this.ControlBox = false;
            // this.DoubleBuffered = true;
            //this.MaximizedBounds = Screen.PrimaryScreen.WorkingArea;

        }

        private void LoadData()
        {
            foreach (IFileConnection connection in GlobalConfig.Connection)
            {
                Products = connection.GetAllProducts(ProductsFile);
            }
        }

        public void DisplayAllProducts()
        {
            foreach (KeyValuePair<ProductModel, HashSet<string>> entry in Products)
            {
                ProductsList.Add(entry.Key);
            }   
                
            {
                if (ProductsList != null)
                    ProductsListBox.DataSource = ProductsList;
                    ProductsListBox.DisplayMember = "DisplayProduct";
            }
        }

        private void OptionsButton_Click(object sender, EventArgs e)
        {
            if (OptionsSubMenuPanel.Visible == false)
            {
                showSubMenu(OptionsSubMenuPanel);
            }
            else
            {
                hideSubMenu();
            }
        }

        private void LogoPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void customiseDesign()
        {
            OptionsSubMenuPanel.Visible = false;
        }

        private void hideSubMenu()
        {
            if (OptionsSubMenuPanel.Visible == true)
            {
                OptionsSubMenuPanel.Visible = false;
            }
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void IngredientsButton_Click(object sender, EventArgs e)
        {
            
            IngredientsForm IngredientsForm = new IngredientsForm();
            openChildForm(IngredientsForm);
            hideSubMenu();
            LoadData();
            DisplayAllProducts();
        }

        private void ProductsButton_Click(object sender, EventArgs e)
        {
            ProductsForm ProductsForm = new ProductsForm();
            openChildForm(ProductsForm);
            hideSubMenu();
            LoadData();
            DisplayAllProducts();
        }

        private void TraceabilitySheetsButton_Click(object sender, EventArgs e)
        {
            SheetsForm SheetsForm = new SheetsForm();
            openChildForm(SheetsForm);
            hideSubMenu();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            ChildFormPanel.Controls.Add(childForm);
            ChildFormPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            TitleLabel.Text = childForm.Text;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = null;
            }
            TitleLabel.Text = "Home";
         
        }

        private void TraceabilityForm_Resize(object sender, EventArgs e)
        {
          //  if(WindowState == FormWindowState.Maximized)
           // {
               // FormBorderStyle = FormBorderStyle.None;
           // }
           // else
           // {
               // FormBorderStyle = FormBorderStyle.Sizable;
           // }
        }

        private void ProductsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
          
        }

        private void AddBakedProduct_Click(object sender, EventArgs e)
        {
            ProductModel Product = (ProductModel)ProductsListBox.SelectedItem;
            BakedProducts.Add(Product.ProductName);
            BakedListBox.DataSource = BakedProducts.ToList();
        }

        private void DeleteBakedProduct_Click(object sender, EventArgs e)
        {

        }

        private void CreateTraceability_Click(object sender, EventArgs e)
        {

        }
    }
}
