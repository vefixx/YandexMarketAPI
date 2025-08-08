using Newtonsoft.Json;

namespace YandexMarketAPI.Resources.Models;


/// <summary>
/// Информация о категории.
/// Категория считается листовой, если у нее нет дочерних категорий.
/// </summary>
public class Category
{
    /// <summary>
    /// Идентификатор категории.
    /// </summary>
    [JsonProperty("id")]
    public long Id { get; set; }
    
    /// <summary>
    /// Название категории.
    /// </summary>
    [JsonProperty("name")]
    public string Name { get; set; }
    
    [JsonProperty("children")]
    public List<Category>? Children { get; set; }
}