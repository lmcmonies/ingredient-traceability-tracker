using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraceabilityLibrary
{
    public class IngredientModel
    {
        //public int Id { get; internal set; }
        public string IngredientName { get; set; }

        public string DisplayIngredient
        {
            get
            {
                return $"{IngredientName}";
            }
        }
    }
}
