using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Foundation;
using Foundation.Abstraction.Services;
using Foundation.Model.Layout;

namespace PainterWomen.Presentation.Controllers
{
    public class PublicController: BaseController
    {
        private readonly ISessionHelper _sessionHelper;
        public PublicController(ISessionHelper sessionHelper)
        {
            _sessionHelper = sessionHelper;
        }

        public JsonResult GetMenuLinks()
        {
            var menuList = new List<Menu>();
            if (_sessionHelper.UserContext.SelectedLanguage == Enums.Language.Tr)
            {
                menuList.Add(new Menu() { LinkTo = "", LinkText = "Anasayfa", ClassName = "li-none" });
                menuList.Add(new Menu() { LinkTo = "", LinkText = "Hakkımda", ClassName = "" });
                menuList.Add(new Menu() { LinkTo = "", LinkText = "Blog", ClassName = "" });
                menuList.Add(new Menu() { LinkTo = "", LinkText = "Galeri", ClassName = "li-left li-none" });
                menuList.Add(new Menu() { LinkTo = "", LinkText = "Hayattan", ClassName = "" });
                menuList.Add(new Menu() { LinkTo = "", LinkText = "İletişim", ClassName = "" });
            } else if (_sessionHelper.UserContext.SelectedLanguage == Enums.Language.En)
            {
                menuList.Add(new Menu() { LinkTo = "", LinkText = "Home", ClassName = "li-none" });
                menuList.Add(new Menu() { LinkTo = "", LinkText = "About Me", ClassName = "" });
                menuList.Add(new Menu() { LinkTo = "", LinkText = "Blog", ClassName = "" });
                menuList.Add(new Menu() { LinkTo = "", LinkText = "Gallery", ClassName = "li-left li-none" });
                menuList.Add(new Menu() { LinkTo = "", LinkText = "In Life", ClassName = "" });
                menuList.Add(new Menu() { LinkTo = "", LinkText = "Contact", ClassName = "" });
            }

            return Json(new {success = true, menuList = menuList});
        }
    }

    

}
