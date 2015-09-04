namespace InvoiceTools
{
    public class InvloiceContentsOnly : Invoice 
    {
        protected override void PrepareContent()
        {
            this.Content.AppendLine(this.Data.Recepient);
            this.Content.Append(this.Data.InvoiceNumber.ToString());
            this.Content.AppendLine(this.Data.Sender);
            this.Content.AppendLine(this.Data.Total.ToString());
        }
    }
}
