using ServiceStack.DataAnnotations;


namespace Foundation.Model.About
{

    public class About
    {
        [AutoIncrement]
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content1 { get; set; }

        public string Content2 { get; set; }

        public string Content3 { get; set; }

        public string Lang { get; set; }

        public string ImageUrl1 { get; set; }

        public string ImageUrl2 { get; set; }

        public string ImageUrl3 { get; set; }
    }
}
