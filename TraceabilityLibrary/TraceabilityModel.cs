using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraceabilityLibrary
{
    public class TraceabilityModel
    {
        //public int Id { get; internal set; }
        
        public ProductModel Product { get; set; }
        public IngredientModel Ingredient { get; set; }
        public BatchNumberModel BatchNumber { get; set; }
        public DateModel DateOpened { get; set; }
        public string DateUsed { get; set; }

        Dictionary<ProductModel, Dictionary<IngredientModel, HashSet<TraceabilityModel>>> Traceability = 
            new Dictionary<ProductModel, Dictionary<IngredientModel, HashSet<TraceabilityModel>>>();
    }
}
