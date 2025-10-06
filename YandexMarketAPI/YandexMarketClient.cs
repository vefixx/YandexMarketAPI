using System.Net.Http.Json;
using System.Text;
using YandexMarketAPI.Resources;
using Microsoft.AspNetCore.WebUtilities;
using Newtonsoft.Json;

namespace YandexMarketAPI;

/// <summary>
/// Клиент API Яндекс Маркета
/// </summary>
public class YandexMarketClient
{
    private HttpClient _httpClient;

    public Campaigns Campaigns;
    public Business Business;
    public Categories Categories;

    /// <summary>
    /// Инициализация клиента и ресурсов
    /// </summary>
    /// <param name="apiKey">API ключ партнера Яндекс маркета</param>
    public YandexMarketClient(string apiKey)
    {
        _httpClient = new HttpClient();
        _httpClient.DefaultRequestHeaders.Add("Api-Key", apiKey);

        Campaigns = new Campaigns(this, "campaigns");
        Business = new Business(this, "businesses");
        Categories = new Categories(this, "categories");
    }

    private StringContent JsonToStringContent(object? jsonData)
    {
        var json = JsonConvert.SerializeObject(jsonData, new JsonSerializerSettings
        {
            NullValueHandling = NullValueHandling.Ignore
        });
        var content = new StringContent(json, Encoding.UTF8, "application/json");
        return content;
    }

    public async Task<T> GetAsync<T>(string url, Dictionary<string, string?>? queryParams = null,
        string dateFormatString = "dd-MM-yyyy")
    {
        string uri = queryParams is not null ? QueryHelpers.AddQueryString(url, queryParams) : url;

        using var response = await _httpClient.GetAsync(uri);
        string content = await response.Content.ReadAsStringAsync();

        if (!response.IsSuccessStatusCode)
        {
            throw new HttpRequestException($"Ошибка в GET запросе {uri}: {response.StatusCode}, ответ: {content}");
        }
        
        var result = JsonConvert.DeserializeObject<T>(content, new JsonSerializerSettings
        {
            DateFormatString = dateFormatString
        });

        if (result is null)
        {
            throw new JsonException($"Ответ от сервера пустой ({uri}), модель преобразована некорректно.");
        }

        return result;
    }

    public async Task<T> PostAsync<T>(string url, object? jsonData = null,
        Dictionary<string, string?>? queryParams = null, string dateFormatString = "dd-MM-yyyy")
    {
        string uri = queryParams is not null ? QueryHelpers.AddQueryString(url, queryParams) : url;

        using var response = await _httpClient.PostAsync(uri, JsonToStringContent(jsonData));
        string content = await response.Content.ReadAsStringAsync();

        if (!response.IsSuccessStatusCode)
        {
            throw new HttpRequestException($"Ошибка в POST запросе {uri}: {response.StatusCode}, ответ: {content}");
        }

        var result = JsonConvert.DeserializeObject<T>(content, new JsonSerializerSettings
        {
            DateFormatString = dateFormatString
        });

        if (result is null)
        {
            throw new JsonException($"Ответ от сервера пустой ({uri}), модель преобразована некорректно.");
        }

        return result;
    }


    public async Task<T> PutAsync<T>(string url, object? jsonData = null,
        Dictionary<string, string?>? queryParams = null, string dateFormatString = "dd-MM-yyyy")
    {
        string uri = queryParams is not null ? QueryHelpers.AddQueryString(url, queryParams) : url;

        using var response = await _httpClient.PutAsync(uri, JsonToStringContent(jsonData));
        string content = await response.Content.ReadAsStringAsync();

        if (!response.IsSuccessStatusCode)
        {
            throw new HttpRequestException($"Ошибка в PUT запросе {uri}: {response.StatusCode}, ответ: {content}");
        }

        var result = JsonConvert.DeserializeObject<T>(content, new JsonSerializerSettings
        {
            DateFormatString = dateFormatString
        });

        if (result is null)
        {
            throw new JsonException($"Ответ от сервера пустой ({uri}), модель преобразована некорректно.");
        }

        return result;
    }
}