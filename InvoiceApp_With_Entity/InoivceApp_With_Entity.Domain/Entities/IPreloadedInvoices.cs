using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InoivceApp_With_Entity.Domain.Entities
{
    public interface IPreloadedInvoices
    {
        IEnumerable<Invoice> InvoiceList { get; }

        void SaveInvoice(Invoice invoice);
    }
}
