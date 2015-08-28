using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Santase.Tests
{
    class TestRefactor
    {
        int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public void Test()
        {
            int a = 2;
            int b = 3;
            int c = a + b;
        }
    }
}
