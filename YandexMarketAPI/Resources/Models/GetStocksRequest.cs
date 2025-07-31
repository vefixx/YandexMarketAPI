using Newtonsoft.Json;

namespace YandexMarketAPI.Resources.Models;


/// <summary>
/// Дополнительный контент (Body) для отправки запроса <see cref="Campaigns.GetStocksAsync"/>
/// https://yandex.ru/dev/market/partner-api/doc/ru/reference/stocks/getStocks#body
/// </summary>
public class GetStocksRequest
{
    /// <summary>
    /// Фильтр по нахождению в архиве.
    /// Передайте true, чтобы получить информацию об остатках товаров, которые находятся в архиве.
    ///     Если фильтр не заполнен или передано false, в ответе возвращается информация о товарах, которые не находятся в архиве.
    /// </summary>
    [JsonProperty("archived")]
    public bool? Archived { get; set; }
    
    /// <summary>
    /// Фильтр по вашим SKU товаров.
    /// Возвращается информация об остатках всех переданных SKU, включая товары в архиве.
    /// </summary>
    [JsonProperty("offerIds")]
    public string[]? OfferIds { get; set; }
    
    /// <summary>
    /// Идентификатор склада.
    /// Если параметр указан, возвращаются только товары в наличии на переданном складе.
    /// 
    /// </summary>
    [JsonProperty("stocksWarehouseId")]
    public long? StocksWarehouseId { get; set; }

    /// <summary>
    /// Только для модели FBY. Возвращать ли информацию по оборачиваемости. Значение по умолчанию: false. Если информация нужна, передайте значение true.
    /// </summary>
    [JsonProperty("withTurnover")]
    public bool? WithTurnover { get; set; } = false;
}