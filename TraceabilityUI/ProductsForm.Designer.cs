
namespace TraceabilityUI
{
    partial class ProductsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsForm));
            this.ProductIngredientsListBox = new System.Windows.Forms.ListBox();
            this.AddProductButton = new System.Windows.Forms.Button();
            this.AddIngredientsLabel = new System.Windows.Forms.Label();
            this.PoductTextBox = new System.Windows.Forms.RichTextBox();
            this.AllIngredientsListBox = new System.Windows.Forms.ListBox();
            this.DeleteProduct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProductIngredientsListBox
            // 
            this.ProductIngredientsListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductIngredientsListBox.Font = new System.Drawing.Font("Segoe UI Semilight", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductIngredientsListBox.FormattingEnabled = true;
            this.ProductIngredientsListBox.ItemHeight = 50;
            this.ProductIngredientsListBox.Location = new System.Drawing.Point(514, 235);
            this.ProductIngredientsListBox.Name = "ProductIngredientsListBox";
            this.ProductIngredientsListBox.Size = new System.Drawing.Size(334, 250);
            this.ProductIngredientsListBox.TabIndex = 1;
            // 
            // AddProductButton
            // 
            this.AddProductButton.Font = new System.Drawing.Font("Segoe UI Semilight", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProductButton.Location = new System.Drawing.Point(352, 305);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(156, 47);
            this.AddProductButton.TabIndex = 7;
            this.AddProductButton.Text = "Add";
            this.AddProductButton.UseVisualStyleBackColor = true;
            // 
            // AddIngredientsLabel
            // 
            this.AddIngredientsLabel.AutoSize = true;
            this.AddIngredientsLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddIngredientsLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.AddIngredientsLabel.Location = new System.Drawing.Point(331, 43);
            this.AddIngredientsLabel.Name = "AddIngredientsLabel";
            this.AddIngredientsLabel.Size = new System.Drawing.Size(203, 45);
            this.AddIngredientsLabel.TabIndex = 6;
            this.AddIngredientsLabel.Text = "New Product";
            // 
            // PoductTextBox
            // 
            this.PoductTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PoductTextBox.Font = new System.Drawing.Font("Segoe UI Semilight", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PoductTextBox.Location = new System.Drawing.Point(281, 110);
            this.PoductTextBox.Name = "PoductTextBox";
            this.PoductTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.PoductTextBox.Size = new System.Drawing.Size(266, 53);
            this.PoductTextBox.TabIndex = 5;
            this.PoductTextBox.Text = "";
            // 
            // AllIngredientsListBox
            // 
            this.AllIngredientsListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AllIngredientsListBox.Font = new System.Drawing.Font("Segoe UI Semilight", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllIngredientsListBox.FormattingEnabled = true;
            this.AllIngredientsListBox.ItemHeight = 50;
            this.AllIngredientsListBox.Location = new System.Drawing.Point(12, 235);
            this.AllIngredientsListBox.Name = "AllIngredientsListBox";
            this.AllIngredientsListBox.Size = new System.Drawing.Size(334, 250);
            this.AllIngredientsListBox.TabIndex = 8;
            // 
            // DeleteProduct
            // 
            this.DeleteProduct.Font = new System.Drawing.Font("Segoe UI Semilight", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteProduct.Location = new System.Drawing.Point(352, 376);
            this.DeleteProduct.Name = "DeleteProduct";
            this.DeleteProduct.Size = new System.Drawing.Size(156, 47);
            this.DeleteProduct.TabIndex = 9;
            this.DeleteProduct.Text = "Delete";
            this.DeleteProduct.UseVisualStyleBackColor = true;
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(860, 584);
            this.Controls.Add(this.DeleteProduct);
            this.Controls.Add(this.AllIngredientsListBox);
            this.Controls.Add(this.AddProductButton);
            this.Controls.Add(this.AddIngredientsLabel);
            this.Controls.Add(this.PoductTextBox);
            this.Controls.Add(this.ProductIngredientsListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProductsForm";
            this.Text = "Products";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ProductIngredientsListBox;
        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.Label AddIngredientsLabel;
        private System.Windows.Forms.RichTextBox PoductTextBox;
        private System.Windows.Forms.ListBox AllIngredientsListBox;
        private System.Windows.Forms.Button DeleteProduct;
    }
}