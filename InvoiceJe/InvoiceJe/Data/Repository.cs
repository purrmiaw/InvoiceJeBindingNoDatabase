using InvoiceJe.Models;
using System;
using System.Collections.Generic;

namespace InvoiceJe.Data
{
    public class Repository
    {
       
        public IEnumerable<Invoice> GetInvoices()
        {
            var invoices = new List<Invoice>();
            invoices.Add(new Invoice { Id = 1, ReferenceNumber = "001", Amount = 20.12M, BillTo="ABC Sdn Bhd" });
            invoices.Add(new Invoice { Id = 2, ReferenceNumber = "002", Amount = 32.56M, BillTo = "Ahmad and Friends" });
            invoices.Add(new Invoice { Id = 3, ReferenceNumber = "003", Amount = 45.12M, BillTo = "Reddit pvt ltd" });
            invoices.Add(new Invoice { Id = 4, ReferenceNumber = "004", Amount = 27.00M, BillTo = "Google ltd" });
            invoices.Add(new Invoice { Id = 5, ReferenceNumber = "005", Amount = 16.00M, BillTo = "Microsoft ltd" });
            invoices.Add(new Invoice { Id = 6, ReferenceNumber = "006", Amount = 87.00M, BillTo = "Dave Games" });
            invoices.Add(new Invoice { Id = 7, ReferenceNumber = "007", Amount = 4.32M, BillTo = "Authentic Venture Sdn Bhd" });
            invoices.Add(new Invoice { Id = 8, ReferenceNumber = "008", Amount = 20.12M, BillTo = "Nancy" });
            invoices.Add(new Invoice { Id = 9, ReferenceNumber = "009", Amount = 17.00M, BillTo = "Archer" });
            invoices.Add(new Invoice { Id = 10, ReferenceNumber = "010", Amount = 46.85M, BillTo = "Hatsune Miku" });
            invoices.Add(new Invoice { Id = 11, ReferenceNumber = "011", Amount = 95.45M, BillTo = "Game of Thrones pvt ltd" });
            invoices.Add(new Invoice { Id = 12, ReferenceNumber = "012", Amount = 100.2M, BillTo = "Sunsuria Apts ltd" });
            invoices.Add(new Invoice { Id = 13, ReferenceNumber = "013", Amount = 520.7M, BillTo = "Miaw.xyz" });
            invoices.Add(new Invoice { Id = 14, ReferenceNumber = "014", Amount = 1.12M, BillTo = "Authentic Venture Sdn Bhd" });
            invoices.Add(new Invoice { Id = 15, ReferenceNumber = "015", Amount = 50.00M, BillTo = "Acer Sdn Bhd" });
            invoices.Add(new Invoice { Id = 16, ReferenceNumber = "016", Amount = 100.0M, BillTo = "Oppo Sdn Bhd" });
            invoices.Add(new Invoice { Id = 17, ReferenceNumber = "017", Amount = 145.1M, BillTo = "FL Studio" });
            invoices.Add(new Invoice { Id = 18, ReferenceNumber = "018", Amount = 205.8M, BillTo = "Unity3D" });
            invoices.Add(new Invoice { Id = 19, ReferenceNumber = "019", Amount = 785.6M, BillTo = "Goal" });
            invoices.Add(new Invoice { Id = 20, ReferenceNumber = "020", Amount = 15.03M, BillTo = "Google ltd" });

            return invoices;
        }
    }
}
