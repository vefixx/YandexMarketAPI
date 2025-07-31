using Newtonsoft.Json;
using YandexMarketAPI.Resources.Enums;

namespace YandexMarketAPI.Resources.Models;


/// <summary>
/// Информация об остатках товара.
/// https://yandex.ru/dev/market/partner-api/doc/ru/reference/stocks/getStocks#warehousestockdto
/// </summary>
public class WarehouseStock
{
    /// <summary>
    /// Значение остатков.
    /// </summary>
    [JsonProperty("count")]
    public long Count { get; set; }
    
    /// <summary>
    /// Тип остатков.
    /// </summary>
    [JsonProperty("type")]
    public WarehouseStockType Type { get; set; }
}