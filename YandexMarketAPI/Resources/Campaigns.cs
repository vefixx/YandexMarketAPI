using YandexMarketAPI.Resources.Enums;
using YandexMarketAPI.Resources.Models;

namespace YandexMarketAPI.Resources;

public class Campaigns : ResourceBase
{
    public Campaigns(YandexMarketClient client, string basePath) : base(client, basePath)
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

    /// <summary>
    /// Возвращает данные об остатках товаров (для всех моделей) и об оборачиваемости товаров (для модели FBY).
    /// По умолчанию данные по оборачиваемости не возвращаются
    /// Чтобы они были в ответе, передавайте true в поле withTurnover в <see cref="GetStocksRequest"/>.
    /// </summary>
    /// <param name="campaignId">Идентификатор кампании. Его можно узнать с помощью запроса <see cref="GetCampaignsAsync"/> или найти в кабинете продавца на Маркете.</param>
    /// <param name="limit">Количество значений на одной странице.</param>
    /// <param name="pageToken">Идентификатор страницы с результатами. Если параметр не указан, возвращается первая страница. Рекомендуется передавать значение выходного параметра nextPageToken, полученное при последнем запросе.</param>
    /// <param name="requestBody"></param>
    /// <returns></returns>
    public async Task<GetStocksResponse> GetStocksAsync(long campaignId, int limit = 100, string? pageToken = null,
        GetStocksRequest? requestBody = null)
    {
        string url = BaseUrl + $"/{campaignId}/offers/stocks";

        Dictionary<string, string?> queryParams = new Dictionary<string, string?>
        {
            ["limit"] = limit.ToString()
        };

        if (pageToken is not null)
            queryParams.Add("page_token", pageToken);

        GetStocksResponse response =
            await Client.PostAsync<GetStocksResponse>(url, jsonData: requestBody, queryParams: queryParams);
        return response;
    }

    public async Task<PutStocksResponse> PutStocksAsync(long campaignId, PutStocksRequest requestBody)
    {
        string url = BaseUrl + $"/{campaignId}/offers/stocks";
        PutStocksResponse response = await Client.PutAsync<PutStocksResponse>(url, jsonData: requestBody);
        return response;
    }
}