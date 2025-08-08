using Newtonsoft.Json;

namespace YandexMarketAPI.Resources.Models;


/// <summary>
/// https://yandex.ru/dev/market/partner-api/doc/ru/reference/campaigns/getCampaigns#body
/// </summary>
public class CampaignsResponse
{
    /// <summary>
    /// Список с информацией по каждому магазину. Информация о магазине.
    /// </summary>
    [JsonProperty("campaigns")]
    public List<Campaign> Campaigns { get; set; }
    
    /// <summary>
    /// Модель для пагинации.
    /// </summary>
    [JsonProperty("pager")]
    public FlippingPager Pager { get; set; }
}