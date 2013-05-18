using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookbookCaddy
{
    public class Recipe
    {
        public List<string> Items;
        public string Title { get; set; }

        public Recipe()
        {
            Items = new List<string>();
        }
    }
}
