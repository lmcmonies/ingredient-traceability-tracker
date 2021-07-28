
namespace TraceabilityUI
{
    partial class BatchNumberForm
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
            this.UpdateBatchNumberButton = new System.Windows.Forms.Button();
            this.batchNumberLabel = new System.Windows.Forms.Label();
            this.IngredientTextBox = new System.Windows.Forms.RichTextBox();
            this.BatchNumLabel = new System.Windows.Forms.Label();
            this.BatchNumberListBox = new System.Windows.Forms.ListBox();
            this.UpdateDateLabel = new System.Windows.Forms.Label();
            this.DateTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // UpdateBatchNumberButton
            // 
            this.UpdateBatchNumberButton.Font = new System.Drawing.Font("Segoe UI Semilight", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBatchNumberButton.Location = new System.Drawing.Point(127, 422);
            this.UpdateBatchNumberButton.Name = "UpdateBatchNumberButton";
            this.UpdateBatchNumberButton.Size = new System.Drawing.Size(140, 47);
            this.UpdateBatchNumberButton.TabIndex = 10;
            this.UpdateBatchNumberButton.Text = "Update";
            this.UpdateBatchNumberButton.UseVisualStyleBackColor = true;
            this.UpdateBatchNumberButton.Click += new System.EventHandler(this.UpdateBatchNumberButton_Click);
            // 
            // batchNumberLabel
            // 
            this.batchNumberLabel.AutoSize = true;
            this.batchNumberLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batchNumberLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.batchNumberLabel.Location = new System.Drawing.Point(131, 275);
            this.batchNumberLabel.Name = "batchNumberLabel";
            this.batchNumberLabel.Size = new System.Drawing.Size(157, 45);
            this.batchNumberLabel.TabIndex = 9;
            this.batchNumberLabel.Text = "Batch No.";
            // 
            // IngredientTextBox
            // 
            this.IngredientTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IngredientTextBox.Font = new System.Drawing.Font("Segoe UI Semilight", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngredientTextBox.Location = new System.Drawing.Point(65, 342);
            this.IngredientTextBox.Name = "IngredientTextBox";
            this.IngredientTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.IngredientTextBox.Size = new System.Drawing.Size(266, 53);
            this.IngredientTextBox.TabIndex = 8;
            this.IngredientTextBox.Text = "";
            // 
            // BatchNumLabel
            // 
            this.BatchNumLabel.AutoSize = true;
            this.BatchNumLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BatchNumLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.BatchNumLabel.Location = new System.Drawing.Point(392, 84);
            this.BatchNumLabel.Name = "BatchNumLabel";
            this.BatchNumLabel.Size = new System.Drawing.Size(554, 45);
            this.BatchNumLabel.TabIndex = 7;
            this.BatchNumLabel.Text = "Ingredient - Batch No. - Date Opened";
            // 
            // BatchNumberListBox
            // 
            this.BatchNumberListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BatchNumberListBox.Font = new System.Drawing.Font("Segoe UI Semilight", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BatchNumberListBox.FormattingEnabled = true;
            this.BatchNumberListBox.ItemHeight = 50;
            this.BatchNumberListBox.Location = new System.Drawing.Point(400, 145);
            this.BatchNumberListBox.Name = "BatchNumberListBox";
            this.BatchNumberListBox.Size = new System.Drawing.Size(448, 350);
            this.BatchNumberListBox.TabIndex = 6;
            // 
            // UpdateDateLabel
            // 
            this.UpdateDateLabel.AutoSize = true;
            this.UpdateDateLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateDateLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.UpdateDateLabel.Location = new System.Drawing.Point(119, 133);
            this.UpdateDateLabel.Name = "UpdateDateLabel";
            this.UpdateDateLabel.Size = new System.Drawing.Size(211, 45);
            this.UpdateDateLabel.TabIndex = 12;
            this.UpdateDateLabel.Text = "Date Opened";
            // 
            // DateTextBox
            // 
            this.DateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DateTextBox.Font = new System.Drawing.Font("Segoe UI Semilight", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTextBox.Location = new System.Drawing.Point(65, 202);
            this.DateTextBox.Name = "DateTextBox";
            this.DateTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.DateTextBox.Size = new System.Drawing.Size(266, 53);
            this.DateTextBox.TabIndex = 11;
            this.DateTextBox.Text = "";
            // 
            // BatchNumberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(962, 587);
            this.Controls.Add(this.UpdateDateLabel);
            this.Controls.Add(this.DateTextBox);
            this.Controls.Add(this.UpdateBatchNumberButton);
            this.Controls.Add(this.batchNumberLabel);
            this.Controls.Add(this.IngredientTextBox);
            this.Controls.Add(this.BatchNumLabel);
            this.Controls.Add(this.BatchNumberListBox);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "BatchNumberForm";
            this.Text = "Batch Number";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UpdateBatchNumberButton;
        private System.Windows.Forms.Label batchNumberLabel;
        private System.Windows.Forms.RichTextBox IngredientTextBox;
        private System.Windows.Forms.Label BatchNumLabel;
        private System.Windows.Forms.ListBox BatchNumberListBox;
        private System.Windows.Forms.Label UpdateDateLabel;
        private System.Windows.Forms.RichTextBox DateTextBox;
    }
}