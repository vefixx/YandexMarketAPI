using Newtonsoft.Json;

namespace YandexMarketAPI.Resources.Models;


/// <summary>
/// Информация о доставке в своем регионе магазина.
/// https://yandex.ru/dev/market/partner-api/doc/ru/reference/campaigns/getCampaignSettings#campaignsettingsdeliverydto
/// </summary>
public class CampaignSettingsDelivery
{
    /// <summary>
    /// Расписание работы службы доставки в своем регионе.
    /// </summary>
    [JsonProperty("schedule")]
    public CampaignSettingsSchedule Schedule { get; set; }
}