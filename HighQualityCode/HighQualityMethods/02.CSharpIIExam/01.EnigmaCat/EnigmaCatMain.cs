namespace EnigmaCat
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;
    using System.Text;

    public class EnigmaCatMain
    {
        public static void Main()
        {
            string[] inputNumbers = ReadInput();

            int initialSystemBase = 17;
            int resultSystemBase = 26;

            EnigmaCat enigmaCat = new EnigmaCat();

            string resultNumber = enigmaCat.ConvertFromNummericSystemToOther(inputNumbers, initialSystemBase, resultSystemBase);

            Console.WriteLine(resultNumber);
        }

        public static string[] ReadInput()
        {
            string input = Console.ReadLine();

            string inputTrimmed = input.Trim();

            string[] numbers = inputTrimmed.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            return numbers;
        }

        public class EnigmaCat
        {
            public string ConvertFromNummericSystemToOther(string[] numbers, int initialSystemBase, int resultSystemBase)
            {
                List<string> resultNumbers = new List<string>();

                for (int i = 0; i < numbers.Length; i++)
                {
                    BigInteger decimalNum = this.ConvertNumeralSystemToDecimal(numbers[i], initialSystemBase);
                    string res = this.ConvertDecimalToNumeralSystem(decimalNum, resultSystemBase);
                    resultNumbers.Add(res);
                }

                string result = string.Join(" ", resultNumbers);

                return result;
            }

            public BigInteger ConvertNumeralSystemToDecimal(string numeralSystemNumber, int systemBase)
            {
                BigInteger decimalNumber = 0;
                BigInteger pow = 1;

                Dictionary<int, char> digits = this.PrepareDigitsDictionary(systemBase);

                for (int i = numeralSystemNumber.Length - 1; i >= 0; i--)
                {
                    char otherDigit = numeralSystemNumber[i];
                    BigInteger digit = (BigInteger)digits.First(x => x.Value == otherDigit).Key;
                    decimalNumber += digit * pow;
                    pow *= systemBase;
                }

                return decimalNumber;
            }

            public string ConvertDecimalToNumeralSystem(BigInteger decimalNumber, int systemBase)
            {
                string otherSystemNumber = string.Empty;
                BigInteger decimalNumberTemp = decimalNumber;
                string symbol;
                StringBuilder stringBuilder = new StringBuilder();

                Dictionary<int, char> digits = this.PrepareDigitsDictionary(systemBase);

                do
                {
                    int digit = (int)(decimalNumberTemp % systemBase);

                    symbol = string.Empty;
                    symbol = digits[digit].ToString();
                    stringBuilder.Insert(0, symbol);

                    decimalNumberTemp /= systemBase;
                }
                while (decimalNumberTemp > 0);

                otherSystemNumber = stringBuilder.ToString();

                return otherSystemNumber;
            }

            private Dictionary<int, char> PrepareDigitsDictionary(int systemBase)
            {
                Dictionary<int, char> digits = new Dictionary<int, char>();

                for (int i = 0; i < systemBase; i++)
                {
                    digits.Add(i, (char)('a' + i));
                }

                return digits;
            }
        }        
    }
}