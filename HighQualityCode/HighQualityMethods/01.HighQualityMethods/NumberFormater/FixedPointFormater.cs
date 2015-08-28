namespace NumberFormater
{
    using System;

    public class FixedPointFormater : INumberFormater 
    {
        public string FormatNumber(object number)
        {
            string formatedNumber = string.Format("{0:f2}", number);

            return formatedNumber;
        }
    }
}
