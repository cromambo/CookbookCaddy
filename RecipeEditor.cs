﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookbookCaddy
{
    public partial class RecipeEditor : Form
    {
        private Cookbook myCookbook = new Cookbook();
        public Recipe editorRecipe { get; set; }


        public RecipeEditor()
        {
            InitializeComponent();
        }

        private void listViewIngredients_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textRecipeName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSaveRecipe_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancelRecipeEditing_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;       
            Close();
        }


        private void RecipeEditor_Load(object sender, EventArgs e)
        {
            editorRecipe = myCookbook.GetRecipe(); //mock for now just to have a recipe
            textRecipeName.Text = editorRecipe.Title;
            foreach(string ingred in editorRecipe.Items)
            {
                listBoxIngredients.Items.Add(ingred);
            }

        }

        private void buttonAddIngredient_Click(object sender, EventArgs e)
        {
            editorRecipe.Items.Add(textAddedIngredient.Text);
            listBoxIngredients.Items.Add(textAddedIngredient.Text);
        }

        private void buttonRemoveIngredient_Click(object sender, EventArgs e)
        {
           // editorRecipe.Items.Remove(listBoxIngredients.SelectedItem.ToString());
        }

    }
}
