using InoivceApp_With_Entity.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InoivceApp_With_Entity.Domain.Presistance
{
    class InvoiceDbContext : DbContext
    {
        public InvoiceDbContext() : base("InvoiceDbConnection") { }

        public DbSet<Invoice> Invoices { get; set; }

        public DbSet<User> Users { get; set; }
    }
}
