using System.Web.Mvc;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Foundation;

namespace PainterWomen.Presentation.Modules
{
    public class ControllerInstaller: IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            Core.Instance.Container = container;
            container.Register(Classes.FromThisAssembly()
                               .BasedOn<IController>()
                               .LifestyleTransient());
        }
    }
}