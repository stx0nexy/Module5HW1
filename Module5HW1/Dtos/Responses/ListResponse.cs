using Newtonsoft.Json;

namespace Module5HW1.Dtos.Responses;

public class ListResponse<T>
    where T : class
{
    public int Page { get; set; }

    [JsonProperty(PropertyName = "per_page")]
    public int PerPage { get; set; }

    public int Total { get; set; }

    [JsonProperty(PropertyName = "total_pages")]
    public int TotalPages { get; set; }

    public List<T> Data { get; set; }

    public SupportDto Support { get; set; }
}