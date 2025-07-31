using Newtonsoft.Json;
using YandexMarketAPI.Resources.Enums;

namespace YandexMarketAPI.Resources.Models;


/// <summary>
/// https://yandex.ru/dev/market/partner-api/doc/ru/reference/campaigns/getCampaigns#campaigndto
/// </summary>
public class Campaign
{
    /// <summary>
    /// Информация о кабинете.
    /// </summary>
    [JsonProperty("business")]
    public Business Business { get; set; }
    
    /// <summary>
    /// Идентификатор плательщика в Яндекс Балансе.
    /// </summary>
    [JsonProperty("clientId")]
    public int ClientId { get; set; }
    
    /// <summary>
    /// URL магазина.
    /// </summary>
    [JsonProperty("domain")]
    public string Domain { get; set; }
    
    /// <summary>
    /// Идентификатор кампании.
    /// </summary>
    [JsonProperty("id")]
    public int Id { get; set; }
    
    /// <summary>
    /// Модель, по которой работает магазин:
    /// </summary>
    [JsonProperty("placementType")]
    public PlacementType PlacementType { get; set; }
}