using InoivceApp_With_Entity.Domain;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InvoiceApp_With_Entity.App_Start
{
    public class WebAppDependencyResolver : IDependencyResolver
    {
        private IKernel _diKernel;
        public WebAppDependencyResolver(IKernel diKernel)
        {
            _diKernel = diKernel;
            AddBindings();
        }
        public void AddBindings()
        {
            _diKernel.Load(new DomainFactoryModule());
        }
        public object GetService(Type serviceType)
        {
            return _diKernel.TryGet(serviceType);
        }
        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _diKernel.GetAll(serviceType);
        }
    }
}