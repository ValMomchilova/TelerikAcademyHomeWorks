namespace NumberToDigitFormater
{
    using System;

    public class NumberToDigitFormater 
    {
        public string NumberToDigit(int number)
        {
            if (number < 0 || number > 9)
            {
                throw new ArgumentOutOfRangeException("Number must be between 0 and 9");
            }

            string digit = string.Empty;

            switch (number)
            {
                case 0:
                    digit = "zero";
                    break;
                case 1: 
                    digit = "one";
                    break;
                case 2:
                    digit = "two";
                    break;
                case 3: 
                    digit = "three";
                    break;
                case 4: 
                    digit = "four";
                    break;
                case 5: 
                    digit = "five";
                    break;
                case 6: 
                    digit = "six";
                    break;
                case 7: 
                    digit = "seven";
                    break;
                case 8: 
                    digit = "eight";
                    break;
                case 9: 
                    digit = "nine";
                    break;
            }

            return digit;
        }
    }
}
