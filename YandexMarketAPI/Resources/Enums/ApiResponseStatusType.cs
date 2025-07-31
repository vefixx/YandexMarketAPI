using System.Runtime.Serialization;

namespace YandexMarketAPI.Resources.Enums;

public enum ApiResponseStatusType
{
    [EnumMember(Value = "OK")]
    OK,
    
    [EnumMember(Value = "ERROR")]
    ERROR,
}