using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    abstract class Prototype
    {
        private String _id;

        public Prototype(string id)
        {
            _id = id;
        }

        public String Id
        {
            get { return _id; }
        }

        public abstract Prototype Clone();
    }
}
