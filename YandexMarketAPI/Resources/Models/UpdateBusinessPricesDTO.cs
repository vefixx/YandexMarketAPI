using Newtonsoft.Json;
using YandexMarketAPI.Resources.Enums;

namespace YandexMarketAPI.Resources.Models;


/// <summary>
/// Цены.
/// https://yandex.ru/dev/market/partner-api/doc/ru/reference/business-assortment/updateBusinessPrices#updatebusinesspricesdto
/// </summary>
public class UpdateBusinessPricesDTO
{
    /// <summary>
    /// Валюта
    /// </summary>
    [JsonProperty("currencyId")] public CurrencyType CurrencyId { get; set; }
    /// <summary>
    /// Зачеркнутая цена.
    ///Число должно быть целым. Вы можете указать цену со скидкой от 5 до 99%.
    ///Передавайте этот параметр при каждом обновлении цены, если предоставляете скидку на товар.
    /// </summary>
    [JsonProperty("discountBase")] public int? DiscountBase { get; set; } = null;
    /// <summary>
    /// Минимальная цена товара для попадания в акцию «Бестселлеры Маркета».
    /// </summary>
    [JsonProperty("minimumForBestseller")] public int MinimumForBestseller { get; set; }
    /// <summary>
    /// Цена товара
    /// </summary>
    [JsonProperty("value")] public int Value { get; set; }
}