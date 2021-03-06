﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Foundation;
using Foundation.Abstraction.Business;
using Foundation.Abstraction.Services;
using Foundation.Model.Layout;

namespace Business
{
    public class MenuBusiness:IMenuBusiness
    {
        private readonly ISessionHelper _sessionHelper;
        public MenuBusiness(ISessionHelper sessionHelper)
        {
            _sessionHelper = sessionHelper;
        }

        public List<Menu> GetMenuList()
        {
            var menuList = new List<Menu>();
            if (_sessionHelper.UserContext.SelectedLanguage == Enums.Language.Tr)
            {
                menuList.Add(new Menu() { LinkTo = "/tr/Home/", LinkText = "Anasayfa", ClassName = "li-none" });
                menuList.Add(new Menu() { LinkTo = "/tr/About", LinkText = "Hakkımda", ClassName = "" });
                menuList.Add(new Menu() { LinkTo = "/tr/Blog", LinkText = "Blog", ClassName = "" });
                menuList.Add(new Menu() { LinkTo = "/tr/Gallery/Detail", LinkText = "Galeri", ClassName = "li-left li-none" });
                //menuList.Add(new Menu() { LinkTo = "", LinkText = "Hayattan", ClassName = "" });
                menuList.Add(new Menu() { LinkTo = "/tr/Contact", LinkText = "İletişim", ClassName = "" });
            }
            else if (_sessionHelper.UserContext.SelectedLanguage == Enums.Language.En)
            {
                menuList.Add(new Menu() { LinkTo = "/tr/Home", LinkText = "Home", ClassName = "li-none" });
                menuList.Add(new Menu() { LinkTo = "/tr/About", LinkText = "About Me", ClassName = "" });
                menuList.Add(new Menu() { LinkTo = "/tr/Blog", LinkText = "Blog", ClassName = "" });
                menuList.Add(new Menu() { LinkTo = "", LinkText = "Gallery", ClassName = "li-left li-none" });
                //menuList.Add(new Menu() { LinkTo = "", LinkText = "In Life", ClassName = "" });
                menuList.Add(new Menu() { LinkTo = "/tr/Contact", LinkText = "Contact", ClassName = "" });
            }
            return menuList;
        }
    }
}
