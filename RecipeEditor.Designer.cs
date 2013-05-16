namespace CookbookCaddy
{
    partial class RecipeEditor
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSaveRecipe = new System.Windows.Forms.Button();
            this.buttonCancelRecipeEditing = new System.Windows.Forms.Button();
            this.buttonAddIngredient = new System.Windows.Forms.Button();
            this.buttonRemoveIngredient = new System.Windows.Forms.Button();
            this.textRecipeName = new System.Windows.Forms.TextBox();
            this.textAddedIngredient = new System.Windows.Forms.TextBox();
            this.buttonLoadRecipe = new System.Windows.Forms.Button();
            this.listBoxIngredients = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Add Ingredient";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ingredients";
            // 
            // buttonSaveRecipe
            // 
            this.buttonSaveRecipe.Location = new System.Drawing.Point(89, 304);
            this.buttonSaveRecipe.Name = "buttonSaveRecipe";
            this.buttonSaveRecipe.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveRecipe.TabIndex = 4;
            this.buttonSaveRecipe.Text = "Save";
            this.buttonSaveRecipe.UseVisualStyleBackColor = true;
            this.buttonSaveRecipe.Click += new System.EventHandler(this.buttonSaveRecipe_Click);
            // 
            // buttonCancelRecipeEditing
            // 
            this.buttonCancelRecipeEditing.Location = new System.Drawing.Point(212, 304);
            this.buttonCancelRecipeEditing.Name = "buttonCancelRecipeEditing";
            this.buttonCancelRecipeEditing.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelRecipeEditing.TabIndex = 5;
            this.buttonCancelRecipeEditing.Text = "Cancel";
            this.buttonCancelRecipeEditing.UseVisualStyleBackColor = true;
            this.buttonCancelRecipeEditing.Click += new System.EventHandler(this.buttonCancelRecipeEditing_Click);
            // 
            // buttonAddIngredient
            // 
            this.buttonAddIngredient.Location = new System.Drawing.Point(252, 43);
            this.buttonAddIngredient.Name = "buttonAddIngredient";
            this.buttonAddIngredient.Size = new System.Drawing.Size(35, 20);
            this.buttonAddIngredient.TabIndex = 6;
            this.buttonAddIngredient.Text = "+";
            this.buttonAddIngredient.UseVisualStyleBackColor = true;
            this.buttonAddIngredient.Click += new System.EventHandler(this.buttonAddIngredient_Click);
            // 
            // buttonRemoveIngredient
            // 
            this.buttonRemoveIngredient.Location = new System.Drawing.Point(252, 81);
            this.buttonRemoveIngredient.Name = "buttonRemoveIngredient";
            this.buttonRemoveIngredient.Size = new System.Drawing.Size(35, 23);
            this.buttonRemoveIngredient.TabIndex = 7;
            this.buttonRemoveIngredient.Text = "-";
            this.buttonRemoveIngredient.UseVisualStyleBackColor = true;
            this.buttonRemoveIngredient.Click += new System.EventHandler(this.buttonRemoveIngredient_Click);
            // 
            // textRecipeName
            // 
            this.textRecipeName.Location = new System.Drawing.Point(89, 13);
            this.textRecipeName.Name = "textRecipeName";
            this.textRecipeName.Size = new System.Drawing.Size(157, 20);
            this.textRecipeName.TabIndex = 8;
            this.textRecipeName.TextChanged += new System.EventHandler(this.textRecipeName_TextChanged);
            // 
            // textAddedIngredient
            // 
            this.textAddedIngredient.Location = new System.Drawing.Point(89, 43);
            this.textAddedIngredient.Name = "textAddedIngredient";
            this.textAddedIngredient.Size = new System.Drawing.Size(157, 20);
            this.textAddedIngredient.TabIndex = 9;
            // 
            // buttonLoadRecipe
            // 
            this.buttonLoadRecipe.Location = new System.Drawing.Point(252, 13);
            this.buttonLoadRecipe.Name = "buttonLoadRecipe";
            this.buttonLoadRecipe.Size = new System.Drawing.Size(46, 23);
            this.buttonLoadRecipe.TabIndex = 10;
            this.buttonLoadRecipe.Text = "Load";
            this.buttonLoadRecipe.UseVisualStyleBackColor = true;
            this.buttonLoadRecipe.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxIngredients
            // 
            this.listBoxIngredients.FormattingEnabled = true;
            this.listBoxIngredients.Location = new System.Drawing.Point(89, 81);
            this.listBoxIngredients.Name = "listBoxIngredients";
            this.listBoxIngredients.Size = new System.Drawing.Size(157, 186);
            this.listBoxIngredients.TabIndex = 11;
            // 
            // RecipeEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 383);
            this.Controls.Add(this.listBoxIngredients);
            this.Controls.Add(this.buttonLoadRecipe);
            this.Controls.Add(this.textAddedIngredient);
            this.Controls.Add(this.textRecipeName);
            this.Controls.Add(this.buttonRemoveIngredient);
            this.Controls.Add(this.buttonAddIngredient);
            this.Controls.Add(this.buttonCancelRecipeEditing);
            this.Controls.Add(this.buttonSaveRecipe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RecipeEditor";
            this.Text = "RecipeEditor";
            this.Load += new System.EventHandler(this.RecipeEditor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSaveRecipe;
        private System.Windows.Forms.Button buttonCancelRecipeEditing;
        private System.Windows.Forms.Button buttonAddIngredient;
        private System.Windows.Forms.Button buttonRemoveIngredient;
        private System.Windows.Forms.TextBox textRecipeName;
        private System.Windows.Forms.TextBox textAddedIngredient;
        private System.Windows.Forms.Button buttonLoadRecipe;
        private System.Windows.Forms.ListBox listBoxIngredients;
    }
}