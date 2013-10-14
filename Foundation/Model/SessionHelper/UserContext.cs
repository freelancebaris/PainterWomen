using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation.Model.SessionHelper
{
    public class UserContext
    {
        public Enums.Language SelectedLanguage { get; set; }
        public CultureInfo CultureInfo { get; set; }
    }
}
