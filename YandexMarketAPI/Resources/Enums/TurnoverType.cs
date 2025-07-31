using System.Runtime.Serialization;

namespace YandexMarketAPI.Resources.Enums;


/// <summary>
/// Оценка оборачиваемости.
/// https://yandex.ru/dev/market/partner-api/doc/ru/reference/stocks/getStocks#turnovertype
/// </summary>
public enum TurnoverType
{
    [EnumMember(Value = "LOW")]
    LOW, 
    [EnumMember(Value = "ALMOST_LOW")]
    ALMOST_LOW, 
    [EnumMember(Value = "LOW")]
    HIGH, 
    [EnumMember(Value = "LOW")]
    VERY_HIGH, 
    [EnumMember(Value = "LOW")]
    NO_SALES, 
    [EnumMember(Value = "LOW")]
    FREE_STORE
}