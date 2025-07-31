using Newtonsoft.Json;

namespace YandexMarketAPI.Resources.Models;


/// <summary>
/// https://yandex.ru/dev/market/partner-api/doc/ru/reference/campaigns/getCampaigns#flippingpagerdto
/// </summary>
public class FlippingPager
{
    /// <summary>
    /// Текущая страница.
    /// </summary>
    [JsonProperty("currentPage")]
    public int CurrentPage { get; set; }
    
    /// <summary>
    /// Начальный номер найденного элемента на странице.
    /// </summary>
    [JsonProperty("from")]
    public int From { get; set; }
    
    /// <summary>
    /// Размер страницы.
    /// </summary>
    [JsonProperty("pageSize")]
    public int PageSize { get; set; }
    
    /// <summary>
    /// Общее количество страниц.
    /// </summary>
    [JsonProperty("pagesCount")]
    public int PagesCount { get; set; }
    
    /// <summary>
    /// Конечный номер найденного элемента на странице.
    /// </summary>
    [JsonProperty("to")]
    public int To { get; set; }
    
    /// <summary>
    /// Сколько всего найдено элементов.
    /// </summary>
    [JsonProperty("total")]
    public int Total { get; set; }
}