using System.Runtime.Serialization;

namespace YandexMarketAPI.Resources.Enums;

public enum CampaignSettingsScheduleSourceType
{
    [EnumMember(Value = "WEB")]
    WEB,
    [EnumMember(Value = "YML")]
    YML
}