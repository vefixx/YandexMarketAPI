using YandexMarketAPI.Resources.Models;

namespace YandexMarketAPI.Resources;

public class Campaigns : ResourceBase
{
    public Campaigns(YandexMarketClient client) : base(client, "campaigns")
    {
        
    }
    
    /// <summary>
    /// Список магазинов пользователя
    /// https://yandex.ru/dev/market/partner-api/doc/ru/reference/campaigns/getCampaigns
    /// </summary>
    /// <param name="page">Номер страницы результатов. Используется вместе с параметром <c>pageSize</c>.</param>
    /// <param name="pageSize">Размер страницы. Используется вместе с параметром <c>page</c>.</param>
    /// <returns><see cref="CampaignsResponse"/></returns>
    public async Task<CampaignsResponse> GetCampaignsAsync(int? page = null, int? pageSize = null)
    {
        string url = BaseUrl;

        Dictionary<string, string?>? queryParams = null;

        if (page is not null && pageSize is not null)
        {
            queryParams = new Dictionary<string, string?>
            {
                ["page"] = page.ToString(),
                ["pageSize"] = pageSize.ToString()
            };
        }
        
        CampaignsResponse response = await Client.GetAsync<CampaignsResponse>(url, queryParams);
        return response;
    }
    
    /// <summary>
    /// Информация о магазине
    /// https://yandex.ru/dev/market/partner-api/doc/ru/reference/campaigns/getCampaign
    /// </summary>
    /// <param name="campaignId">Идентификатор кампании. Его можно узнать с помощью <see cref="GetCampaignsAsync"/> или найти в кабинете продавца на Маркете.</param>
    /// <returns><see cref="CampaignResponse"/></returns>
    public async Task<CampaignResponse> GetCampaignInfoAsync(long campaignId)
    {
        string url = BaseUrl + $"/{campaignId}";
        CampaignResponse response = await Client.GetAsync<CampaignResponse>(url);
        return response;
    }
    
    /// <summary>
    /// Возвращает информацию о настройках магазина, идентификатор которого указан в запросе.
    /// https://yandex.ru/dev/market/partner-api/doc/ru/reference/campaigns/getCampaignSettings
    /// </summary>
    /// <param name="campaignId"></param>
    /// <returns><see cref="CampaignSettingsResponse"/></returns>
    public async Task<CampaignSettingsResponse> GetCampaignSettingsAsync(long campaignId)
    {
        string url = BaseUrl + $"/{campaignId}/settings";
        CampaignSettingsResponse response = await Client.GetAsync<CampaignSettingsResponse>(url);
        return response;
    }
}