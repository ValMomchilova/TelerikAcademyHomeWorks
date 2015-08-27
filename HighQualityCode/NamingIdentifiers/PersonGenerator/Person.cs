namespace PersonGenerator
{
    using System;

    public class Person
    {
        public Gender Gender { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public override string ToString()
        {
            return string.Format("Name: {0}, Gender: {1}, Age: {2}", this.Name, this.Gender, this.Age);
        }
    }
}
