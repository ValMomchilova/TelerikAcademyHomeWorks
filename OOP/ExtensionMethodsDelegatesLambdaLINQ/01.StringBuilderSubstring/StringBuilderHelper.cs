using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderHelper
{
    public static class StringBuilderHelper
    {
        public static StringBuilder Substring(this StringBuilder source, int index, int length)
        {
            if (index < 0)
            {
                throw new ArgumentOutOfRangeException("StartIndex is less than zero.");
            }

            if (length < 0)
            {
                throw new ArgumentOutOfRangeException("Length is less than zero.");
            }

            if (index + length > source.Length)
            {
                throw new ArgumentOutOfRangeException("StartIndex plus length indicates a position not within this instance..");
            }
            
            StringBuilder reslut = new StringBuilder();

            int endPosition = index + length -1;

            for (int i = index; i <= endPosition; i++)
            {
                reslut.Append(source[i]);
            }

            return reslut;
        }
    }
}
