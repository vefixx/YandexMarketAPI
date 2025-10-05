using Newtonsoft.Json;
using YandexMarketAPI.Resources.Enums;

namespace YandexMarketAPI.Resources.Models;

public class ApiDefaultResponse
{
    [JsonProperty("status")]
    public ApiResponseStatusType Status { get; set; }

    [JsonProperty("errors")] public List<ApiError>? Errors { get; set; } = null;
}