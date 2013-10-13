﻿namespace Foundation.Model.Blog
{
    public class Blog
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Explain { get; set; }

        public string Content { get; set; }

        public string ImagePath { get; set; }

        public Enums.Language Lang { get; set; }
    }
}
