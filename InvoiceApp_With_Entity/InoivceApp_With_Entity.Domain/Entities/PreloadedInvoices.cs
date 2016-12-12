using InoivceApp_With_Entity.Domain.Presistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InoivceApp_With_Entity.Domain.Entities
{
    class PreloadedInvoices : IPreloadedInvoices
    {
        private IInvoiceRepository _repository;

        public IEnumerable<Invoice> InvoiceList { get; }

        public PreloadedInvoices(IInvoiceRepository repository)
        {
            _repository = repository;
            this.InvoiceList = _repository.Invoices;
        }
        /// <summary>
        /// This method is resposible for saving/updating the invoice in the table
        /// </summary>
        /// <param name="invoice"></param>
        public void SaveInvoice(Invoice invoice)
        {
            _repository.SaveInvoice(invoice);
        }
    }
}
