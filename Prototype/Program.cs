using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcretePrototype1 concretePrototype1 = new ConcretePrototype1("I");
            ConcretePrototype1 c1 = (ConcretePrototype1)concretePrototype1.Clone();
            ConcretePrototype2 concretePrototype2 = new ConcretePrototype2("II");
            ConcretePrototype2 c2 = (ConcretePrototype2)concretePrototype2.Clone();

            Console.WriteLine("Cloned: "+c1.Id);
            Console.WriteLine("Cloned: " + c2.Id);

            Console.ReadKey();
        }
    }
}
