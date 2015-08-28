using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GSMDevices
{
    public class Battery
    {
        //model, hours idle and hours talk
        //All unknown data fill with null. (developer note: So nullable types are used)

        private string model;
        private double? hoursIdle;
        private double? hoursTalk;

        public Battery(BatteryTypes batteryType)
        {
            this.BatteryType = batteryType;
        }

        public Battery(BatteryTypes batteryType, double? hoursIdle, double? hoursTalk)
            : this(batteryType)
        {
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
        }

        public Battery(string model, BatteryTypes batteryType, double? hoursIdle, double? hoursTalk)
            : this(batteryType, hoursIdle, hoursTalk)
        {
            this.Model = model;
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Model cannot be Null or empty.");
                }
                this.model = value;
            }
        }

        public double? HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }
            set
            {
                if (value != null && value <= 0)
                {
                    throw new ArgumentException("Hours idle cannot be less or equal to zero.");
                }
                this.hoursIdle = value;
            }
        }

        public double? HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            set
            {
                if (value != null && value <= 0)
                {
                    throw new ArgumentException("Hours idle cannot be less or equal to zero.");
                }
                this.hoursTalk = value;
            }
        }

        public BatteryTypes BatteryType { get; set; }

        public override string ToString()
        {
            string result = string.Format("Battery information: \n  Model: {0} \n  Battery type: {1} \n  Hours idle: {2} hours \n  Hours talk: {3} hours",
                                            this.Model, this.BatteryType.DescriptionToString(), this.HoursIdle, this.HoursTalk);

            return result;
        }
    }
}
