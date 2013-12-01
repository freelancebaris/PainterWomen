using ServiceStack.DataAnnotations;

namespace Foundation.Model.Workshop
{
    [Alias("Workshop")]
    public class WorkshopItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Href { get; set; }
        public string Description { get; set; }
        public int Lang { get; set; }


    }
}
