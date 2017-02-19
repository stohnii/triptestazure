using Ninject;
using System;
using System.Web.Mvc;
using System.Web.Routing;
using TripTest.Bal;
using TripTest.Bal.Arstract;
using TripTest.Dal;
using TripTest.Dal.Abstract;

namespace TripTest.Web.Infrastructure
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private readonly IKernel _kernel;

        public NinjectControllerFactory()
        {
            _kernel = new StandardKernel();
            AddBindings();
        }

        protected override IController GetControllerInstance(RequestContext context, Type controllerType)
        {
            return controllerType == null ? null : (IController)_kernel.Get(controllerType);
        }

        private void AddBindings()
        {
            _kernel.Bind<ITripManager>().To<TripManager>();
            _kernel.Bind<ITripRepository>().To<TripRepository>(); 
        }
    }
}