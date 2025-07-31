using Newtonsoft.Json;
using YandexMarketAPI.Resources.Enums;

namespace YandexMarketAPI.Resources.Models;


/// <summary>
/// Информация о своем регионе магазина.
/// https://yandex.ru/dev/market/partner-api/doc/ru/reference/campaigns/getCampaignSettings#campaignsettingslocalregiondto 
/// </summary>
public class CampaignSettingsLocalRegion
{
    /// <summary>
    /// Информация о доставке в своем регионе магазина.
    /// </summary>
    [JsonProperty("delivery")]
    public CampaignSettingsDelivery Delivery { get; set; }
    
    /// <summary>
    /// Источник информации о расписании работы службы доставки. Возможные значения:
    /// WEB — информация получена из настроек кабинета продавца на Маркете.
    /// YML — информация получена из прайс-листа магазина.
    /// </summary>
    [JsonProperty("deliveryOptionsSource")]
    public CampaignSettingsScheduleSourceType DeliveryOptionsSource { get; set; }
    
    /// <summary>
    /// Идентификатор региона.
    /// </summary>
    [JsonProperty("id")]
    public long Id { get; set; }
    
    /// <summary>
    /// Название региона.
    /// </summary>
    [JsonProperty("name")]
    public string Name { get; set; }
    
    [JsonProperty("type")]
    public RegionType Type { get; set; }
}