﻿namespace CookbookCaddy
{
    partial class Form1
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
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ItemsListBox = new System.Windows.Forms.ListBox();
            this.buttonNewRecipe = new System.Windows.Forms.Button();
            this.buttonEditRecipe = new System.Windows.Forms.Button();
            this.listBoxRecipes = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(227, 48);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.ReadOnly = true;
            this.titleTextBox.Size = new System.Drawing.Size(120, 20);
            this.titleTextBox.TabIndex = 0;
            this.titleTextBox.TextChanged += new System.EventHandler(this.titleTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Items";
            // 
            // ItemsListBox
            // 
            this.ItemsListBox.FormattingEnabled = true;
            this.ItemsListBox.Location = new System.Drawing.Point(227, 99);
            this.ItemsListBox.Name = "ItemsListBox";
            this.ItemsListBox.Size = new System.Drawing.Size(120, 95);
            this.ItemsListBox.TabIndex = 3;
            this.ItemsListBox.SelectedIndexChanged += new System.EventHandler(this.ItemsListBox_SelectedIndexChanged);
            // 
            // buttonNewRecipe
            // 
            this.buttonNewRecipe.Location = new System.Drawing.Point(291, 214);
            this.buttonNewRecipe.Name = "buttonNewRecipe";
            this.buttonNewRecipe.Size = new System.Drawing.Size(75, 23);
            this.buttonNewRecipe.TabIndex = 4;
            this.buttonNewRecipe.Text = "New";
            this.buttonNewRecipe.UseVisualStyleBackColor = true;
            this.buttonNewRecipe.Click += new System.EventHandler(this.requestButton_Click);
            // 
            // buttonEditRecipe
            // 
            this.buttonEditRecipe.Location = new System.Drawing.Point(192, 214);
            this.buttonEditRecipe.Name = "buttonEditRecipe";
            this.buttonEditRecipe.Size = new System.Drawing.Size(75, 23);
            this.buttonEditRecipe.TabIndex = 5;
            this.buttonEditRecipe.Text = "Edit";
            this.buttonEditRecipe.UseVisualStyleBackColor = true;
            this.buttonEditRecipe.Click += new System.EventHandler(this.buttonEditRecipe_Click);
            // 
            // listBoxRecipes
            // 
            this.listBoxRecipes.FormattingEnabled = true;
            this.listBoxRecipes.Location = new System.Drawing.Point(12, 51);
            this.listBoxRecipes.Name = "listBoxRecipes";
            this.listBoxRecipes.Size = new System.Drawing.Size(120, 160);
            this.listBoxRecipes.TabIndex = 6;
            this.listBoxRecipes.SelectedIndexChanged += new System.EventHandler(this.listBoxRecipes_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Known Recipes(its coming!)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 269);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxRecipes);
            this.Controls.Add(this.buttonEditRecipe);
            this.Controls.Add(this.buttonNewRecipe);
            this.Controls.Add(this.ItemsListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titleTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox ItemsListBox;
        private System.Windows.Forms.Button buttonNewRecipe;
        private System.Windows.Forms.Button buttonEditRecipe;
        private System.Windows.Forms.ListBox listBoxRecipes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

