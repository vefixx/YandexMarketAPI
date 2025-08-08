using Newtonsoft.Json;

namespace YandexMarketAPI.Resources.Models;


/// <summary>
/// Информация об остатках товара.
/// https://yandex.ru/dev/market/partner-api/doc/ru/reference/stocks/updateStocks#updatestockitemdto
/// </summary>
public class UpdateStockItem
{
    /// <summary>
    /// Количество доступного товара.
    /// </summary>
    [JsonProperty("count")]
    public long Count { get; set; }
    
    /// <summary>
    /// Дата и время последнего обновления информации об остатках.
    /// Если вы не передали параметр updatedAt, используется текущее время.
    /// </summary>
    [JsonProperty("updatedAt")]
    public DateTime? UpdatedAt { get; set; }
}