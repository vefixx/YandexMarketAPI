using System.Runtime.Serialization;

namespace YandexMarketAPI.Resources.Enums;


/// <summary>
/// https://yandex.ru/dev/market/partner-api/doc/ru/reference/campaigns/getCampaigns#placementtype
/// </summary>
public enum PlacementType
{
    [EnumMember(Value = "FBS")]
    FBS,
    
    [EnumMember(Value = "FBY")]
    FBY,
    
    [EnumMember(Value = "DBS")]
    DBS
}