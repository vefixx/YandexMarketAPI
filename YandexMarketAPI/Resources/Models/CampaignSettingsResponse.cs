using Newtonsoft.Json;

namespace YandexMarketAPI.Resources.Models;


/// <summary>
/// https://yandex.ru/dev/market/partner-api/doc/ru/reference/campaigns/getCampaignSettings#body
/// </summary>
public class CampaignSettingsResponse
{
    /// <summary>
    /// Настройки магазина.
    /// </summary>
    [JsonProperty("settings")]
    public CampaignSettings Settings { get; set; }
}