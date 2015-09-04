namespace InvoiceTools
{
    public interface IInvoiceData
    {
        string Sender { get; set; }

        string Recepient { get; set; }

        int InvoiceNumber { get; set; }

        decimal Total { get; set; }
    }
}
