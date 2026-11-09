using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace SearchDemonSlayerAPI.Models
{
    public class DemonSlayerApiResponse
    {
        [JsonPropertyName("pagination")]
        [JsonProperty("pagination")]
        public PaginationInfo? Pagination { get; set; }

        [JsonPropertyName("content")]
        [JsonProperty("content")]
        public List<Character>? Content { get; set; }
    }

    public class PaginationInfo
    {
        [JsonPropertyName("totalElements")]
        [JsonProperty("totalElements")]
        public int TotalElements { get; set; }

        [JsonPropertyName("elementsOnPage")]
        [JsonProperty("elementsOnPage")]
        public int ElementsOnPage { get; set; }

        [JsonPropertyName("currentPage")]
        [JsonProperty("currentPage")]
        public int CurrentPage { get; set; }

        [JsonPropertyName("totalPages")]
        [JsonProperty("totalPages")]
        public int TotalPages { get; set; }

        [JsonPropertyName("previousPage")]
        [JsonProperty("previousPage")]
        public string? PreviousPage { get; set; }

        [JsonPropertyName("nextPage")]
        [JsonProperty("nextPage")]
        public string? NextPage { get; set; }
    }

    public class Character
    {
        [JsonPropertyName("id")]
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonPropertyName("age")]
        [JsonProperty("age")]
        public int? Age { get; set; }

        [JsonPropertyName("gender")]
        [JsonProperty("gender")]
        public string? Gender { get; set; }

        [JsonPropertyName("race")]
        [JsonProperty("race")]
        public string? Race { get; set; }

        [JsonPropertyName("description")]
        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonPropertyName("img")]
        [JsonProperty("img")]
        public string? Img { get; set; }

        [JsonPropertyName("quote")]
        [JsonProperty("quote")]
        public string? Quote { get; set; }
    }
}
