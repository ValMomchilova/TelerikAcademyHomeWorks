using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    class Kitten: Cat
    {
        public Kitten(string name)
            :base(name)
        {
            this.Sex = Sex.Female;
        }

        public Kitten(string name, int age)
            : base(name, age, Sex.Female)
        {

        }

        public override Sex Sex
        {
            get
            {
                return this.sex;
            }
            set 
            {
                this.sex = Sex.Female;
            }
        }
        
        public override string ProduceSound()
        {
            return String.Format("Kitten {0} : Mrrr - miau!", this.Name);
        }
    }
}
