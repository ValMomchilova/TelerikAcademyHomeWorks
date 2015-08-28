using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    class Tomcat: Cat
    {
       public Tomcat(string name)
            :base(name)
        {
            this.Sex = Sex.Male;
        }

       public Tomcat(string name, int age)
           : base(name, age, Sex.Male)
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
                this.sex = Sex.Male;
            }
        }
        
        public override string ProduceSound()
        {
            return String.Format("Tomcat {0} : MIAUU - miau!", this.Name);
        }
    }
}
