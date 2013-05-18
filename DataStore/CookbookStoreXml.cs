using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace CookbookCaddy.DataStore
{
    public class CookbookStoreXml : CookbookStoreBase
    {
        private string _fileName;

        public CookbookStoreXml(string fileName)
        {
            _fileName = fileName;
        }

        public override Recipe GetRecipe()
        {
            return GetRecipeByXmlDom();
        }

        public override List<Recipe> GetRecipeList()
        {
            List<Recipe> recipelist = new List<Recipe>();
            if (File.Exists(_fileName))
            {
                GetRecipeListByXDoc(ref recipelist);
            }
            return recipelist;
        }

        private Recipe GetRecipeByXmlDom()
        {
            string request = WebServiceMock();

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(request);
            XmlNode node = doc.SelectSingleNode("/Recipe");
            Recipe returnRecipe = new Recipe();
            returnRecipe.Title = node.Attributes.GetNamedItem("Title").Value;
            returnRecipe.Items = new List<string>();
            foreach (XmlNode item in node.SelectNodes("./Ingredients/Item"))
            {
                returnRecipe.Items.Add(item.InnerText);
            }
            return returnRecipe;

        }

        private void GetRecipeListByReader(ref List<Recipe> recipelist)
        {
            using (FileStream fs = File.OpenRead(_fileName))
            {
                using (XmlReader reader = XmlReader.Create(fs))
                {
                    reader.ReadToFollowing("Cookbook");

                    while (reader.ReadToFollowing("Recipe")) 
                    {
                        Recipe newRecipe = new Recipe();
                        List<string> items = new List<string>();

                        newRecipe.Title = reader.GetAttribute("Title");

                        reader.ReadToDescendant("Ingredients");
                        reader.ReadToDescendant("Item"); //what if there are no items?
                        do
                        {
                            string newItem = reader.ReadElementContentAsString();
                            items.Add(newItem);

                        } while (reader.ReadToNextSibling("Item"));

                        newRecipe.Items = items;

                        recipelist.Add(newRecipe);
                    }
                }
            }
        }
        private void GetRecipeListByXmlDom(ref List<Recipe> recipelist)
        {
            string inputDocContents = File.ReadAllText(_fileName);

            XmlDocument doc = new XmlDocument();

            doc.LoadXml(inputDocContents);
            XmlNode cookbook = doc.SelectSingleNode("Cookbook");
            XmlNodeList recipeNodes = cookbook.SelectNodes("./Recipe");
            if (recipeNodes.Count > 0)
            {
                foreach (XmlNode node in recipeNodes)
                {
                    Recipe newRecipe = new Recipe();
                    newRecipe.Title = node.Attributes.GetNamedItem("Title").Value;
                    newRecipe.Items = new List<string>();
                    foreach (XmlNode item in node.SelectNodes("./Ingredients/Item"))
                    {
                        newRecipe.Items.Add(item.InnerText);
                    }
                    recipelist.Add(newRecipe);
                }
            }
        }

        private void GetRecipeListByXDoc(ref List<Recipe> recipelist)
        {
            XDocument doc = XDocument.Load(_fileName);
            foreach (XElement recipeElement in doc.Descendants("Recipe"))
            {
                Recipe newRecipe = new Recipe();
                // newRecipe.Items = new List<string>();
                newRecipe.Title = recipeElement.Attribute("Title").Value;

                foreach (XElement item in recipeElement.Descendants("Item"))
                {
                    newRecipe.Items.Add(item.Value);
                }

                recipelist.Add(newRecipe);
            }

        }

        private string WebServiceMock()
        {
            return "<Recipe Title='Fava Bean Soup'><Ingredients><Item>Fava Beans</Item><Item>Water</Item><Item>Salt</Item></Ingredients></Recipe>";
        }

        public override bool SaveRecipe()
        {
            throw new NotImplementedException();
        }

        public override bool UpdateRecipe(Recipe updatedRecipe)
        {
            if (!File.Exists(_fileName))
                createXmlStore(_fileName);

            //remove this line to read document and update
            //return true;

            using (FileStream fs = File.OpenRead(_fileName))
            {
                ;
            }
            return true;
        }

        private void createXmlStore(string fileName)
        {
            using (XmlWriter writer = XmlWriter.Create(fileName))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("Cookbook");
                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
        }

        public override bool DeleteRecipe()
        {
            throw new NotImplementedException();
        }
    }
}
