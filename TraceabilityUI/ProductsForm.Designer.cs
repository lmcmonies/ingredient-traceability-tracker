
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
            this.ProductTextBox = new System.Windows.Forms.RichTextBox();
            this.AllIngredientsListBox = new System.Windows.Forms.ListBox();
            this.DeleteProduct = new System.Windows.Forms.Button();
            this.CreateProduct = new System.Windows.Forms.Button();
            this.AllIngredientsLabel = new System.Windows.Forms.Label();
            this.ProductIngredientsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ProductIngredientsListBox
            // 
            this.ProductIngredientsListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductIngredientsListBox.Font = new System.Drawing.Font("Segoe UI Semilight", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductIngredientsListBox.FormattingEnabled = true;
            this.ProductIngredientsListBox.ItemHeight = 50;
            this.ProductIngredientsListBox.Location = new System.Drawing.Point(514, 287);
            this.ProductIngredientsListBox.Name = "ProductIngredientsListBox";
            this.ProductIngredientsListBox.Size = new System.Drawing.Size(306, 250);
            this.ProductIngredientsListBox.TabIndex = 1;
            // 
            // AddProductButton
            // 
            this.AddProductButton.Font = new System.Drawing.Font("Segoe UI Semilight", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProductButton.Location = new System.Drawing.Point(352, 287);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(156, 47);
            this.AddProductButton.TabIndex = 7;
            this.AddProductButton.Text = "Add";
            this.AddProductButton.UseVisualStyleBackColor = true;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // AddIngredientsLabel
            // 
            this.AddIngredientsLabel.AutoSize = true;
            this.AddIngredientsLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddIngredientsLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.AddIngredientsLabel.Location = new System.Drawing.Point(298, 41);
            this.AddIngredientsLabel.Name = "AddIngredientsLabel";
            this.AddIngredientsLabel.Size = new System.Drawing.Size(298, 45);
            this.AddIngredientsLabel.TabIndex = 6;
            this.AddIngredientsLabel.Text = "New Product Name";
            // 
            // ProductTextBox
            // 
            this.ProductTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductTextBox.Font = new System.Drawing.Font("Segoe UI Semilight", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductTextBox.Location = new System.Drawing.Point(235, 110);
            this.ProductTextBox.Name = "ProductTextBox";
            this.ProductTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.ProductTextBox.Size = new System.Drawing.Size(361, 53);
            this.ProductTextBox.TabIndex = 5;
            this.ProductTextBox.Text = "";
            // 
            // AllIngredientsListBox
            // 
            this.AllIngredientsListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AllIngredientsListBox.Font = new System.Drawing.Font("Segoe UI Semilight", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllIngredientsListBox.FormattingEnabled = true;
            this.AllIngredientsListBox.ItemHeight = 50;
            this.AllIngredientsListBox.Location = new System.Drawing.Point(34, 287);
            this.AllIngredientsListBox.Name = "AllIngredientsListBox";
            this.AllIngredientsListBox.Size = new System.Drawing.Size(312, 250);
            this.AllIngredientsListBox.TabIndex = 8;
            // 
            // DeleteProduct
            // 
            this.DeleteProduct.Font = new System.Drawing.Font("Segoe UI Semilight", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteProduct.Location = new System.Drawing.Point(352, 382);
            this.DeleteProduct.Name = "DeleteProduct";
            this.DeleteProduct.Size = new System.Drawing.Size(156, 47);
            this.DeleteProduct.TabIndex = 9;
            this.DeleteProduct.Text = "Delete";
            this.DeleteProduct.UseVisualStyleBackColor = true;
            this.DeleteProduct.Click += new System.EventHandler(this.DeleteProduct_Click);
            // 
            // CreateProduct
            // 
            this.CreateProduct.Font = new System.Drawing.Font("Segoe UI Semilight", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateProduct.Location = new System.Drawing.Point(352, 471);
            this.CreateProduct.Name = "CreateProduct";
            this.CreateProduct.Size = new System.Drawing.Size(156, 47);
            this.CreateProduct.TabIndex = 10;
            this.CreateProduct.Text = "Create";
            this.CreateProduct.UseVisualStyleBackColor = true;
            this.CreateProduct.Click += new System.EventHandler(this.CreateProduct_Click);
            // 
            // AllIngredientsLabel
            // 
            this.AllIngredientsLabel.AutoSize = true;
            this.AllIngredientsLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllIngredientsLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.AllIngredientsLabel.Location = new System.Drawing.Point(97, 230);
            this.AllIngredientsLabel.Name = "AllIngredientsLabel";
            this.AllIngredientsLabel.Size = new System.Drawing.Size(221, 45);
            this.AllIngredientsLabel.TabIndex = 11;
            this.AllIngredientsLabel.Text = "All Ingredients";
            // 
            // ProductIngredientsLabel
            // 
            this.ProductIngredientsLabel.AutoSize = true;
            this.ProductIngredientsLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductIngredientsLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.ProductIngredientsLabel.Location = new System.Drawing.Point(537, 230);
            this.ProductIngredientsLabel.Name = "ProductIngredientsLabel";
            this.ProductIngredientsLabel.Size = new System.Drawing.Size(296, 45);
            this.ProductIngredientsLabel.TabIndex = 12;
            this.ProductIngredientsLabel.Text = "Product Ingredients";
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(860, 584);
            this.Controls.Add(this.ProductIngredientsLabel);
            this.Controls.Add(this.AllIngredientsLabel);
            this.Controls.Add(this.CreateProduct);
            this.Controls.Add(this.DeleteProduct);
            this.Controls.Add(this.AllIngredientsListBox);
            this.Controls.Add(this.AddProductButton);
            this.Controls.Add(this.AddIngredientsLabel);
            this.Controls.Add(this.ProductTextBox);
            this.Controls.Add(this.ProductIngredientsListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProductsForm";
            this.Text = "Add Product";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ProductIngredientsListBox;
        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.Label AddIngredientsLabel;
        private System.Windows.Forms.RichTextBox ProductTextBox;
        private System.Windows.Forms.ListBox AllIngredientsListBox;
        private System.Windows.Forms.Button DeleteProduct;
        private System.Windows.Forms.Button CreateProduct;
        private System.Windows.Forms.Label AllIngredientsLabel;
        private System.Windows.Forms.Label ProductIngredientsLabel;
    }
}