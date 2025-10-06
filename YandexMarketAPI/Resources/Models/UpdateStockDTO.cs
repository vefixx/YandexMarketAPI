using Newtonsoft.Json;

namespace YandexMarketAPI.Resources.Models;


/// <summary>
/// Информация об остатках одного товара на одном из складов.
/// https://yandex.ru/dev/market/partner-api/doc/ru/reference/stocks/updateStocks#updatestockdto
/// </summary>
public class UpdateStockDTO
{
    /// <summary>
    /// Информация об остатках товара.
    /// Внимание! У данного свойства максимальное количество элементов - 1!
    /// </summary>
    [JsonProperty("items")]
    public List<UpdateStockItemDTO> Items { get; set; }
    
    /// <summary>
    /// SKU — идентификатор товара в системе.
    /// </summary>
    [JsonProperty("sku")]
    public string Sku { get; set; }
    
}