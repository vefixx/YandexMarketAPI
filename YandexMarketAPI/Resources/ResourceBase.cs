namespace YandexMarketAPI.Resources;

public abstract class ResourceBase
{
    protected YandexMarketClient Client { get; set; }
    
    protected readonly string BaseUrl = "https://api.partner.market.yandex.ru/";

    protected ResourceBase(YandexMarketClient client, string basePath)
    {
        BaseUrl += basePath;
        Client = client;
    }
}