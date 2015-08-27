namespace PersonGenerator
{
    using System;

    public class PersonGenerator
    {
        private const string MaleName = "Батката";

        private const string FemaleName = "Мацето";
        
        public Person Generate(int generationSourceNumber)
        {
            Person person = new Person();

            person.Age = generationSourceNumber;

            if (generationSourceNumber % 2 == 0)
            {
                person.Name = MaleName;
                person.Gender = Gender.Male;
            }
            else
            {
                person.Name = FemaleName;
                person.Gender = Gender.Female;
            }

            return person;
        }
    }
}
