using System.Runtime.Serialization;

namespace YandexMarketAPI.Resources.Enums;


/// <summary>
/// https://yandex.ru/dev/market/partner-api/doc/ru/reference/categories/getCategoriesTree#languagetype
/// </summary>
public enum LanguageType
{
    [EnumMember(Value = "RU")]
    RU,
    [EnumMember(Value = "EN")]
    EN
}