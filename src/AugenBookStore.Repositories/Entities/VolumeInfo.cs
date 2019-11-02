using AugenBookStore.Common.Dtos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AugenBookStore.Repositories.Entities
{
    public class VolumeInfo
    {
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "authors")]
        public List<string> Authors { get; set; }

        [JsonProperty(PropertyName = "publishedDate")]
        public string PublishedDate { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }


        [JsonProperty(PropertyName = "imageLinks")]
        public Image ImageLinks { get; set; }
    }
}
