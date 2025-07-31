using Newtonsoft.Json;
using YandexMarketAPI.Resources.Enums;

namespace YandexMarketAPI.Resources.Models;


/// <summary>
/// https://yandex.ru/dev/market/partner-api/doc/ru/reference/businesses/getBusinessSettings#body 
/// </summary>
public class BusinessSettingsResponse
{
    /// <summary>
    /// Информация о кабинете и его настройках.
    /// </summary>
    [JsonProperty("result")]
    public GetBusinessSettingsInfo Result { get; set; }
    
    /// <summary>
    /// Тип ответа
    /// </summary>
    [JsonProperty("status")]
    public ApiResponseStatusType Status { get; set; }
}