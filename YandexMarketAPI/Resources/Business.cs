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
    public async Task<BusinessSettingsResponse> GetBusinessSettingsAsync(long businessId)
    {
        string url = BaseUrl + $"/{businessId}/settings";
        BusinessSettingsResponse response = await Client.PostAsync<BusinessSettingsResponse>(url);
        return response;
    }
    
    /// <summary>
    /// Устанавливает цены, которые действуют во всех магазинах.
    /// https://yandex.ru/dev/market/partner-api/doc/ru/reference/business-assortment/updateBusinessPrices#request
    /// </summary>
    /// <param name="businessId">Идентификатор кабинета.</param>
    /// <param name="offers">Список товаров с ценами. Товар с новой ценой.</param>
    /// <returns></returns>
    public async Task<ApiDefaultResponse> OfferPricesUpdateAsync(long businessId, List<UpdateBusinessOfferPriceDTO> offers)
    {
        string url = BaseUrl + $"/{businessId}/offer-prices/updates";
        Dictionary<string, object?> json = new Dictionary<string, object?>
        {
            ["offers"] = offers
        };
        ApiDefaultResponse response = await Client.PostAsync<ApiDefaultResponse>(url, jsonData: json);
        return response;
    }
}