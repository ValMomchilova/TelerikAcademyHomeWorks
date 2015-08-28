using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create a class  Call  to hold a call performed through a GSM.
//• It should contain date, time, dialled phone number and duration (in seconds).

namespace GSMDevices
{
    public class Call
    {
        private DateTime callDateTime;
        private string phoneNumber;
        private long duration;

        public Call(string phoneNumber)
        {
            this.CallDateTime = DateTime.Now;
            this.PhoneNumber = phoneNumber;
        }

        public Call(string phoneNumber, long duration)
            : this(phoneNumber)
        {
            this.Duration = duration;
        }

        public DateTime CallDateTime
        {
            get
            {
                return this.callDateTime;
            }
            private set
            {

                this.callDateTime = value;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return this.phoneNumber;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Phone number cannot be Null or empty.");
                }

                string trimmedValue = value.Trim();

                if (!ValidatePhoneNumber(trimmedValue))
                {
                    throw new ArgumentException("Phone number format is not valid.");
                }

                this.phoneNumber = trimmedValue;
            }
        }

        public long Duration
        {
            get
            {
                return this.duration;
            }
            private set
            {

                this.duration = value;
            }
        }

        public override string ToString()
        {
            string result = string.Format("Call date and time: {0} \nPhone number: {1} \nDuration: {2}",
                                            this.CallDateTime, this.PhoneNumber, this.Duration);

            return result;
        }

        private bool ValidatePhoneNumber(string value)
        {
            bool result = true;

            if (value.Length < 3)
            {
                result = false;
            }
            else if (value[0] != '+' && !char.IsDigit(value[0]))
            {
                result = false;
            }
            else
            {
                for (int i = 1; i < value.Length; i++)
                {
                    if (!char.IsDigit(value[i]))
                    {
                        result = false;
                    }
                }
            }

            return result;
        }
    }
}
