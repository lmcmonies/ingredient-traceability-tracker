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

namespace TraceabilityUI
{
    public partial class TraceabilityForm : Form
    {
        public TraceabilityForm()
        {
            InitializeComponent();
            customiseDesign();
            //this.Text = String.Empty;
            //this.ControlBox = false;
           // this.DoubleBuffered = true;
            //this.MaximizedBounds = Screen.PrimaryScreen.WorkingArea;

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
        }

        private void ProductsButton_Click(object sender, EventArgs e)
        {
            ProductsForm ProductsForm = new ProductsForm();
            openChildForm(ProductsForm);
            hideSubMenu();
        }

        private void TraceabilitySheetsButton_Click(object sender, EventArgs e)
        {
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
            if(activeForm != null)
            {
                
                activeForm.Close();
                TitleLabel.Text = activeForm.Text;


            }
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
    }
}
