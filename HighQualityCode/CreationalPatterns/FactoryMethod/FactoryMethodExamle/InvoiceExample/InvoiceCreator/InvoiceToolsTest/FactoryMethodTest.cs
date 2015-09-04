namespace InvoiceToolsTest
{
    using System;
    using System.Collections.Generic;
    using InvoiceTools;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class FactoryMethodTest
    {
        [TestMethod]
        public void TestFactory()
        {
            IInvoiceData data = new InvoiceData();
            data.InvoiceNumber = 1;
            data.Recepient = "Irina OOD";
            data.Sender = "Info OOD";
            data.Total = 200;

            IInvoiceCreator[] invoiceCreators = new IInvoiceCreator[2];
            invoiceCreators[0] = new InvloiceContentsOnlyCreator();
            invoiceCreators[1] = new InvloiceDescriptionsContentsCreator();          

            List<Invoice> invoices = new List<Invoice>();

            invoices.Add(invoiceCreators[0].CreateInvoice(data));
            invoices.Add(invoiceCreators[1].CreateInvoice(data));

            Type invoiceType0 = invoices[0].GetType();
            Type expectedType0 = typeof(InvloiceContentsOnly);

            Assert.AreEqual(
                invoiceType0,
                expectedType0,
                "InvloiceContentsOnlyCreator does not create InvloiceContentsOnly in Factory test");

            Type invoiceType1 = invoices[1].GetType();
            Type expectedType1 = typeof(InvloiceDescriptionsContents);

            Assert.AreEqual(
                invoiceType0,
                expectedType0,
                "InvloiceContentsOnlyCreator does not create InvloiceContentsOnly in Factory test");
        }
    }
}
