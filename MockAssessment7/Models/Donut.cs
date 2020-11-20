using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MockAssessment7.Models
{
    public class Donut
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Calories { get; set; }
        [JsonPropertyName("photo")]
        public string PhotoURL { get; set; }
        public List<string> Extras { get; set; } = new List<string>();
    }
}
