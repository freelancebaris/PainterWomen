using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdminKP.Module
{
    using Business.AdminKP;

    using Castle.MicroKernel.Registration;
    using Castle.MicroKernel.SubSystems.Configuration;
    using Castle.Windsor;

    using Foundation.Abstraction.Business.AdminKP;

    public class AdminModule : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For(typeof(IAdminAboutBusiness), typeof(AdminAboutBusiness)));
        }
    }
}