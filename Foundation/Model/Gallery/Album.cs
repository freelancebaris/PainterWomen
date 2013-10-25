using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;

namespace Foundation.Model.Gallery
{
    [Alias("Albums")]
    public class Album
    {
        [AutoIncrement]
        [PrimaryKey]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CoverImagePath { get; set; }
        public int Lang { get; set; }
    }
}
