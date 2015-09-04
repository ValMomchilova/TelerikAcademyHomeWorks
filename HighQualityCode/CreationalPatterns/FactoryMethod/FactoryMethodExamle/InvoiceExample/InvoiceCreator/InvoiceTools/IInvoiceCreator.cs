namespace InvoiceTools
{
    public interface IInvoiceCreator
    {
        Invoice CreateInvoice(IInvoiceData invoiceData);
    }
}
