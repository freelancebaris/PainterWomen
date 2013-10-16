using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation.Model.Galery
{
    public class PhotoGalery
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public PhotoType PhotoType { get; set; }

        public string Lang { get; set; }
    }
}
