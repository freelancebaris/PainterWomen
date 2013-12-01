using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation
{
    public class Strings
    {
        public struct Connection
        {
            public const string ConnectionString = "Data Source=.;Initial Catalog=PainterWoman;Integrated Security=SSPI";
        }
        public struct Session
        {
            public const string UserContext = "UserContext";
        }

        public struct Multilingual
        {
            public struct Home
            {
                public const string Workshop = "Home_Workshop";
                public const string AboutMe = "Home_AboutMe";
                public const string AboutMeText = "Home_AboutMeText";
                public const string ReadMore = "Home_ReadMore";
            }
        }
    }
}
