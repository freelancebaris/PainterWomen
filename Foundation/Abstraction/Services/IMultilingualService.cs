using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation.Abstraction.Services
{
    public interface IMultilingualService
    {
        string GetValue(string key);
        string GetValue(string key, string defaultValue);
    }
}
