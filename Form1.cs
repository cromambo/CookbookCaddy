using System;
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
    public partial class Form1 : Form
    {
        private Cookbook myCookbook = new Cookbook();

        public Form1()
        {
            InitializeComponent();
        }

        private void requestButton_Click(object sender, EventArgs e)
        {
            RecipeEditor recipeEditorDialogNew = new RecipeEditor();

            ShowRecipeDialog(recipeEditorDialogNew);
        }

        private void buttonEditRecipe_Click(object sender, EventArgs e)
        {
            Recipe temprec = new Recipe();
            temprec = myCookbook.GetRecipe();
            temprec.Title = "Editing";
            //todo: get a recipe from cookbook to send

            RecipeEditor recipeEditorDialogEditing = new RecipeEditor(temprec);

            ShowRecipeDialog(recipeEditorDialogEditing);
        }

        private void ShowRecipeDialog(RecipeEditor recipeEditorDialog)
        {
            if (recipeEditorDialog.ShowDialog() == DialogResult.OK)
            {
                FillRecipeDisplay(recipeEditorDialog.editorRecipe);

                //todo: add new/edited recipe to cookbook here
            }

        }

        private void EmptyRecipeDisplay()
        {

            titleTextBox.Text = "";
            ItemsListBox.Items.Clear();
        }

        private void FillRecipeDisplay(Recipe foundRecipe)
        {
            titleTextBox.Text = foundRecipe.Title;

            ItemsListBox.Items.Clear();
            foreach (string item in foundRecipe.Items)
            {
                ItemsListBox.Items.Add(item);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void titleTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //myCookbook.UpdateRecipe(new Recipe());
            listBoxRecipes.Items.Clear();
            foreach (Recipe rec in myCookbook.GetRecipeList())
            {
                listBoxRecipes.Items.Add(rec.Title);
            }
        }

        private void listBoxRecipes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
