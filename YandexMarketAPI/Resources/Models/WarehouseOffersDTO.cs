using Newtonsoft.Json;

namespace YandexMarketAPI.Resources.Models;


/// <summary>
/// Информация об остатках товаров на складе.
/// https://yandex.ru/dev/market/partner-api/doc/ru/reference/stocks/getStocks#warehouseoffersdto
/// </summary>
public class WarehouseOffersDTO
{
    /// <summary>
    /// Информация об остатках.
    /// Информация об остатках товара.
    /// </summary>
    [JsonProperty("offers")]
    public List<WarehouseOfferDTO> Offers { get; set; }
    
    [JsonProperty("warehouseId")]
    public long WarehouseId { get; set; }
}