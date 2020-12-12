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
    }
}
