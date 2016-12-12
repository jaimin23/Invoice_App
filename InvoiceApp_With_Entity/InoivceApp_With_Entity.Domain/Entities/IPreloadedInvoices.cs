using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InoivceApp_With_Entity.Domain.Entities
{
    /// <summary>
    /// This interface is responsible for loading up the Invoice list and also has the method
    /// which saves/updates the invoices
    /// </summary>
    public interface IPreloadedInvoices
    {
        IEnumerable<Invoice> InvoiceList { get; }
        /// <summary>
        /// This method is resposible for saving/updating the invoice in the table
        /// </summary>
        /// <param name="invoice"></param>
        void SaveInvoice(Invoice invoice);
    }
}
