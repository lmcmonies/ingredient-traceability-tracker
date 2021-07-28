using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraceabilityLibrary
{
    public class BatchNumberModel
    {
        public string BatchNumber { get; set; }

        private readonly IngredientModel Ingredient;
        private readonly DateModel Date;

        public string DisplayBatchNumber
        {
            get
            {
                return $"{Ingredient.IngredientName},{BatchNumber},{Date.Date}";
            }
        }

    }
}
