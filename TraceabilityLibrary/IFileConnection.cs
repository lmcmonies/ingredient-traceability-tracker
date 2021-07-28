using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraceabilityLibrary
{
    public interface IFileConnection
    {
        //Add Ingredient To Ingredients File
        IngredientModel AddIngredient (IngredientModel Ingredient, string FileName);
        
        //Delete Ingredient In Ingredients File
        IngredientModel DeleteIngredient(IngredientModel Ingredient, string FileName);

        //Retrieve All Ingredients From Ingredients File
        HashSet<IngredientModel> GetAllIngredients(string FileName);

        ProductModel AddProduct(HashSet<string> Ingredients, ProductModel Product, string FileName);

        Dictionary<ProductModel, HashSet<string>> GetAllProducts(string FileName);

        HashSet<SheetModel> GetAllSheets(string FileName);

        SheetModel AddSheet(SheetModel Sheet, string FileName);

        Dictionary<IngredientModel, Tuple<BatchNumberModel,DateModel>> UpdateBatchNumber(string FileName, string Ingredient, string BatchNum, string Date );

        Dictionary<IngredientModel, Tuple<BatchNumberModel,DateModel>> GetAllBatchNumbers(string FileName);
    }
}
