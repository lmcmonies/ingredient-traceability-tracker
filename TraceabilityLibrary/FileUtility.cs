using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraceabilityLibrary
{
    public class FileUtility : IFileConnection
    {
        public IngredientModel AddIngredient(IngredientModel Ingredient, string FileName)
        {
            //Load Text File
            //Convert to List<Url>
            HashSet<IngredientModel> Ingredients =
            FileName.FilePath().LoadFile().ChangeToIngredient();

            //Find Max ID
            //Ensures that the first time a file is created, the first entry is assigned an ID of 1. 
           // int currID = 1;

           // if (Ingredients.Count > 0)
            //{
                //List ordered in descending order by ID. Take first elements 
                //ID and add 1. This is now value of current ID. 
                //currID = Ingredients.OrderByDescending(i => i.Id).First().Id + 1;
            //}
            //Model passed in now assigned to current ID. 
            //Ingredient.Id = currID;
            //Add new Ingredient with new ID
            Ingredients.Add(Ingredient);
            //Convert Url to List<string>
            //Save the List<string> to text file
            Ingredients.SaveIngredientToFile(FileName);

            return Ingredient;
        }

        public IngredientModel DeleteIngredient(IngredientModel Ingredient, string FileName)
        {
            HashSet<IngredientModel> Ingredients =
            FileName.FilePath().LoadFile().ChangeToIngredient();
            Ingredients.RemoveWhere(x => x.IngredientName == Ingredient.IngredientName);
            Ingredients.SaveIngredientToFile(FileName);
            return Ingredient;
        }

        public HashSet<IngredientModel> GetAllIngredients(string FileName)
        {
            return FileName.FilePath().LoadFile().ChangeToIngredient();
        }

        public ProductModel AddProduct(HashSet<string> Ingredients, ProductModel ProductName, string FileName)
        {
            Dictionary<ProductModel, HashSet<string>> Product =
            FileName.FilePath().LoadProductFile().ChangeToProduct();
            Product.Add(ProductName,Ingredients);
            Product.SaveProductToFile(FileName);
            return ProductName;
        }

        public Dictionary<ProductModel,HashSet<string>> GetAllProducts(string FileName)
        {
            return FileName.FilePath().LoadProductFile().ChangeToProduct();
        }

        public HashSet<SheetModel> GetAllSheets(string FileName)
        {
            return FileName.FilePath().LoadFile().ChangeToSheet();
        }
    }
}
