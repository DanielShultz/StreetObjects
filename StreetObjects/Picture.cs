using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreetObjects
{
    public class Picture
    {
        public ICollection<Car> car {get;set; }
        public int people { get; set; }
        public Road road { get; set; }
        public Image picture { get; set; }
        public ICollection<Sign> sign { get; set; }
        public bool trafficLight { get; set; }
        public Color trafficLightColor { get; set; }
        public bool trafficCop { get; set; }
        public Picture()
        {
            sign = new List<Sign>();
            car = new List<Car>();
        }
    }
}