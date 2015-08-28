using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace VersionAttribute
{
    [Version (2.11)]
    class VersionAttributeTest
    {
        static void Main()
        {
            Type type = typeof(VersionAttributeTest);
            object[] attibutes = type.GetCustomAttributes().ToArray();

            double version = 0;
            
            foreach (object item in attibutes)
            {
                if(item.GetType() == typeof(VersionAttribute))
                {
                    version = ((VersionAttribute)item).Version;
                }
            }

            Console.WriteLine("Version: {0}", version);
        }
    }
}
