using System.Net.Http.Json;
using System.Text;
using YandexMarketAPI.Resources;
using Microsoft.AspNetCore.WebUtilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

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

    private static readonly JsonSerializerSettings RequestJsonSettings = new()
    {
        NullValueHandling = NullValueHandling.Ignore,
        ContractResolver = new DefaultContractResolver
        {
            // Устанавливаем по умолчанию, чтобы все свойства моделей преобразовывались
            // в camelCase (если у них нет аттрибута JsonProperty[])
            NamingStrategy = new CamelCaseNamingStrategy(
                processDictionaryKeys: true,
                overrideSpecifiedNames: false
            )
        },
        Converters = { new StringEnumConverter() }
    };

    private static readonly JsonSerializerSettings ResponseJsonSettings = new()
    {
        DateFormatString = "dd-MM-yyyy"
    };

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

    private static StringContent? BuildContent(object? jsonData)
    {
        if (jsonData == null)
            return null;

        string json = JsonConvert.SerializeObject(jsonData, RequestJsonSettings);
        return new StringContent(json, Encoding.UTF8, "application/json");
    }

    private static string BuildUri(string url, Dictionary<string, string?>? queryParams)
    {
        if (queryParams != null)
        {
            queryParams = queryParams.Where(kv => kv.Value != null).ToDictionary(kv => kv.Key, kv => kv.Value);
        }

        return queryParams != null ? QueryHelpers.AddQueryString(url, queryParams) : url;
    }

    private async Task<T> SendAsync<T>(HttpMethod method, string url, object? jsonData = null,
        Dictionary<string, string?>? queryParams = null)
    {
        string uri = BuildUri(url, queryParams);
        StringContent? requestContent = BuildContent(jsonData);

        using var request = new HttpRequestMessage(method, uri)
        {
            Content = requestContent
        };

        using var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseContentRead);
        string content = await response.Content.ReadAsStringAsync();

        if (!response.IsSuccessStatusCode)
        {
            string previewResponse = content.Length > 500 ? content[..500] : content;
            
            throw new HttpRequestException(
                $"Ошибка {method} {uri}: {(int)response.StatusCode} {response.ReasonPhrase}. Ответ: {previewResponse}");
        }

        var result = JsonConvert.DeserializeObject<T>(content, ResponseJsonSettings);
        if (result is null)
            throw new JsonException($"Ответ пустой или не распознан ({uri}).");

        return result;
    }

    public async Task<T> GetAsync<T>(string url,
        Dictionary<string, string?>? queryParams = null) => await SendAsync<T>(HttpMethod.Get, url, null, queryParams);

    public async Task<T> PostAsync<T>(string url, object? jsonData = null,
        Dictionary<string, string?>? queryParams = null,
        CancellationToken ct = default) => await SendAsync<T>(HttpMethod.Post, url, jsonData, queryParams);

    public async Task<T> PutAsync<T>(string url, object? jsonData = null,
        Dictionary<string, string?>? queryParams = null) => await SendAsync<T>(HttpMethod.Put, url, jsonData, queryParams);
}