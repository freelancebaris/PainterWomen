using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Foundation.Model.SessionHelper;

namespace Foundation.Abstraction.Services
{
    public interface ISessionHelper
    {
        UserContext UserContext { get; set; }
    }
}
