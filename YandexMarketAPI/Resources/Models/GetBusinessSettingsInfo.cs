using Newtonsoft.Json;

namespace YandexMarketAPI.Resources.Models;


/// <summary>
/// Информация о кабинете и его настройках.
/// https://yandex.ru/dev/market/partner-api/doc/ru/reference/businesses/getBusinessSettings#getbusinesssettingsinfodto
/// </summary>
public class GetBusinessSettingsInfo
{
    /// <summary>
    /// Базовая информация о кабинете.
    /// </summary>
    [JsonProperty("info")]
    public Business Info { get; set; }
    
    /// <summary>
    /// Настройки на уровне кабинета.
    /// </summary>
    [JsonProperty("settings")]
    public BusinessSettings Settings { get; set; }
}