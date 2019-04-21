using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Classes
{
    public class Animal
    {
        public Head AHead { get; set; }
        public List<Leg> Legs { get; set; }
        public Tail ATail { get; set; }
        public string Name { get; set; }

        public Animal()
        {
            AHead = new Head();
            Legs = new List<Leg>();
            ATail = new Tail();
        }

        //Constructor to implement the deep copy here
        public Animal(Animal aAnimal)
        {
            Name = aAnimal.Name;
            AHead = (Head)aAnimal.AHead.Clone();

            Legs = new List<Leg>();
            foreach (Leg aLeg in aAnimal.Legs)
            {
                Legs.Add((Leg)aLeg.Clone());
            }
            ATail = (Tail)aAnimal.ATail.Clone();
        }

        //Helper method to show the result from client
        public List<string> Show()
        {
            List<string> list = new List<string>();

            list.Add("It is " + Name);
            list.Add(AHead.Show());

            foreach (Leg aleg in Legs)
            {
                list.Add(aleg.Show());
            }

            list.Add(ATail.Show());

            return list;
        }

        #region ICloneable Members
        public object Clone()
        {
            return new Animal(this);
        }
        #endregion
    }
}
