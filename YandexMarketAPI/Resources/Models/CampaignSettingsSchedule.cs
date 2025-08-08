using Newtonsoft.Json;

namespace YandexMarketAPI.Resources.Models;


/// <summary>
/// Расписание работы службы доставки в своем регионе.
/// https://yandex.ru/dev/market/partner-api/doc/ru/reference/campaigns/getCampaignSettings#campaignsettingsscheduledto
/// </summary>
public class CampaignSettingsSchedule
{
    /// <summary>
    /// Список дней, в которые служба доставки не работает. Дни магазин указал в кабинете продавца на Маркете. Формат даты: ДД-ММ-ГГГГ.
    /// </summary>
    [JsonProperty("customHolidays")]
    public List<DateTime> CustomHolidays { get; set; }
    
    /// <summary>
    /// Список выходных и праздничных дней, в которые служба доставки работает. Дни магазин указал в кабинете продавца на Маркете. Формат даты: ДД-ММ-ГГГГ.
    /// </summary>
    [JsonProperty("customWorkingDays")]
    public List<DateTime> CustomWorkingDays { get; set; }
    
    /// <summary>
    /// Итоговый список нерабочих дней службы доставки. Список рассчитывается с учетом выходных, нерабочих дней и государственных праздников. Информацию по ним магазин указывает в кабинете продавца на Маркете. Формат даты: ДД-ММ-ГГГГ.
    /// </summary>
    [JsonProperty("totalHolidays")]
    public List<DateTime> TotalHolidays { get; set; }
    
    /// <summary>
    /// Список выходных дней недели и государственных праздников.
    /// Номер дня недели. Возможные значения:

    /// 1 — понедельник.
    /// 2 — вторник.
    /// 3 — среда.
    /// 4 — четверг.
    /// 5 — пятница.
    /// 6 — суббота.
    /// 7 — воскресенье.
    /// </summary>
    [JsonProperty("weeklyHolidays")]
    public List<short> WeeklyHolidays { get; set; }
    
    /// <summary>
    /// Признак работы службы доставки в государственные праздники. Возможные значения.
    /// </summary>
    [JsonProperty("availableOnHolidays")]
    public bool AvailableOnHolidays { get; set; }
    
    /// <summary>
    /// Период, за который рассчитывается итоговый список нерабочих дней службы доставки.
    /// </summary>
    [JsonProperty("period")]
    public CampaignSettingsTimePeriod Period { get; set; }
}