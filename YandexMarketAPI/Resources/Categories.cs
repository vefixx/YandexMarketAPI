using YandexMarketAPI.Resources.Enums;
using YandexMarketAPI.Resources.Models;

namespace YandexMarketAPI.Resources;

public class Categories : ResourceBase
{
    public Categories(YandexMarketClient client, string basePath) : base(client, basePath)
    {
    }

    public async Task<CategoriesTreeResponse> GetCategoriesTreeAsync(LanguageType languageType)
    {
        string url = BaseUrl + "/tree";
        CategoriesTreeResponse response =
            await Client.PostAsync<CategoriesTreeResponse>(url, jsonData: new { language = languageType.ToString() });
        return response;
    }
}