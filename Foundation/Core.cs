using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Windsor;
using Foundation.Abstraction.Services;

namespace Foundation
{
    public class Core
    {
        private static Core _instance;
        public static Core Instance
        {
            get { return _instance ?? (_instance = new Core()); }
        }

        public IWindsorContainer Container { get; set; }

        public IMultilingualService Multilingual
        {
            get { return Container.Resolve<IMultilingualService>(); }
        }
    }
}
