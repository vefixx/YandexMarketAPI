using Newtonsoft.Json;
using YandexMarketAPI.Resources.Enums;

namespace YandexMarketAPI.Resources.Models;

/// <summary>
/// https://yandex.ru/dev/market/partner-api/doc/ru/reference/categories/getCategoriesTree#body1
/// </summary>
public class CategoriesTreeResponse
{
    /// <summary>
    /// Информация о категории.
    /// Категория считается листовой, если у нее нет дочерних категорий.
    /// </summary>
    /// <returns></returns>
    [JsonProperty("result")]
    public Category Result { get; set; }
    
    [JsonProperty("status")]
    public ApiResponseStatusType Status { get; set; }
}