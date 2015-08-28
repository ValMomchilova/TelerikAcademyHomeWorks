using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    class Dog : Animal
    {
        public Dog(string name)
            :base(name)
        { 
 
        }

        public Dog(string name, int age, Sex sex)
            : base(name, age, sex)
        {

        }        
        
        public override string ProduceSound()
        {
            return String.Format("Dog {0} : Bau - bauuu!", this.Name);
        }
    }
}
