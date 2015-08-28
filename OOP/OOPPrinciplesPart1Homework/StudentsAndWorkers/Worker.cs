using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers
{
    class Worker : Human
    {
        private const byte MIN_WORK_HOURS_PER_DAY = 1;
        private const byte MAX_WORK_HOURS_PER_DAY = 24;
        private const byte MIN_WORK_DAYS_PER_WEEK = 1;
        private const byte MAX_WORK_DAYS_PER_WEEK = 7;
        
        private decimal weekSalary;
        private byte workHoursPerDay;
        private byte workDaysPerWeek;

        public Worker(string firstName, string lastName)
            : base(firstName, lastName)
        {

        }

        public Worker
            (string firstName, string lastName, decimal weekSalary, byte workHoursPerDay, byte workDaysPerWeek)
            : this(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
            this.WorkDaysPerWeek = workDaysPerWeek;
        }

        public decimal WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("WeekSalary can not be less that zero");
                }

                this.weekSalary = value;
            }
        }

        public byte WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            set
            {
                this.ValidateWorkHoursPerDay(value);

                this.workHoursPerDay = value;
            }
        }

        public byte WorkDaysPerWeek
        {
            get
            {
                return this.workDaysPerWeek;
            }
            set
            {
                this.ValidateWorkDaysPerWeek(value);

                this.workDaysPerWeek = value;
            }
        }

        public decimal GetMoneyPerHour()
        {
            decimal result = this.WeekSalary / (this.WorkHoursPerDay * WorkDaysPerWeek);
            result = Math.Round(result, 2);

            return result;
        }

        public override string ToString()
        {
            string result;
            result = string.Format("{0} - WeekSalary: {1} WorkHoursPerDay: {2} WorkDaysPerWeek: {3}"
                , base.ToString(), this.WeekSalary, this.WorkHoursPerDay, this.WorkDaysPerWeek);
            return result;
        }

        protected void ValidateWorkHoursPerDay(byte value)
        {
            if (value < MIN_WORK_HOURS_PER_DAY || value > MAX_WORK_HOURS_PER_DAY)
            {
                throw new ArgumentException(string.Format("WorkHoursPerDay must be between {0} and {1}"
                    , MIN_WORK_HOURS_PER_DAY, MAX_WORK_HOURS_PER_DAY));
            }
        }

        protected void ValidateWorkDaysPerWeek(byte value)
        {
            if (value < MIN_WORK_DAYS_PER_WEEK || value > MAX_WORK_DAYS_PER_WEEK)
            {
                throw new ArgumentException(string.Format("WorkDaysPerWeek must be between {0} and {1}"
                    , MIN_WORK_DAYS_PER_WEEK, MAX_WORK_DAYS_PER_WEEK));
            }
        }       
    }
}
