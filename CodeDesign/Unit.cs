using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeDesign
{
    public class Unit
    {
        public int DurationHrs { get; set; }
        public List<Topics> Topic { get; set; } = new List<Topics>();

    }
}
