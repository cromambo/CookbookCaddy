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
    public partial class RecipeEditor : Form
    {
        private Cookbook myCookbook = new Cookbook();
        public Recipe editorRecipe { get; set; }

        public RecipeEditor(Recipe existingRecipe)
        {
            editorRecipe = existingRecipe;
            InitializeComponent();
        }

        public RecipeEditor()
        {
            editorRecipe = myCookbook.GetRecipe(); //mock
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
            editorRecipe.Title = textRecipeName.Text;
            Close();
        }

        private void buttonCancelRecipeEditing_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;       
            Close();
        }


        private void RecipeEditor_Load(object sender, EventArgs e)
        {
            //i could maybe load the current recipe from the sender instead of passing to overloaded constructor?

            textRecipeName.Text = editorRecipe.Title;
            foreach(string ingred in editorRecipe.Items)
            {
                listBoxIngredients.Items.Add(ingred);
            }

        }

        private void buttonAddIngredient_Click(object sender, EventArgs e)
        {
            if (textAddedIngredient.Text.Length > 0)
            {
                editorRecipe.Items.Add(textAddedIngredient.Text);
                listBoxIngredients.Items.Add(textAddedIngredient.Text);
            }
        }

        private void buttonRemoveIngredient_Click(object sender, EventArgs e)
        {
            if (listBoxIngredients.SelectedIndex >= 0)
            {
               // if(listBoxIngredients.Items.Contains(
                editorRecipe.Items.Remove(listBoxIngredients.SelectedIndex.ToString());
                listBoxIngredients.Items.RemoveAt(listBoxIngredients.SelectedIndex);
            }
        }

    }
}
