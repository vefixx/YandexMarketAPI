using Newtonsoft.Json;

namespace YandexMarketAPI.Resources.Models;


/// <summary>
/// https://yandex.ru/dev/market/partner-api/doc/ru/reference/assortment/updatePrices#apierrordto
/// </summary>
public class ApiErrorDTO
{
    [JsonProperty("code")]
    public string Code { get; set; }
    
    [JsonProperty("message")]
    public string Message { get; set; }
}