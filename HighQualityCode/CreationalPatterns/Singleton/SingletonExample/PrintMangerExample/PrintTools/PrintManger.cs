namespace PrintTools
{
    public sealed class PrintManager
    {
        private static readonly object Padlock = new object();

        private static PrintManager instance = null;        

        private IPrinter printer;

        private PrintManager()
        {
        }

        public static PrintManager Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (Padlock)
                    {
                        if (instance == null)
                        {
                            instance = new PrintManager();
                        }                       
                    }
                }

                return instance;
            }
        }

        public IPrinter Printer
        {
            get 
            {
                return this.printer;
            }

            set
            {
                this.printer = value;
            }
        }

        public void Print(object printableObject)
        {
            this.Printer.Print(printableObject);
        }
    }
}
