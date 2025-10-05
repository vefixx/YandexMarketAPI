using Newtonsoft.Json;
using YandexMarketAPI.Resources.Enums;

namespace YandexMarketAPI.Resources.Models;


/// <summary>
/// https://yandex.ru/dev/market/partner-api/doc/ru/reference/assortment/updatePrices#apiresponsestatustype
/// </summary>
public class ApiDefaultResponse
{
    [JsonProperty("status")]
    public ApiResponseStatusType Status { get; set; }

    [JsonProperty("errors")] public List<ApiError>? Errors { get; set; } = null;
}