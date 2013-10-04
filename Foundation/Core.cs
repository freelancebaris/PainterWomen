using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Windsor;

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
    }
}
