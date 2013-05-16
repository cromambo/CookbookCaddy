using CookbookCaddy.DataStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookbookCaddy
{
    class Cookbook
    {
        private CookbookStoreBase recipeStorage = CookbookStoreBase.CreateCookbookStore();


        internal Recipe GetRecipe()
        {
            return recipeStorage.GetRecipe();
        }
    }
}
