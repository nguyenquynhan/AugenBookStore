using AugenBookStore.Repositories.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace AugenBookStore.Repositories.Entities
{
    public class Book
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "volumeInfo")]
        public VolumeInfo VolumeInfo { get; set; }
    }
}
