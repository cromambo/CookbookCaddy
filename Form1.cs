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
            Recipe foundRecipe = new Recipe();
            foundRecipe = getRecipeFromDialog();
            //need to not fill if recipe was cancelled, not sure how to indicate that
            FillWithRecipe(foundRecipe); 
        }

        private void FillWithRecipe(Recipe foundRecipe)
        {
            titleTextBox.Text = foundRecipe.Title;

            ItemsListBox.Items.Clear();
            foreach (string item in foundRecipe.Items)
            {
                ItemsListBox.Items.Add(item);
            }
        }

        private Recipe getRecipeFromDialog()
        {
            Recipe enteredRecipe = new Recipe();
            RecipeEditor recipeEditorDialog = new RecipeEditor();
            if (recipeEditorDialog.ShowDialog() == DialogResult.OK)
            {
                enteredRecipe = recipeEditorDialog.editorRecipe;
            }
            else
            {
                //something for cancelled?
            }

            recipeEditorDialog.Dispose();

            return enteredRecipe;
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
    }
}
