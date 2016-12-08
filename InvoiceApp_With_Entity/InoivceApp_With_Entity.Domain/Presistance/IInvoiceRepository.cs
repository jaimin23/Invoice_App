using InoivceApp_With_Entity.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InoivceApp_With_Entity.Domain.Presistance
{
    public interface IInvoiceRepository
    {
        IEnumerable<Invoice> Invoices { get; }

        void SaveInvoice(Invoice invoice);
    }
}
