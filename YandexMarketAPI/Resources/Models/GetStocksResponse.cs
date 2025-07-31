using Newtonsoft.Json;
using YandexMarketAPI.Resources.Enums;

namespace YandexMarketAPI.Resources.Models;

/// <summary>
/// https://yandex.ru/dev/market/partner-api/doc/ru/reference/stocks/getStocks#body
/// </summary>
public class GetStocksResponse
{
    /// <summary>
    /// Список складов с информацией об остатках на каждом из них.
    /// </summary>
    [JsonProperty("result")] 
    public GetWarehouseStocks Result { get; set; }
    
    [JsonProperty("status")]
    public ApiResponseStatusType Status { get; set; }
}