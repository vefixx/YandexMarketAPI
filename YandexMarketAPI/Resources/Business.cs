using YandexMarketAPI.Resources.Models;

namespace YandexMarketAPI.Resources;

public class Business : ResourceBase
{
    public Business(YandexMarketClient client, string basePath) : base(client, basePath)
    {
    }
    
    /// <summary>
    /// Возвращает информацию о настройках кабинета, идентификатор которого указан в запросе.
    /// https://yandex.ru/dev/market/partner-api/doc/ru/reference/businesses/getBusinessSettings
    /// </summary>
    /// <param name="businessId">Идентификатор кабинета. Чтобы его узнать, воспользуйтесь <see cref="Campaigns.GetCampaignsAsync"/></param>
    /// <returns><see cref="BusinessSettingsResponse"/></returns>
    public async Task<BusinessSettingsResponse> GetBusinessSettings(long businessId)
    {
        string url = BaseUrl + $"/{businessId}/settings";
        BusinessSettingsResponse response = await Client.PostAsync<BusinessSettingsResponse>(url);
        return response;
    }
}