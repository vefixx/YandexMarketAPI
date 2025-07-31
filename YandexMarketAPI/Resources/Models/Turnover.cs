using Newtonsoft.Json;
using YandexMarketAPI.Resources.Enums;

namespace YandexMarketAPI.Resources.Models;


/// <summary>
/// Информация об оборачиваемости товара.
/// https://yandex.ru/dev/market/partner-api/doc/ru/reference/stocks/getStocks#turnoverdto
/// </summary>
public class Turnover
{
    /// <summary>
    /// Оценка оборачиваемости.
    /// </summary>
    [JsonProperty("turnover")]
    public TurnoverType TurnoverType { get; set; }
    
    /// <summary>
    /// Значение в днях.
    /// </summary>
    [JsonProperty("turnoverDays")]
    public double TurnoverDays { get; set; }
}