using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Define a class  BitArray64  to hold  64  bit values inside an  ulong  value.
//• Implement  IEnumerable<int>  and  Equals(…) ,  GetHashCode() ,  [] ,  ==  and  != .

namespace BitArray64
{
    public class BitArray64 : IEnumerable<int>
    {
        private const int MAX_POSITION = 64;

        private ulong number;

        public BitArray64(string binaryNumber)
        {
            this.number = ConvertBinaryToDecimal(binaryNumber);
        }

        public BitArray64(ulong number)
        {
            this.number = number;
        }

        public string BinaryNumber
        {
            get
            {
                return ConvertDecimalToBinary(this.number);
            }
        }

        public int[] BitArray
        {
            get
            {
                return ConvertToArray(this.number);
            }
        }

        public ulong DecimalNumber
        {
            get
            {
                return this.number;
            }
        }

        public int this[int pos]
        {
            get
            {
                if (pos < 0 || pos >= MAX_POSITION)
                {
                    throw new IndexOutOfRangeException(string.Format("Index is out of range. Min index is {0}. Max index i {1}.",
                      0, MAX_POSITION));
                }

                return ((int)(this.number >> pos) & 1);
            }
            set
            {
                if (pos < 0 || pos >= MAX_POSITION)
                {
                    throw new IndexOutOfRangeException(string.Format("Index is out of range. Min index is {0}. Max index i {1}.",
                      0, MAX_POSITION));
                }


                if (value < 0 || value > 1)
                {
                    throw new ArgumentException("Invalid bit value. Value must be 0 or 1.");
                }


                if (((int)(this.number >> pos) & 1) != value)
                {
                    this.number ^= (1ul << pos);
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < MAX_POSITION - 1; i++)
            {
                yield return this[i];
            }
        }

        public override bool Equals(object obj)
        {
            return this.number == (obj as BitArray64).number;
        }

        public static bool operator ==(BitArray64 bitArray1, BitArray64 bitArray2)
        {
            return bitArray1.Equals(bitArray2);
        }

        public static bool operator !=(BitArray64 bitArray1, BitArray64 bitArray2)
        {
            return !bitArray1.Equals(bitArray2);
        }

        public override int GetHashCode()
        {
            return this.number.GetHashCode();
        }

        public override string ToString()
        {
            return ConvertDecimalToBinary(this.number);
        }

        private ulong ConvertBinaryToDecimal(string binaryNumber)
        {
            if (binaryNumber.Length > MAX_POSITION)
            {
                throw new ArgumentException(string.Format("Binary number should have {0} digits maximun", MAX_POSITION));
            }

            ulong systemBase = 2; // Binary
            ulong decimalNumber = 0;
            ulong pow = 1;

            for (int i = binaryNumber.Length - 1; i >= 0; i--)
            {
                ulong digit = (ulong)(binaryNumber[i] - '0');

                if (digit < 0 || digit > 1)
                {
                    throw new ArgumentException("Binary number is not valid. Only digits 0 and 1 are expected.");
                }

                decimalNumber += digit * pow;
                pow *= systemBase;
            }

            return decimalNumber;
        }

        private string ConvertDecimalToBinary(ulong decimalNumber)
        {
            string result = "0";

            if (decimalNumber != 0)
            {
                int[] array = ConvertToArray(decimalNumber);
                result = string.Join("", array);
                result = result.TrimStart(new char[] { '0' });
            }

            return result;
        }

        private int[] ConvertToArray(ulong decimalNumber)
        {
            ulong systemBase = 2; // Binary
            string otherSystemNumber = string.Empty;
            int[] resultArray = new int[MAX_POSITION];
            ulong decimalNumberTemp = decimalNumber;
            int position = resultArray.Length - 1;

            while (decimalNumberTemp > 0)
            {
                ulong digit = decimalNumberTemp % systemBase;
                resultArray[position] = (int)digit;
                position--;
                decimalNumberTemp /= systemBase;
            }

            return resultArray;
        }
    }
}
