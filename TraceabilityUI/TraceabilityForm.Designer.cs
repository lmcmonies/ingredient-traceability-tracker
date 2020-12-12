﻿
namespace TraceabilityUI
{
    partial class TraceabilityForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TraceabilityForm));
            this.SideMenuPanel = new System.Windows.Forms.Panel();
            this.OptionsSubMenuPanel = new System.Windows.Forms.Panel();
            this.TraceabilitySheetsButton = new System.Windows.Forms.Button();
            this.ProductsButton = new System.Windows.Forms.Button();
            this.IngredientsButton = new System.Windows.Forms.Button();
            this.OptionsButton = new System.Windows.Forms.Button();
            this.LogoPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.ChildFormPanel = new System.Windows.Forms.Panel();
            this.TitleBar = new System.Windows.Forms.Panel();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.BakedLabel = new System.Windows.Forms.Label();
            this.BakedListBox = new System.Windows.Forms.ListBox();
            this.ProductsLabel = new System.Windows.Forms.Label();
            this.ProductsListBox = new System.Windows.Forms.ListBox();
            this.SideMenuPanel.SuspendLayout();
            this.OptionsSubMenuPanel.SuspendLayout();
            this.LogoPanel.SuspendLayout();
            this.ChildFormPanel.SuspendLayout();
            this.TitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // SideMenuPanel
            // 
            this.SideMenuPanel.AutoScroll = true;
            this.SideMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.SideMenuPanel.Controls.Add(this.OptionsSubMenuPanel);
            this.SideMenuPanel.Controls.Add(this.OptionsButton);
            this.SideMenuPanel.Controls.Add(this.LogoPanel);
            this.SideMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.SideMenuPanel.Name = "SideMenuPanel";
            this.SideMenuPanel.Size = new System.Drawing.Size(250, 680);
            this.SideMenuPanel.TabIndex = 0;
            // 
            // OptionsSubMenuPanel
            // 
            this.OptionsSubMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(39)))));
            this.OptionsSubMenuPanel.Controls.Add(this.TraceabilitySheetsButton);
            this.OptionsSubMenuPanel.Controls.Add(this.ProductsButton);
            this.OptionsSubMenuPanel.Controls.Add(this.IngredientsButton);
            this.OptionsSubMenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.OptionsSubMenuPanel.Location = new System.Drawing.Point(0, 113);
            this.OptionsSubMenuPanel.Name = "OptionsSubMenuPanel";
            this.OptionsSubMenuPanel.Size = new System.Drawing.Size(250, 124);
            this.OptionsSubMenuPanel.TabIndex = 2;
            // 
            // TraceabilitySheetsButton
            // 
            this.TraceabilitySheetsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.TraceabilitySheetsButton.FlatAppearance.BorderSize = 0;
            this.TraceabilitySheetsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.TraceabilitySheetsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TraceabilitySheetsButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.TraceabilitySheetsButton.Location = new System.Drawing.Point(0, 80);
            this.TraceabilitySheetsButton.Name = "TraceabilitySheetsButton";
            this.TraceabilitySheetsButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.TraceabilitySheetsButton.Size = new System.Drawing.Size(250, 40);
            this.TraceabilitySheetsButton.TabIndex = 2;
            this.TraceabilitySheetsButton.Text = "Traceability Sheets";
            this.TraceabilitySheetsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TraceabilitySheetsButton.UseVisualStyleBackColor = true;
            this.TraceabilitySheetsButton.Click += new System.EventHandler(this.TraceabilitySheetsButton_Click);
            // 
            // ProductsButton
            // 
            this.ProductsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProductsButton.FlatAppearance.BorderSize = 0;
            this.ProductsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.ProductsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProductsButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.ProductsButton.Location = new System.Drawing.Point(0, 40);
            this.ProductsButton.Name = "ProductsButton";
            this.ProductsButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.ProductsButton.Size = new System.Drawing.Size(250, 40);
            this.ProductsButton.TabIndex = 1;
            this.ProductsButton.Text = "Products";
            this.ProductsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProductsButton.UseVisualStyleBackColor = true;
            this.ProductsButton.Click += new System.EventHandler(this.ProductsButton_Click);
            // 
            // IngredientsButton
            // 
            this.IngredientsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.IngredientsButton.FlatAppearance.BorderSize = 0;
            this.IngredientsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.IngredientsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IngredientsButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.IngredientsButton.Location = new System.Drawing.Point(0, 0);
            this.IngredientsButton.Name = "IngredientsButton";
            this.IngredientsButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.IngredientsButton.Size = new System.Drawing.Size(250, 40);
            this.IngredientsButton.TabIndex = 0;
            this.IngredientsButton.Text = "Ingredients";
            this.IngredientsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IngredientsButton.UseVisualStyleBackColor = true;
            this.IngredientsButton.Click += new System.EventHandler(this.IngredientsButton_Click);
            // 
            // OptionsButton
            // 
            this.OptionsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.OptionsButton.FlatAppearance.BorderSize = 0;
            this.OptionsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.OptionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OptionsButton.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionsButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.OptionsButton.Location = new System.Drawing.Point(0, 68);
            this.OptionsButton.Name = "OptionsButton";
            this.OptionsButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.OptionsButton.Size = new System.Drawing.Size(250, 45);
            this.OptionsButton.TabIndex = 1;
            this.OptionsButton.Text = "Options";
            this.OptionsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OptionsButton.UseVisualStyleBackColor = true;
            this.OptionsButton.Click += new System.EventHandler(this.OptionsButton_Click);
            // 
            // LogoPanel
            // 
            this.LogoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.LogoPanel.Controls.Add(this.label1);
            this.LogoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoPanel.ForeColor = System.Drawing.Color.Gainsboro;
            this.LogoPanel.Location = new System.Drawing.Point(0, 0);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(250, 68);
            this.LogoPanel.TabIndex = 0;
            this.LogoPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.LogoPanel_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "Traceability";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ChildFormPanel
            // 
            this.ChildFormPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.ChildFormPanel.Controls.Add(this.TitleBar);
            this.ChildFormPanel.Controls.Add(this.BakedLabel);
            this.ChildFormPanel.Controls.Add(this.BakedListBox);
            this.ChildFormPanel.Controls.Add(this.ProductsLabel);
            this.ChildFormPanel.Controls.Add(this.ProductsListBox);
            this.ChildFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChildFormPanel.Location = new System.Drawing.Point(250, 0);
            this.ChildFormPanel.Name = "ChildFormPanel";
            this.ChildFormPanel.Size = new System.Drawing.Size(898, 680);
            this.ChildFormPanel.TabIndex = 1;
            // 
            // TitleBar
            // 
            this.TitleBar.Controls.Add(this.TitleLabel);
            this.TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBar.Location = new System.Drawing.Point(0, 0);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(898, 68);
            this.TitleBar.TabIndex = 5;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.TitleLabel.Location = new System.Drawing.Point(23, 12);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(107, 45);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Home";
            // 
            // BakedLabel
            // 
            this.BakedLabel.AutoSize = true;
            this.BakedLabel.Font = new System.Drawing.Font("Segoe UI Light", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BakedLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.BakedLabel.Location = new System.Drawing.Point(459, 123);
            this.BakedLabel.Name = "BakedLabel";
            this.BakedLabel.Size = new System.Drawing.Size(249, 59);
            this.BakedLabel.TabIndex = 4;
            this.BakedLabel.Text = "Baked Today";
            // 
            // BakedListBox
            // 
            this.BakedListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BakedListBox.FormattingEnabled = true;
            this.BakedListBox.ItemHeight = 20;
            this.BakedListBox.Location = new System.Drawing.Point(446, 186);
            this.BakedListBox.Name = "BakedListBox";
            this.BakedListBox.Size = new System.Drawing.Size(281, 300);
            this.BakedListBox.TabIndex = 3;
            // 
            // ProductsLabel
            // 
            this.ProductsLabel.AutoSize = true;
            this.ProductsLabel.Font = new System.Drawing.Font("Segoe UI Light", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductsLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.ProductsLabel.Location = new System.Drawing.Point(83, 123);
            this.ProductsLabel.Name = "ProductsLabel";
            this.ProductsLabel.Size = new System.Drawing.Size(181, 59);
            this.ProductsLabel.TabIndex = 2;
            this.ProductsLabel.Text = "Products";
            // 
            // ProductsListBox
            // 
            this.ProductsListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductsListBox.FormattingEnabled = true;
            this.ProductsListBox.ItemHeight = 20;
            this.ProductsListBox.Location = new System.Drawing.Point(31, 186);
            this.ProductsListBox.Name = "ProductsListBox";
            this.ProductsListBox.Size = new System.Drawing.Size(286, 300);
            this.ProductsListBox.TabIndex = 1;
            // 
            // TraceabilityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 680);
            this.Controls.Add(this.ChildFormPanel);
            this.Controls.Add(this.SideMenuPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1148, 680);
            this.Name = "TraceabilityForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Resize += new System.EventHandler(this.TraceabilityForm_Resize);
            this.SideMenuPanel.ResumeLayout(false);
            this.OptionsSubMenuPanel.ResumeLayout(false);
            this.LogoPanel.ResumeLayout(false);
            this.LogoPanel.PerformLayout();
            this.ChildFormPanel.ResumeLayout(false);
            this.ChildFormPanel.PerformLayout();
            this.TitleBar.ResumeLayout(false);
            this.TitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SideMenuPanel;
        private System.Windows.Forms.Panel OptionsSubMenuPanel;
        private System.Windows.Forms.Button TraceabilitySheetsButton;
        private System.Windows.Forms.Button ProductsButton;
        private System.Windows.Forms.Button IngredientsButton;
        private System.Windows.Forms.Button OptionsButton;
        private System.Windows.Forms.FlowLayoutPanel LogoPanel;
        private System.Windows.Forms.Panel ChildFormPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ProductsLabel;
        private System.Windows.Forms.ListBox ProductsListBox;
        private System.Windows.Forms.Label BakedLabel;
        private System.Windows.Forms.ListBox BakedListBox;
        private System.Windows.Forms.Panel TitleBar;
        private System.Windows.Forms.Label TitleLabel;
    }
}

