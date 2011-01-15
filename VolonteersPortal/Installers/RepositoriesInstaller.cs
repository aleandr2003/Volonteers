using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Castle.MicroKernel.SubSystems.Configuration;
using Models.Abstract;
using Models.Repositories;

namespace VolonteersPortal.Installers
{
    public class RepositoriesInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
          //container.Register(AllTypes.FromAssemblyNamed("Model")
          //                      .Where(type => type.Name.EndsWith("Repository"))
          //                      .WithService.DefaultInterface()
          //                      .Configure(c => c.LifeStyle.PerWebRequest));
          container.Register(Component.For<IProjectRepository>().ImplementedBy<ProjectRepository>());
          container.Register(Component.For<IPersonRepository>().ImplementedBy<PersonRepository>());
        }
    }
}
