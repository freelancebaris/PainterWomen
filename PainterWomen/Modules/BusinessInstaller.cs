﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Business;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Foundation.Business;

namespace PainterWomen.Presentation.Modules
{
    using Foundation.Abstraction.Business;

    public class BusinessInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For(typeof(IDenemeBusiness), typeof(DenemeBusiness)));
            container.Register(Component.For(typeof(IBlogBusiness), typeof(BlogBusiness)));
        }
    }
}