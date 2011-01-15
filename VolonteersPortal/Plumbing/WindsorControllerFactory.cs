using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Castle.MicroKernel;
using System.Web.Mvc;
using System.Web.Routing;

namespace VolonteersPortal.Plumbing
{
    public class WindsorControllerFactory : DefaultControllerFactory
    {
        private readonly IKernel kernel;
        public WindsorControllerFactory(IKernel kernel)
        {
            this.kernel = kernel;
        }
        public override void ReleaseController(IController controller)
        {
            kernel.ReleaseComponent(controller);
        }
        public override IController CreateController(RequestContext requestContext, string controllerName)
        {
            var controllerComponentName = controllerName + "controller";
            return kernel.Resolve<IController>(controllerComponentName);
        }
    }
}
