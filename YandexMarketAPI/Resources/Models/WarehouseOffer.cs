using Newtonsoft.Json;

namespace YandexMarketAPI.Resources.Models;


/// <summary>
/// Информация об остатках товара.
/// https://yandex.ru/dev/market/partner-api/doc/ru/reference/stocks/getStocks#warehouseofferdto
/// </summary>
public class WarehouseOffer
{
    /// <summary>
    /// Ваш SKU — идентификатор товара в вашей системе.
    /// </summary>
    [JsonProperty("offerId")]
    public string OfferId { get; set; }
    
    /// <summary>
    /// Информация об остатках.
    /// Информация об остатках товара.
    /// </summary>
    [JsonProperty("stocks")]
    public List<WarehouseStock> Stocks { get; set; }
    
    /// <summary>
    /// Информация об оборачиваемости.
    /// </summary>
    [JsonProperty("turnoverSummary")]
    public Turnover? TurnoverSummary { get; set; }
    
    /// <summary>
    /// Дата и время последнего обновления информации об остатках.
    /// Формат даты и времени: ISO 8601 со смещением относительно UTC. Например, 2023-11-21T00:42:42+03:00.
    /// </summary>
    [JsonProperty("updatedAt")]
    public DateTime? UpdatedAt { get; set; }
}