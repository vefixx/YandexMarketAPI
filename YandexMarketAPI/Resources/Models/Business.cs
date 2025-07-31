using Newtonsoft.Json;

namespace YandexMarketAPI.Resources.Models;


/// <summary>
/// https://yandex.ru/dev/market/partner-api/doc/ru/reference/campaigns/getCampaigns#businessdto
/// </summary>
public class Business
{
    /// <summary>
    /// Идентификатор кабинета.
    /// </summary>
    [JsonProperty("id")]
    public long Id { get; set; }
    
    /// <summary>
    /// Название бизнеса.
    /// </summary>
    [JsonProperty("name")]
    public string Name { get; set; }
}