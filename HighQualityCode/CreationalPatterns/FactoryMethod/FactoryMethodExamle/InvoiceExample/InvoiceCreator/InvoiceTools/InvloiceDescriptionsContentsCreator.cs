namespace InvoiceTools
{
    public class InvloiceDescriptionsContentsCreator : IInvoiceCreator
    {
        public Invoice CreateInvoice(IInvoiceData invoiceData)
        {
            return new InvloiceDescriptionsContents();
        }
    }
}
