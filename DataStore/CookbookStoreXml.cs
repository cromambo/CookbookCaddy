using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

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

        private Recipe GetRecipeByReader()
        {
            Recipe newRecipe = new Recipe();
            string request = WebServiceMock();
            using (XmlReader reader = XmlReader.Create(new StringReader(request)))
            {
                reader.Read();
                newRecipe.Title = reader.GetAttribute("Title");

                reader.ReadToDescendant("Item");
                List<string> items = new List<string>();


                string newItem = reader.ReadInnerXml();

                while (newItem != string.Empty)
                {
                    items.Add(newItem);
                    newItem = reader.ReadInnerXml();
                }
                newRecipe.Items = items;

            }

            return newRecipe;
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
            if  (!File.Exists(_fileName))
                createXmlStore(_fileName);

            //remove this line to read document and update
            return true;
            
            using (FileStream fs = File.OpenRead(_fileName))
            {
                
            }
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
