using System.Runtime.Serialization;

namespace YandexMarketAPI.Resources.Enums;


/// <summary>
/// Тип остатков товаров на складе:
/// https://yandex.ru/dev/market/partner-api/doc/ru/reference/stocks/getStocks#warehousestocktype
/// </summary>
public enum WarehouseStockType
{
    [EnumMember(Value = "FIT")]
    FIT,
    [EnumMember(Value = "FREEZE")]
    FREEZE,
    [EnumMember(Value = "AVAILABLE")]
    AVAILABLE,
    [EnumMember(Value = "QUARANTINE")]
    QUARANTINE,
    [EnumMember(Value = "UTILIZATION")]
    UTILIZATION,
    [EnumMember(Value = "DEFECT")]
    DEFECT,
    [EnumMember(Value = "EXPIRED")]
    EXPIRED
}