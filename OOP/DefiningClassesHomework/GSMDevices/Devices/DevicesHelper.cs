using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GSMDevices
{
    public static class DevicesHelper
    {
        public static string DescriptionToString<T>(this T source)            
        {
            string result = string.Empty;


            FieldInfo fi = source.GetType().GetField(source.ToString());

            DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(
                typeof(DescriptionAttribute), false);

            if (attributes != null && attributes.Length > 0)
            {
                result = attributes[0].Description;
            }
            else
            {
                result = source.ToString();
            }

            return result;
        }
    }
}
