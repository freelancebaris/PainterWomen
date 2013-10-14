using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Foundation.Model.Layout;

namespace Foundation.Abstraction.Business
{
    public interface IMenuBusiness
    {
        List<Menu> GetMenuList();
    }
}
