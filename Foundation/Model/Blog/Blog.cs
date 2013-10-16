namespace Foundation.Model.Blog
{
    using System;

    using ServiceStack.DataAnnotations;

    public class Blog
    {
        [AutoIncrement]
        public int Id { get; set; }

        public string Title { get; set; }

        public string Explain { get; set; }

        public string Content { get; set; }

        public string ImagePath { get; set; }

        public DateTime? Date { get; set; }

        public string Author { get; set; }

        public Enums.Language Lang { get; set; }
    }
}
