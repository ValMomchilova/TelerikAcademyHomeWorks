using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangeExceptions
{
    public class Period
    {
        public Period(DateTime startDateTime, DateTime endDateTime)
        {
            this.StartDateTime = startDateTime;
            this.EndDateTime = endDateTime;
        }

        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
    }
}
