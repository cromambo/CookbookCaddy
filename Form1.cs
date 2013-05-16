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
            Recipe foundRecipe = myCookbook.GetRecipe();
            titleTextBox.Text = foundRecipe.Title;

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
    }
}
