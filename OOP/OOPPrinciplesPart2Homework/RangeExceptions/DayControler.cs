using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangeExceptions
{
    class DayControler
    {
        public DayControler(Period examPreparationPeriod, int maxBeersCount)
        {
            this.ExamPreparationPeriod = examPreparationPeriod;
            this.MaxBeersCount = maxBeersCount;
        }
        
        public Period ExamPreparationPeriod { get; set; }

        public int MaxBeersCount { get; set; }

        public bool PermitGoOut(DateTime dateTime)
        {
            if (dateTime >= ExamPreparationPeriod.StartDateTime && dateTime <= ExamPreparationPeriod.EndDateTime)
            {
                throw new InvalidRangeException<DateTime>("Can not go out! It is time for exam preparation!",
                    ExamPreparationPeriod.StartDateTime, ExamPreparationPeriod.EndDateTime);
            }

            return true;
        }

        public bool PermitDrinkBeers(int beersCount)
        {
            if (beersCount > MaxBeersCount || beersCount < 0)
            {
                throw new InvalidRangeException<int>("Beer count is out of range!",
                    0, MaxBeersCount);
            }

            return true;
        }
    }
}
