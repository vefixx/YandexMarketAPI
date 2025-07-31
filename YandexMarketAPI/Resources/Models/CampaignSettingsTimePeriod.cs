using Newtonsoft.Json;

namespace YandexMarketAPI.Resources.Models;


/// <summary>
/// Период, за который рассчитывается итоговый список нерабочих дней службы доставки.
/// https://yandex.ru/dev/market/partner-api/doc/ru/reference/campaigns/getCampaignSettings#campaignsettingstimeperioddto
/// </summary>
public class CampaignSettingsTimePeriod
{
    [JsonProperty("fromDate")]
    public DateTime FromDate { get; set; }
    
    [JsonProperty("toDate")]
    public DateTime ToDate { get; set; }
}