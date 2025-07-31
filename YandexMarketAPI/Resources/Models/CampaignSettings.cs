using Newtonsoft.Json;

namespace YandexMarketAPI.Resources.Models;


/// <summary>
/// Настройки магазина.
/// https://yandex.ru/dev/market/partner-api/doc/ru/reference/campaigns/getCampaignSettings#campaignsettingsdto
/// </summary>
public class CampaignSettings
{
    /// <summary>
    /// Идентификатор региона, в котором находится магазин.
    /// </summary>
    [JsonProperty("countryRegion")]
    public long CountryRegion { get; set; }
    
    /// <summary>
    /// Информация о своем регионе магазина.
    /// </summary>
    [JsonProperty("localRegion")]
    public CampaignSettingsLocalRegion LocalRegion { get; set; }
    
    /// <summary>
    /// Наименование магазина на Яндекс Маркете. Если наименование отсутствует, значение параметра выводится — null.
    /// </summary>
    [JsonProperty("shopName")]
    public string ShopName { get; set; }
    
    /// <summary>
    /// Признак размещения магазина на сайтах партнеров Яндекс Дистрибуции. Возможные значения:
    /// false — магазин не размещен на сайтах партнеров Яндекс Дистрибуции.
    /// true — магазин размещен на сайтах партнеров Яндекс Дистрибуции.
    /// </summary>
    [JsonProperty("showInContext")]
    public bool ShowInContext { get; set; }
    
    /// <summary>
    /// Признак показа предложений магазина в блоке над результатами поиска (cпецразмещение). Возможные значения:
    /// false — предложения не показываются в блоке cпецразмещения.
    /// true — предложения показываются в блоке cпецразмещения.
    /// </summary>
    [JsonProperty("showInPremium")]
    public bool ShowInPremium { get; set; }
    
    /// <summary>
    /// Признак использования внешней интернет-статистики. Возможные значения:
    /// false — внешняя интернет-статистика не используется.
    /// true — внешняя интернет-статистика используется.
    /// </summary>
    [JsonProperty("useOpenStat")]
    public bool UseOpenStat { get; set; }
}