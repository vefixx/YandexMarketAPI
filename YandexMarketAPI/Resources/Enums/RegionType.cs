using System.Runtime.Serialization;

namespace YandexMarketAPI.Resources.Enums;

/// <summary>
/// Тип региона.
/// </summary>
public enum RegionType
{
    /// <summary>
    /// Район города.
    /// </summary>
    [EnumMember(Value = "CITY_DISTRICT")]
    CITY_DISTRICT,

    /// <summary>
    /// Крупный город.
    /// </summary>
    [EnumMember(Value = "CITY")]
    CITY,

    /// <summary>
    /// Континент.
    /// </summary>
    [EnumMember(Value = "CONTINENT")]
    CONTINENT,

    /// <summary>
    /// Область.
    /// </summary>
    [EnumMember(Value = "COUNTRY_DISTRICT")]
    COUNTRY_DISTRICT,

    /// <summary>
    /// Страна.
    /// </summary>
    [EnumMember(Value = "COUNTRY")]
    COUNTRY,

    /// <summary>
    /// Регион.
    /// </summary>
    [EnumMember(Value = "REGION")]
    REGION,

    /// <summary>
    /// Район субъекта федерации.
    /// </summary>
    [EnumMember(Value = "REPUBLIC_AREA")]
    REPUBLIC_AREA,

    /// <summary>
    /// Субъект федерации.
    /// </summary>
    [EnumMember(Value = "REPUBLIC")]
    REPUBLIC,

    /// <summary>
    /// Станция метро.
    /// </summary>
    [EnumMember(Value = "SUBWAY_STATION")]
    SUBWAY_STATION,

    /// <summary>
    /// Город.
    /// </summary>
    [EnumMember(Value = "VILLAGE")]
    VILLAGE,

    /// <summary>
    /// Неизвестный регион.
    /// </summary>
    [EnumMember(Value = "OTHER")]
    OTHER
}