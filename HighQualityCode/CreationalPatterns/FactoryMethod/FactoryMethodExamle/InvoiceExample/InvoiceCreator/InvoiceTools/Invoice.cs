namespace InvoiceTools
{
    using System.Text;

    public abstract class Invoice
    {
        public IInvoiceData Data { get; set; }

        protected StringBuilder Content { get; set; }

        public override string ToString()
        {
            return this.Content.ToString();
        }

        protected abstract void PrepareContent();
    }
}
