
namespace TraceabilityUI
{
    partial class IngredientsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IngredientsForm));
            this.IngredientsListBox = new System.Windows.Forms.ListBox();
            this.IngredientsLabel = new System.Windows.Forms.Label();
            this.IngredientTextBox = new System.Windows.Forms.RichTextBox();
            this.AddIngredientsLabel = new System.Windows.Forms.Label();
            this.AddIngredientButton = new System.Windows.Forms.Button();
            this.DeleteIngredientButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IngredientsListBox
            // 
            this.IngredientsListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IngredientsListBox.Font = new System.Drawing.Font("Segoe UI Semilight", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngredientsListBox.FormattingEnabled = true;
            this.IngredientsListBox.ItemHeight = 50;
            this.IngredientsListBox.Location = new System.Drawing.Point(482, 121);
            this.IngredientsListBox.Name = "IngredientsListBox";
            this.IngredientsListBox.Size = new System.Drawing.Size(334, 250);
            this.IngredientsListBox.TabIndex = 0;
            // 
            // IngredientsLabel
            // 
            this.IngredientsLabel.AutoSize = true;
            this.IngredientsLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngredientsLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.IngredientsLabel.Location = new System.Drawing.Point(574, 52);
            this.IngredientsLabel.Name = "IngredientsLabel";
            this.IngredientsLabel.Size = new System.Drawing.Size(177, 45);
            this.IngredientsLabel.TabIndex = 1;
            this.IngredientsLabel.Text = "Ingredients";
            // 
            // IngredientTextBox
            // 
            this.IngredientTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IngredientTextBox.Font = new System.Drawing.Font("Segoe UI Semilight", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngredientTextBox.Location = new System.Drawing.Point(98, 258);
            this.IngredientTextBox.Name = "IngredientTextBox";
            this.IngredientTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.IngredientTextBox.Size = new System.Drawing.Size(266, 53);
            this.IngredientTextBox.TabIndex = 2;
            this.IngredientTextBox.Text = "";
            // 
            // AddIngredientsLabel
            // 
            this.AddIngredientsLabel.AutoSize = true;
            this.AddIngredientsLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddIngredientsLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.AddIngredientsLabel.Location = new System.Drawing.Point(130, 191);
            this.AddIngredientsLabel.Name = "AddIngredientsLabel";
            this.AddIngredientsLabel.Size = new System.Drawing.Size(237, 45);
            this.AddIngredientsLabel.TabIndex = 3;
            this.AddIngredientsLabel.Text = "New Ingredient";
            // 
            // AddIngredientButton
            // 
            this.AddIngredientButton.Font = new System.Drawing.Font("Segoe UI Semilight", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddIngredientButton.Location = new System.Drawing.Point(160, 338);
            this.AddIngredientButton.Name = "AddIngredientButton";
            this.AddIngredientButton.Size = new System.Drawing.Size(140, 47);
            this.AddIngredientButton.TabIndex = 4;
            this.AddIngredientButton.Text = "Add";
            this.AddIngredientButton.UseVisualStyleBackColor = true;
            this.AddIngredientButton.Click += new System.EventHandler(this.AddIngredientButton_Click);
            // 
            // DeleteIngredientButton
            // 
            this.DeleteIngredientButton.Font = new System.Drawing.Font("Segoe UI Semilight", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteIngredientButton.Location = new System.Drawing.Point(582, 438);
            this.DeleteIngredientButton.Name = "DeleteIngredientButton";
            this.DeleteIngredientButton.Size = new System.Drawing.Size(140, 47);
            this.DeleteIngredientButton.TabIndex = 5;
            this.DeleteIngredientButton.Text = "Delete";
            this.DeleteIngredientButton.UseVisualStyleBackColor = true;
            this.DeleteIngredientButton.Click += new System.EventHandler(this.DeleteIngredientButton_Click);
            // 
            // IngredientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(860, 584);
            this.Controls.Add(this.DeleteIngredientButton);
            this.Controls.Add(this.AddIngredientButton);
            this.Controls.Add(this.AddIngredientsLabel);
            this.Controls.Add(this.IngredientTextBox);
            this.Controls.Add(this.IngredientsLabel);
            this.Controls.Add(this.IngredientsListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IngredientsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingredients";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox IngredientsListBox;
        private System.Windows.Forms.Label IngredientsLabel;
        private System.Windows.Forms.RichTextBox IngredientTextBox;
        private System.Windows.Forms.Label AddIngredientsLabel;
        private System.Windows.Forms.Button AddIngredientButton;
        private System.Windows.Forms.Button DeleteIngredientButton;
    }
}