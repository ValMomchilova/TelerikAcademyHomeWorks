namespace PersonGenerator
{
    using System;

    public class PersonGeneratorMain
    {
        public static void Main(string[] args)
        {
            PersonGenerator personGenerator = new PersonGenerator();

            Person male = personGenerator.Generate(26);
            Person female = personGenerator.Generate(25);

            Console.WriteLine(male);
            Console.WriteLine(female);
        }
    }
}
