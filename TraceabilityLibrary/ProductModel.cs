using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraceabilityLibrary
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public HashSet<IngredientModel> IngredientsSet { get; set; } = new HashSet<IngredientModel>();

    }
}
