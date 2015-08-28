using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClass
{
    class PersonClassTest
    {
        static void Main()
        {
            Person person = new Person("Ivan Ivanov", 25);
            Person personNoAge = new Person("Galin Petrov");

            Console.WriteLine(person);
            Console.WriteLine(personNoAge);
        }
    }
}
