using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create a hierarchy  Dog ,  Frog ,  Cat ,  Kitten ,  Tomcat  and define useful constructors and methods.
//Dogs, frogs and cats are  Animals . All animals can produce sound (specified by the  ISound  interface).
//Kittens and tomcats are cats. All animals are described by age, name and sex. Kittens can be only female and tomcats can be only male.
//Each animal produces a specific sound.
//• Create arrays of different kinds of animals and calculate the average age of each kind of animal using a static method (you may use LINQ).


namespace AnimalHierarchy
{
    class AnimalHierarchyTest
    {
        static void Main()
        {
            //Create arrays of different kinds of animals 
            Animal[] animals = new Animal[5];
            animals[0] = new Kitten("Kitty", 1);
            animals[1] = new Tomcat("Tom", 5);
            animals[2] = new Frog("Froggy");
            animals[3] = new Frog("granny Frog", 6, Sex.Female);
            animals[4] = new Dog("Balkan", 4, Sex.Male);

            //test sound
            Console.WriteLine("Test sounds:");
            Console.WriteLine();

            foreach (var item in animals)
            {
                Console.WriteLine(item);
                Console.WriteLine(item.ProduceSound());
            }
            Console.WriteLine();

            //and calculate the average age of each kind of animal using a static method (you may use LINQ).

            var animalsAverageAgeByType = animals.GroupBy(a => a.GetType().Name)
                .Select(g => new { Kind = g.Key, AverageAge = g.Average(item => item.Age) });

            Console.WriteLine("Average age of each kind of animal using a static method");

            foreach (var item in animalsAverageAgeByType)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            var animalsAverageAgeByTypeLINQ =
                from a in animals
                group a by a.GetType().Name into k
                select new { Kind = k.Key, AverageAge = k.Average(a => a.Age) };

            Console.WriteLine("Average age of each kind of animal using LINQ");

            foreach (var item in animalsAverageAgeByTypeLINQ)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

        }
    }
}
