using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Classes
{
    public class Leg: ICloneable
    {
        public string Side { get; set; }
        public string Name { get; set; }

        public string Show()
        {
            return "It is " + Side + " " + Name;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
