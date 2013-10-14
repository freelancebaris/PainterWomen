using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Foundation;
using Foundation.Abstraction.Business;
using Foundation.Abstraction.Services;
using Foundation.Model.Layout;

namespace PainterWomen.Presentation.Controllers
{
    public class PublicController: BaseController
    {

        private readonly IMenuBusiness _menuBusiness;
        public PublicController(IMenuBusiness menuBusiness)
        {
            _menuBusiness = menuBusiness;
        }

        public JsonResult GetMenuLinks()
        {
            List<Menu> menuList = _menuBusiness.GetMenuList();
            return Json(new {success = true, menuList = menuList});
        }
    }

    

}
