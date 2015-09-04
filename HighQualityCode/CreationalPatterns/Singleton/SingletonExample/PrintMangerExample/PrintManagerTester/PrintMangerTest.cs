namespace PrintManagerTester
{
    using System.Text;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using PrintTools;   

    [TestClass]
    public class PrintMangerTest
    {
        [TestMethod]
        public void TestPrint()
        {
            PrintManager printManger = PrintManager.Instance;
            MemoryPrinter memoryPrinter = new MemoryPrinter();
            printManger.Printer = memoryPrinter;
            StringBuilder sb = new StringBuilder();

            string print1 = "test1";
            printManger.Print(print1);
            sb.AppendLine(print1);

            PrintManager printManger2 = PrintManager.Instance;

            string print2 = "test2";
            printManger2.Print(print2);
            sb.AppendLine(print2);

            string resultFromPrinter = memoryPrinter.ToString();
            string expectedResult = sb.ToString();
            Assert.AreEqual(resultFromPrinter, expectedResult, "The printerstore content is not the expeccted");            
        }
    }
}
