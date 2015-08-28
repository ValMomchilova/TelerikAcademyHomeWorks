using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create a  [Version]  attribute that can be applied to 
//structures, classes, interfaces, enumerations and methods and holds a version in the format  major.minor  (e.g.  2.11 ).

namespace VersionAttribute
{
    [AttributeUsage(AttributeTargets.Struct |
        AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Enum | AttributeTargets.Method)]
    public class VersionAttribute : System.Attribute
    {
        public VersionAttribute (double version)
        {
            this.Version = version;
        }

        public double Version { get; private set; }
    }
}
