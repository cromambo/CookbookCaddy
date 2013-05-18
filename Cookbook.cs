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
        private CookbookStoreBase recipeStorage = CookbookStoreBase.CreateCookbookStore("RecipeInput.xml");
        private List<Recipe> recipelist;

        internal List<Recipe> GetRecipeList()
        {
            return recipeStorage.GetRecipeList(); //this is remaking it from file every call, at the moment
        }

        internal bool UpdateRecipe(Recipe updatedRecipe)
        {
            return recipeStorage.UpdateRecipe(updatedRecipe);
        }

        internal Recipe GetRecipe()
        {
            return recipeStorage.GetRecipe();
        }
    }
}
