using InoivceApp_With_Entity.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InoivceApp_With_Entity.Domain.Presistance
{
    class DatabaseInvoiceRepository : IInvoiceRepository
    {
        private InvoiceDbContext _dbContext;

        public DatabaseInvoiceRepository()
        {
            _dbContext = new InvoiceDbContext();
        }

        public IEnumerable<Invoice> Invoices
        {
            get
            {
                return _dbContext.Invoices;
            }
        }

        public void SaveInvoice(Invoice invoice)
        {
            if(invoice.InvoiceNumber == 0)
            {
                _dbContext.Invoices.Add(invoice);
            }
            else
            {
                Invoice invoiceEntity = _dbContext.Invoices.Find(invoice.InvoiceNumber);
                invoiceEntity.Change(invoice);
            }

            _dbContext.SaveChanges();
        }
    }
}
