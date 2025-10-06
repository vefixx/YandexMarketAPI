using Newtonsoft.Json;

namespace YandexMarketAPI.Resources.Models;


/// <summary>
/// https://yandex.ru/dev/market/partner-api/doc/ru/reference/campaigns/getCampaign#body
/// </summary>
public class CampaignResponse
{
    /// <summary>
    /// Информация о магаизне.
    /// </summary>
    [JsonProperty("campaign")]
    public CampaignDTO CampaignDto { get; set; }
}