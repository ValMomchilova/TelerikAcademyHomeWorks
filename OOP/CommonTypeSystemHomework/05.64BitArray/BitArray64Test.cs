using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Define a class  BitArray64  to hold  64  bit values inside an  ulong  value.
//• Implement  IEnumerable<int>  and  Equals(…) ,  GetHashCode() ,  [] ,  ==  and  != .


namespace BitArray64
{
    class BitArray64Test
    {
        static void Main()
        {

            Console.WriteLine("New BitArray64 bitArray1 (ulong as constuctor parameter):");
            BitArray64 bitArray1 = new BitArray64(25);
            Console.WriteLine(bitArray1);

            Console.WriteLine("New BitArray64 bitArray2 (string represented bynary number as constuctor parameter):");
            BitArray64 bitArray2 = new BitArray64("11001");
            Console.WriteLine(bitArray2);
            Console.WriteLine();

            Console.WriteLine("print foreach");

            foreach (var item in bitArray2)
            {
                Console.Write(item);
                Console.Write('\t');
            }

            Console.WriteLine();

            Console.WriteLine("Bit at position {0} = {1}", 3, bitArray2[3]);
            Console.WriteLine();

            Console.WriteLine("bitArray1 eaquals to bitArray2? {0}", bitArray1.Equals(bitArray2));
            Console.WriteLine("bitArray1 == bitArray2? {0}", bitArray1 == bitArray2);
            Console.WriteLine("bitArray1 != bitArray2? {0}", bitArray1 != bitArray2);
            Console.WriteLine();
                
           Console.WriteLine("Hash code: {0}", bitArray1.GetHashCode());
        }
    }
}
