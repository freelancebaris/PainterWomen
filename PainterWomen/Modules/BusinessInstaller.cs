using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Business;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Foundation.Abstraction.Services;
using Foundation.Business;
using Services;

namespace PainterWomen.Presentation.Modules
{
    using Foundation.Abstraction.Business;

    public class BusinessInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For(typeof(IDenemeBusiness), typeof(DenemeBusiness)));
            container.Register(Component.For(typeof(IBlogBusiness), typeof(BlogBusiness)));
            container.Register(Component.For(typeof(IMenuBusiness), typeof(MenuBusiness)));
            container.Register(Component.For(typeof(IGalleryBusiness), typeof(GalleryBusiness)));
            container.Register(Component.For(typeof(IAboutBusiness), typeof(AboutBusiness)));
            container.Register(Component.For(typeof(IGaleryBusiness), typeof(GaleryBusiness)));
            container.Register(Component.For(typeof(IWorkshopBusiness), typeof(WorkshopBusiness)));
        }
    }
}