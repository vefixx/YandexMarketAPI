using YandexMarketAPI.Resources.Models;

namespace YandexMarketAPI.Resources;

public class Campaigns : ResourceBase
{
    public Campaigns(YandexMarketClient client) : base(client)
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
        string url = BaseUrl + "campaigns";

        Dictionary<string, string?>? queryParams = null;

        if (page is not null && pageSize is not null)
        {
            queryParams = new Dictionary<string, string?>()
            {
                ["page"] = page.ToString(),
                ["pageSize"] = pageSize.ToString()
            };
        }
        CampaignsResponse response = await Client.GetAsync<CampaignsResponse>(url, queryParams);
        return response;
    }
}