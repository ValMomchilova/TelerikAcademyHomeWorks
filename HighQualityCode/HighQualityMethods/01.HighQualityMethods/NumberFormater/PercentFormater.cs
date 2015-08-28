namespace NumberFormater
{
    using System;

    public class PercentFormater : INumberFormater 
    {
        public string FormatNumber(object number)
        {
            string formatedNumber = string.Format("{0:p0}", number);

            return formatedNumber;
        }
    }
}
