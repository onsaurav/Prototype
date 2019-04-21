using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Classes
{
    public class Tail: ICloneable
    {
        public string Color { get; set; }

        public string Show()
        {
            return "It has " + Color + " Tail";
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
