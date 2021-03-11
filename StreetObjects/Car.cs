using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreetObjects
{
    public class Car
    {
        public Color color {get;set;}
        public CarType type { get; set; }
        public string Name()
        {
            return (color.name + " " + type.name);
        }
    }
}
