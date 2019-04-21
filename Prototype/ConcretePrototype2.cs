﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class ConcretePrototype2:Prototype
    {
         public ConcretePrototype2(String id)
            : base(id)
        {

        }

        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }
}
