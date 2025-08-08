using Newtonsoft.Json;
using YandexMarketAPI.Resources.Enums;

namespace YandexMarketAPI.Resources.Models;

public class PutStocksResponse
{
    [JsonProperty("status")]
    public ApiResponseStatusType Status { get; set; }
}