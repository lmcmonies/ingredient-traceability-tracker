
namespace TraceabilityUI
{
    partial class SheetsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SheetsForm));
            this.SheetsListBox = new System.Windows.Forms.ListBox();
            this.SheetsLabel = new System.Windows.Forms.Label();
            this.AddNewSheetButton = new System.Windows.Forms.Button();
            this.NewSheetLabel = new System.Windows.Forms.Label();
            this.NewSheetTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // SheetsListBox
            // 
            this.SheetsListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SheetsListBox.Font = new System.Drawing.Font("Segoe UI Semilight", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SheetsListBox.FormattingEnabled = true;
            this.SheetsListBox.ItemHeight = 54;
            this.SheetsListBox.Location = new System.Drawing.Point(471, 137);
            this.SheetsListBox.Name = "SheetsListBox";
            this.SheetsListBox.Size = new System.Drawing.Size(320, 324);
            this.SheetsListBox.TabIndex = 2;
            // 
            // SheetsLabel
            // 
            this.SheetsLabel.AutoSize = true;
            this.SheetsLabel.Font = new System.Drawing.Font("Segoe UI Light", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SheetsLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.SheetsLabel.Location = new System.Drawing.Point(568, 75);
            this.SheetsLabel.Name = "SheetsLabel";
            this.SheetsLabel.Size = new System.Drawing.Size(143, 59);
            this.SheetsLabel.TabIndex = 5;
            this.SheetsLabel.Text = "Sheets";
            // 
            // AddNewSheetButton
            // 
            this.AddNewSheetButton.Font = new System.Drawing.Font("Segoe UI Semilight", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewSheetButton.Location = new System.Drawing.Point(144, 336);
            this.AddNewSheetButton.Name = "AddNewSheetButton";
            this.AddNewSheetButton.Size = new System.Drawing.Size(140, 47);
            this.AddNewSheetButton.TabIndex = 8;
            this.AddNewSheetButton.Text = "Add";
            this.AddNewSheetButton.UseVisualStyleBackColor = true;
            this.AddNewSheetButton.Click += new System.EventHandler(this.AddNewSheetButton_Click);
            // 
            // NewSheetLabel
            // 
            this.NewSheetLabel.AutoSize = true;
            this.NewSheetLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewSheetLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.NewSheetLabel.Location = new System.Drawing.Point(145, 188);
            this.NewSheetLabel.Name = "NewSheetLabel";
            this.NewSheetLabel.Size = new System.Drawing.Size(172, 45);
            this.NewSheetLabel.TabIndex = 7;
            this.NewSheetLabel.Text = "New Sheet";
            // 
            // NewSheetTextBox
            // 
            this.NewSheetTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NewSheetTextBox.Font = new System.Drawing.Font("Segoe UI Semilight", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewSheetTextBox.Location = new System.Drawing.Point(82, 256);
            this.NewSheetTextBox.Name = "NewSheetTextBox";
            this.NewSheetTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.NewSheetTextBox.Size = new System.Drawing.Size(266, 53);
            this.NewSheetTextBox.TabIndex = 6;
            this.NewSheetTextBox.Text = "";
            // 
            // SheetsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(860, 545);
            this.Controls.Add(this.AddNewSheetButton);
            this.Controls.Add(this.NewSheetLabel);
            this.Controls.Add(this.NewSheetTextBox);
            this.Controls.Add(this.SheetsLabel);
            this.Controls.Add(this.SheetsListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SheetsForm";
            this.Text = "Traceability Sheets";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox SheetsListBox;
        private System.Windows.Forms.Label SheetsLabel;
        private System.Windows.Forms.Button AddNewSheetButton;
        private System.Windows.Forms.Label NewSheetLabel;
        private System.Windows.Forms.RichTextBox NewSheetTextBox;
    }
}