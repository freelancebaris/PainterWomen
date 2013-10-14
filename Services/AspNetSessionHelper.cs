using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Foundation;
using Foundation.Abstraction.Services;
using Foundation.Model.SessionHelper;

namespace Services
{
   public class AspNetSessionHelper : ISessionHelper
    {
        public TObjectType Get<TObjectType>(string key)
        {
            return (TObjectType)HttpContext.Current.Session[key];
        }

        public void Set(string key, object value)
        {
            HttpContext.Current.Session[key] = value;
        }

       public UserContext UserContext
       {

           get
           {
               var userContext = Get<UserContext>(Strings.Session.UserContext) ?? new UserContext();
               return userContext;
           }
           set { Set(Strings.Session.UserContext, value); }
       }
    }
}
