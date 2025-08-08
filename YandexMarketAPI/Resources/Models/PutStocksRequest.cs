using Newtonsoft.Json;

namespace YandexMarketAPI.Resources.Models;

public class PutStocksRequest
{
    /// <summary>
    /// Данные об остатках товаров.
    /// Информация об остатках одного товара на одном из складов.
    /// </summary>
    [JsonProperty("skus")]
    public List<UpdateStock> Skus { get; set; }
}