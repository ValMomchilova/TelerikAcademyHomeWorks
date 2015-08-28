using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    public abstract class Animal: ISound
    {
        private int? age;
        private string name;
        protected Sex sex;

        public Animal(string name)
        {
            this.Name = name;
        }

        public Animal(string name, int age, Sex sex)
            : this(name)
        {
            this.Age = age;
            this.Sex = sex;
        }

        public int? Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age can not be less than zero.");
                }

                this.age = value;
            }
        }
        
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name can not be null or empty");
                }

                this.name = value;
            }
        }

        public virtual Sex Sex
        {
            get
            {
                return this.sex;
            }
            set
            {                
                this.sex = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1} Age: {2} Sex: {3}", this.GetType().Name, this.Name, this.Age, this.Sex);
        }

        public abstract string ProduceSound();        
    }
}
