using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookbookCaddy.DataStore
{
    public abstract class CookbookStoreBase
    {
        public static CookbookStoreBase CreateCookbookStore(string fileName)
        {
            return new CookbookStoreXml(fileName);
        }

        public abstract Recipe GetRecipe();
        public abstract List<Recipe> GetRecipeList();
        public abstract bool SaveRecipe();
        public abstract bool UpdateRecipe(Recipe updatedRecipe);
        public abstract bool DeleteRecipe();

    }
}
