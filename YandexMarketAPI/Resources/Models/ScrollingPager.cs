using Newtonsoft.Json;

namespace YandexMarketAPI.Resources.Models;


/// <summary>
/// Информация о страницах результатов.
/// https://yandex.ru/dev/market/partner-api/doc/ru/reference/stocks/getStocks#scrollingpagerdto
/// </summary>
public class ScrollingPager
{
    /// <summary>
    /// Идентификатор следующей страницы результатов.
    /// </summary>
    [JsonProperty("nextPageToken")]
    public string NextPageToken { get; set; }
    
    /// <summary>
    /// Идентификатор предыдущей страницы результатов.
    /// </summary>
    [JsonProperty("prevPageToken")]
    public string PrevPageToken { get; set; }
}