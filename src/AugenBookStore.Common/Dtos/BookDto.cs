using System;
using System.Collections.Generic;

namespace AugenBookStore.Common.Dtos
{
    public class BookDto
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public List<string> Authors { get; set; }
        public string PublishedDate { get; set; }
        public string Description { get; set; }
        public string Thumbnail { get; set; }
        public string Medium { get; set; }
    }
}
