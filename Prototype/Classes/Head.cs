using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Classes
{
    public class Head: ICloneable
    {
        public int Number { get; set; }
        public string Name { get; set; }

        public string Show()
        {
            return "I have " + Number.ToString() + " " + Name;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
