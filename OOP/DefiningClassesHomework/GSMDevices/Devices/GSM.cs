using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSMDevices
{
    public class GSM
    {
        //model, manufacturer, price, owner, battery characteristics (model, hours idle and hours talk) and display characteristics (size and number of colors).
        //Assume that model and manufacturer are mandatory (the others are optional).
        //All unknown data fill with null. (developer note: So nullable types are used)

        private static GSM iPhone4S = new GSM("iPhone 4S", "Apple", 500M,
            new Battery(BatteryTypes.LiIon, 200, 9), new Display(3.5, 16 * 1024));
        private string model;
        private string manufacturer;
        private decimal? price;
        private Battery battery;
        private Display display;
        private List<Call> callHistory;

        public GSM(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.CallHistory = new List<Call>();
        }

        public GSM(string model, string manufacturer, decimal? price)
            : this(model, manufacturer)
        {
            this.Price = price;
        }

        public GSM(string model, string manufacturer, decimal? price, Battery battery, Display display)
            : this(model, manufacturer, price)
        {
            this.Battery = battery;
            this.Display = display;
        }

        public static GSM IPhone4S
        {
            get
            {
                return iPhone4S;
            }
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

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Manufacturer cannot be Null or empty.");
                }
                this.manufacturer = value;
            }
        }

        public decimal? Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value != null && value < 0)
                {
                    throw new ArgumentException("Price cannot be less to zero.");
                }
                this.price = value;
            }
        }

        public Battery Battery
        {
            get
            {
                return this.battery;
            }
            set
            {
                this.battery = value;
            }
        }

        //public Display Display
        //{
        //    get
        //    {
        //        return this.display;
        //    }
        //    set
        //    {
        //        this.display = value;
        //    }
        //}

        public List<Call> CallHistory
        {
            get
            {
                return this.callHistory;
            }
            private set
            {
                this.callHistory = value;
            }
        }

        public Call Call
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Display Display
        {
            get
            {
                return this.display;
            }
            set
            {
                this.display = value;
            }
        }

        

       

        public override string ToString()
        {
            string result = string.Format("Model: {0} \nManufacturer: {1} \nPrice: {2:C} \n{3}\n{4}",
                                            this.Model, this.Manufacturer, this.Price, this.Battery, this.Display);

            return result;
        }

        public void AddCall(Call call)
        {
            this.CallHistory.Add(call);
        }

        public void DeleteCall(Call call)
        {
            this.CallHistory.Remove(call);
        }

        public void DeleteCall(int callIndex)
        {
            this.CallHistory.RemoveAt(callIndex);
        }

        public void ClearCallHistory()
        {
            this.CallHistory.Clear();
        }

        public decimal CalculateCallHistoryPrice(decimal pricePerMinute)
        {
            decimal result = 0;

            for (int i = 0; i < CallHistory.Count; i++)
            {
                decimal currentPrice = CallHistory[i].Duration / 60M * pricePerMinute;
                result += currentPrice;
            }

            return result;
        }

        public string CallHistoryToString()
        {
            string result = string.Empty;
            StringBuilder sb = new StringBuilder();

            if (this.callHistory.Count == 0)
            {
                result = "Call history is empty";
            }
            else
            {
                for (int i = 0; i < this.CallHistory.Count; i++)
                {
                    sb.Append(this.CallHistory[i].ToString());
                    if (i < this.CallHistory.Count - 1)
                    {
                        sb.Append('\n');
                    }
                }

                result = sb.ToString();
            }

            return result;
        }
    }
}
