namespace InvoiceTools
{
    public class InvoiceData : IInvoiceData 
    {
        private string sender;
        private string recepient;
        private int invoiceNumber;
        private decimal total;
               
        public string Sender
        {
            get
            {
                return this.sender;
            }

            set
            {
                this.sender = value;
            }
        }

        public string Recepient
        {
            get
            {
                return this.recepient;
            }

            set
            {
                this.recepient = value;
            }
        }

        public int InvoiceNumber
        {
            get
            {
                return this.invoiceNumber;
            }

            set
            {
                this.invoiceNumber = value;
            }
        }

        public decimal Total
        {
            get
            {
                return this.total;
            }

            set
            {
                this.total = value;
            }
        }
    }
}
