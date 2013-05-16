using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookbookCaddy.DataStore
{
    public abstract class CookbookStoreBase
    {
        public static CookbookStoreBase CreateCookbookStore()
        {
            return new CookbookStoreXml();
        }

        public abstract Recipe GetRecipe();
        public abstract bool SaveRecipe();
        public abstract bool UpdateRecipe();
        public abstract bool DeleteRecipe();

    }
}
