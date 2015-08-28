using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    class Cat : Animal
    {
        public Cat(string name)
            :base(name)
        { 
 
        }

        public Cat(string name, int age, Sex sex)
            : base(name, age, sex)
        {

        }        
        
        public override string ProduceSound()
        {
            return String.Format("Cat {0} : Miau - miau!", this.Name);
        }
    }
}


