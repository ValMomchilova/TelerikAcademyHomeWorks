namespace NumberFormater
{
    using System;

    public class RightAlignFormater : INumberFormater
    {
        private const int DefaultPositionsCount = 8;

        private int totalPostionsCount;

        public RightAlignFormater(int allPostionsCount = DefaultPositionsCount)
        {
            this.TotPostionsCount = allPostionsCount;
        }

        public int TotPostionsCount
        {
            get 
            {
                return this.totalPostionsCount;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("totalPostionsCount have to be positive value");
                }

                this.totalPostionsCount = value;
            }
        }

        public string FormatNumber(object number)
        {
            string numberToString = string.Format("{0}", number);
            string formatedNumber = numberToString.PadLeft(this.TotPostionsCount);

            return formatedNumber;
        }
    }
}
