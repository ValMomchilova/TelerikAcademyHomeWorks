namespace InvoiceTools
{
    public class InvloiceContentsOnlyCreator : IInvoiceCreator 
    {
        public Invoice CreateInvoice(IInvoiceData invoiceData)
        {
            return new InvloiceContentsOnly();
        }
    }
}
