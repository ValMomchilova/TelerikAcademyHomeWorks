namespace PrintTools
{
    using System.Text;

    public class MemoryPrinter : IPrinter   
    {
        private StringBuilder printStore;

        public MemoryPrinter()
        {
            this.printStore = new StringBuilder();
        }
      
        public void Print(object printableObject)
        {
            this.printStore.AppendLine(printableObject.ToString());
        }

        public override string ToString()
        {
            return this.printStore.ToString();
        }
    }
}
