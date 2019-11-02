using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace AugenBookStore.Repositories.Entities
{
    public class Image
    {
        [JsonProperty(PropertyName = "thumbnail")]
        public string Thumbnail { get; set; }

        [JsonProperty(PropertyName = "medium")]
        public string Medium { get; set; }
    }
}
