using InoivceApp_With_Entity.Domain.Entities;
using InoivceApp_With_Entity.Domain.Presistance;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InoivceApp_With_Entity.Domain
{
    public class DomainFactoryModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IPreloadedInvoices>().To<PreloadedInvoices>();
            Bind<IPreloadedUsers>().To<PreloadedUsers>();
            Bind<IInvoiceRepository>().To<DatabaseInvoiceRepository>();
            Bind<IUserRepository>().To<DatabaseUserRepository>();

        }
    }
}
