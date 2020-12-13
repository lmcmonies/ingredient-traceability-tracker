using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraceabilityLibrary
{
    public class SheetModel
    {
        public string SheetName { get; set; }

        public string DisplaySheet
        {
            get
            {
                return $"{SheetName}";
            }
        }
    }
}
