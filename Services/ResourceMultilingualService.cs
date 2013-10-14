using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Foundation.Abstraction.Services;

namespace Services
{
    public class ResourceMultilingualService : IMultilingualService
    {
        private readonly ISessionHelper _sessionHelper;
        public ResourceMultilingualService(ISessionHelper sessionHelper)
        {
            _sessionHelper = sessionHelper;
        }

        public string GetValue(string key)
        {
            return Localization.Lang.ResourceManager.GetString(key, _sessionHelper.UserContext.CultureInfo);
        }

        public string GetValue(string key, string defaultValue)
        {
            try
            {
                return GetValue(key);
            }
            catch (Exception)
            {
                return defaultValue;
            }
        }
    }
}
