using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TraceabilityLibrary
{
    public static class FileTool
    {
        public static string FilePath(this string FileName)// A csv file
        {
            //Takes the csv file in and appends it to the end of the file path. 
            //Returns this newly appended file.
            return $"{ConfigurationManager.AppSettings["FilePath"]}\\{FileName}";
        }

        /// <summary>
        ///  Takes the fully formed filepath in which was returned from FilePath(), 
        ///  reads all lines in file and adds them to a list.
        /// </summary>
        public static HashSet<string> LoadFile(this string file)
        {
            //checks to see if the file specified exists. If not, emtpty string list returned
            if (!File.Exists(file))
            {
                return new HashSet<string>();
            }
            //adding each line as a string to an array and then converting to a list. 
            return File.ReadAllLines(file).ToHashSet();
        }

        public static List<string> LoadProductFile(this string file)
        {
            //checks to see if the file specified exists. If not, emtpty string list returned
            if (!File.Exists(file))
            {
                return new List<string>();
            }
            //adding each line as a string to an array and then converting to a list. 
            return File.ReadAllLines(file).ToList();
        }
        /// <summary>
        /// Takes the string list in, iterates through each line and delimits
        /// on the comma and adding each element of the line to a string array.
        /// string array then copied to result list of type Address and returned. 
        /// </summary>
        /// <param name="lines"></param>
        /// <returns></returns>
        public static HashSet<IngredientModel> ChangeToIngredient(this HashSet<string> lines)
        {
            HashSet<IngredientModel> Ingredients = new HashSet<IngredientModel>();

            //iterates through the lines list
            foreach (string l in lines)
            {
                //checks the line is not empty
                if (l != "")
                {
                    //comma delimiting the line
                    string[] array = l.Split(',');
                    //creating an Ingredient object from the comma delimited string
                    IngredientModel Ingredient = new IngredientModel();
                    //Ingredient.Id = int.Parse(array[0]);
                    Ingredient.IngredientName = array[0];
                    //adds the created object to the list of type IngredientModel
                    Ingredients.Add(Ingredient);
                }
            }
            //returns the list of Ingredients
            return Ingredients;
        }

        public static Dictionary<ProductModel,HashSet<string>> ChangeToProduct(this List<string> lines)
        {
            Dictionary<ProductModel,HashSet<string>> Products = new Dictionary<ProductModel,HashSet<string>>();
            HashSet<string> Ingredients = new HashSet<string>();

            //iterates through the lines list
            foreach (string l in lines)
            {
                //checks the line is not empty
                if (l != "")
                {
                    //comma delimiting the line
                    string[] array = l.Split(',');
                    //creating an Ingredient object from the comma delimited string
                    ProductModel Product = new ProductModel();
                    Product.ProductName = array[0];
                    for (int i = 1; i < array.Length; i++)
                    {
                        Ingredients.Add(array[i]);
                    }
                    
                    //adds the created object to the list of type IngredientModel
                    Products.Add(Product,Ingredients);
                }
            }
            //returns the list of Ingredients
            return Products;
        }
        public static HashSet<SheetModel> ChangeToSheet(this HashSet<string> lines)
        {
            
            HashSet<SheetModel> Sheets = new HashSet<SheetModel>();

            //iterates through the lines list
            foreach (string l in lines)
            {
                //checks the line is not empty
                if (l != "")
                {
                    //comma delimiting the line
                    string[] array = l.Split(',');
                    SheetModel Sheet = new SheetModel();
                    //Ingredient.Id = int.Parse(array[0]);
                    Sheet.SheetName = array[0];
                    Sheets.Add(Sheet);
                }
            }
            //returns the list of Ingredients
            return Sheets;
        }


        /// <summary>
        /// Takes the Address list and file name in.
        /// Iterates through list adding each value(Id,Name,Url) in a 
        /// comma delimited format to a lines list of type string. Finally, writes all lines 
        /// in lines list to the specified file. Provides options depending 
        /// </summary>
        /// <param name="entries"></param>
        /// <param name="FileName"></param>
        public static void SaveIngredientToFile(this HashSet<IngredientModel> Ingredients, string FileName)
        {
            HashSet<string> lines = new HashSet<string>();

            try
            {
                foreach (IngredientModel Ingredient in Ingredients)
                {
                        lines.Add($"{Ingredient.IngredientName}");
                }
                //write all lines to the specificed file.
                File.WriteAllLines(FileName.FilePath(), lines);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex);
            }
        }
        public static void SaveProductToFile(this Dictionary<ProductModel, HashSet<string>> Product, string FileName)
        {
            List<string> FormattedStrings = new List<string>();
            string FormattedString = "";
            foreach (KeyValuePair<ProductModel, HashSet<string>> entry in Product)
            {
                FormattedString += entry.Key.ProductName + ",";
                    foreach (string item in entry.Value)
                    {
                        FormattedString += item + ",";
                    }
                string FinalString = FormattedString.Remove(FormattedString.Length - 1);
                FormattedStrings.Add(FinalString);
                FormattedString = "";
            }
            File.WriteAllLines(FileName.FilePath(), FormattedStrings);
            }
    }
}
