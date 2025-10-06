using Newtonsoft.Json;

namespace YandexMarketAPI.Resources.Models;


/// <summary>
/// Товар с новой ценой.
/// https://yandex.ru/dev/market/partner-api/doc/ru/reference/business-assortment/updateBusinessPrices#updatebusinessofferpricedto
/// </summary>
public class UpdateBusinessOfferPriceDTO
{
    [JsonProperty("offerId")]
    public string OfferId { get; set; }
    
    [JsonProperty("price")]
    public UpdateBusinessPricesDTO Price { get; set; }
}