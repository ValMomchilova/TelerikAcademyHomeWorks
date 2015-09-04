namespace InvoiceTools
{
    using System;

    public class InvloiceDescriptionsContents : Invoice
    {
        protected override void PrepareContent()
        {
            this.Content.Append(this.Data.InvoiceNumber.ToString());
            this.Content.AppendLine(string.Format("Recepient: {0}", this.Data.Recepient));
            this.Content.AppendLine(string.Format("Sender: {0}", this.Data.Sender));
            this.Content.AppendLine(string.Format("Sender: {0}", this.Data.Total.ToString()));
        }
    }
}
