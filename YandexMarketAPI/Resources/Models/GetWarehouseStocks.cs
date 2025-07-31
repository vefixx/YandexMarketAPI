using Newtonsoft.Json;

namespace YandexMarketAPI.Resources.Models;


/// <summary>
/// Список складов с информацией об остатках на каждом из них.
/// https://yandex.ru/dev/market/partner-api/doc/ru/reference/stocks/getStocks#getwarehousestocksdto
/// </summary>
public class GetWarehouseStocks
{
    /// <summary>
    /// Страница списка складов.
    /// Информация об остатках товаров на складе.
    /// </summary>
    [JsonProperty("warehouses")]
    public WarehouseOffers[] Warehouses { get; set; }
    
    /// <summary>
    /// Информация о страницах результатов.
    /// Идентификатор следующей страницы.
    /// </summary>
    [JsonProperty("paging")]
    public ScrollingPager Paging { get; set; }
}