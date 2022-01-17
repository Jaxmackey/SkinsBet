
using System.Text.Json.Serialization;

namespace Domain.Entities
{
    public class Skin
    {
        [JsonPropertyName("select")]
        public bool Select { get; set; } = false;
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("classId")]
        public string ClassId { get; set;  }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("description")]
        public string Description { get; set; }
        [JsonPropertyName("iconUrl")]
        public string IconUrl { get; set; }
    }
}