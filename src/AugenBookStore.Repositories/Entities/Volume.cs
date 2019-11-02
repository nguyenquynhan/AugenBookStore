using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AugenBookStore.Repositories.Entities
{
    public class Volume
    {
        [JsonProperty(PropertyName = "items")]
        public List<Book> Items { get; set; }
    }
}
