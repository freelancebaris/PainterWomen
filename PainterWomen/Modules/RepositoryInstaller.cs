﻿using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Foundation.Abstraction.Repository;
using Repository;

namespace PainterWomen.Presentation.Modules
{
    public class RepositoryInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For(typeof(IBlogRepository), typeof(BlogRepository)));
            container.Register(Component.For(typeof(IGalleryRepository), typeof(GalleryRepository)));
            container.Register(Component.For(typeof(IAboutRepository), typeof(AboutRepository)));
            container.Register(Component.For(typeof(IGaleryRepository), typeof(GaleryRepository)));
            container.Register(Component.For(typeof(IWorkshopRepository), typeof(WorkshopRepository)));
        }
    }
}