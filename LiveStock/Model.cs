using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveStock
{
    internal class Model
    {
        public class Cow
        {
            public int Id { get; set; }
            public decimal Cost { get; set; }
            public decimal Weight { get; set; }
            public string Colour { get; set; }
            public decimal Milk { get; set; }
        }

        public class Sheep
        {
            public int Id { get; set; }
            public decimal Cost { get; set; }
            public decimal Weight { get; set; }
            public string Colour { get; set; }
            public decimal Wool { get; set; } //testing
        }
    }
}
