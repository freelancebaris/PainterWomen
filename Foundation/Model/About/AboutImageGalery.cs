using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation.Model.About
{
    using ServiceStack.DataAnnotations;

    public  class AboutImageGalery
    {
      [AutoIncrement]
      public int Id { get; set; }

      public string ImagePath { get; set; }

      public string Description { get; set; }
    }
}
