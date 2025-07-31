using Newtonsoft.Json;
using YandexMarketAPI.Resources.Enums;

namespace YandexMarketAPI.Resources.Models;


/// <summary>
/// Настройки кабинета.
/// https://yandex.ru/dev/market/partner-api/doc/ru/reference/businesses/getBusinessSettings#businesssettingsdto
/// </summary>
public class BusinessSettings
{
    /// <summary>
    /// Валюта в кабинете продавца на Маркете.
    /// </summary>
    [JsonProperty("currency")]
    public CurrencyType Currency { get; set; }
    
    /// <summary>
    /// Управление ценами на товары
    /// </summary>
    [JsonProperty("onlyDefaultPrice")]
    public bool OnlyDefaultPrice { get; set; }
}