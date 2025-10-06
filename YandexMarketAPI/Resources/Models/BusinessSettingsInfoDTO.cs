using Newtonsoft.Json;

namespace YandexMarketAPI.Resources.Models;


/// <summary>
/// Информация о кабинете и его настройках.
/// https://yandex.ru/dev/market/partner-api/doc/ru/reference/businesses/getBusinessSettings#getbusinesssettingsinfodto
/// </summary>
public class BusinessSettingsInfoDTO
{
    /// <summary>
    /// Базовая информация о кабинете.
    /// </summary>
    [JsonProperty("info")]
    public BusinessDTO Info { get; set; }
    
    /// <summary>
    /// Настройки на уровне кабинета.
    /// </summary>
    [JsonProperty("settings")]
    public BusinessSettingsDTO SettingsDto { get; set; }
}