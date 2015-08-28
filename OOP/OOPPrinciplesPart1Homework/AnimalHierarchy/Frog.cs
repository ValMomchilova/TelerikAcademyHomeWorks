using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    class Frog: Animal
    {
        public Frog(string name)
            :base(name)
        { 
 
        }

        public Frog(string name, int age, Sex sex)
            : base(name, age, sex)
        {

        }        
        
        public override string ProduceSound()
        {
            return String.Format("Frog {0} : Qua - qua!", this.Name);
        }
    }
}
