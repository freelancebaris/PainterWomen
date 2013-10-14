using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Foundation.Abstraction.Services;
using Services;

namespace PainterWomen.Presentation.Modules
{
    public class ServiceInstaller: IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For(typeof(ISessionHelper), typeof(AspNetSessionHelper)));
            container.Register(Component.For(typeof(IMultilingualService), typeof(ResourceMultilingualService)));
        }
    }
}