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
        public string Ingredient { get; set; }
        public string BatchNumber { get; set; }
        public string DateOpened { get; set; }
        public string DateUsed { get; set; }

    }
}
