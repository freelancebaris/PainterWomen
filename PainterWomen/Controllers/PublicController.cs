using System.Collections.Generic;
using System.Web.Mvc;
using Castle.Components.DictionaryAdapter;
using Foundation.Abstraction.Business;
using Foundation.Model.Layout;
using Foundation.Model.Workshop;

namespace PainterWomen.Presentation.Controllers
{
    public class PublicController: BaseController
    {

        private readonly IMenuBusiness _menuBusiness;
        private readonly IWorkshopBusiness _workshopBusiness;
        public PublicController(IMenuBusiness menuBusiness, IWorkshopBusiness workshopBusiness)
        {
            _menuBusiness = menuBusiness;
            _workshopBusiness = workshopBusiness;
        }

        public JsonResult GetMenuLinks()
        {
            List<Menu> menuList = _menuBusiness.GetMenuList();
            return Json(new {success = true, menuList = menuList});
        }

        public JsonResult GetWorkshops()
        {

            List<WorkshopItem> workShops = _workshopBusiness.GetTop5Workshops();
            
            return Json(new {success = true, workshops = workShops});

        }
    }

    

}
