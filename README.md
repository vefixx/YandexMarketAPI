# YandexMarketAPI

Это неофициальная .NET-библиотека для работы с API Яндекс Маркета. Используется новая система авторизации с помощью `Api-Key`, так как старая (с использованием `OAuth`) больше не поддерживается.

## Возможности

- Получение информации о кампаниях, бизнесах, остатках, категориях и т.д.
- Асинхронная работа.
- Возможность отправлять свои запросы, если готового метода (или ресурса) не существует.
- Новые методы регулярно добавляются!

## Используемые NuGet-пакеты
```xml
<ItemGroup>
    <PackageReference Include="Microsoft.AspNetCore.WebUtilities" Version="9.0.7" />
    <PackageReference Include="Microsoft.Extensions.Logging" Version="9.0.7" />
    <PackageReference Include="Microsoft.Extensions.Logging.Console" Version="9.0.7" />
    <PackageReference Include="Newtonsoft.Json" Version="13.0.3" />
</ItemGroup>
```

## Начало работы

### Интеграция в ваш проект
> **Внимание!** На данный момент поддерживается только клонирование репозитория. Готового NuGet-пакета пока нет!

1. Склонируйте репозиторий:
   ```sh
   git clone https://github.com/vefixx/YandexMarketAPI.git
   ```

2. Добавьте ссылку на проект в ваше решение (Add Reference).  
   Вы также можете использовать исходный код напрямую, скопировав его в своё решение.

### Получение Api-Key для работы
Подробная инструкция от Яндекс.Маркета:  
https://yandex.ru/dev/market/partner-api/doc/ru/concepts/api-key

**Кратко, как получить ключ:**
1. В кабинете в левом нижнем углу нажмите на название своего бизнеса и перейдите на страницу **Модули и API**.
2. В блоке **Авторизационный токен** нажмите кнопку **Создать** или **Создать новый токен**, если вы уже получали его.
3. В открывшемся окне:
    - Укажите уникальное название токена.
    - Выберите необходимые доступы для этого токена.
    - Нажмите кнопку **Создать**.

Скопируйте токен и сохраните его - он понадобится для работы с клиентом.

### Инициализация клиента
Для начала работы с клиентом необходимо его инициализировать. Пример:

```csharp
using YandexMarketAPI;

YandexMarketClient client = new YandexMarketClient(apiKey: "ВАШ_API_КЛЮЧ");
```
В параметр `apiKey` необходимо передать ваш `Api-Key` пользователя Яндекс Маркета.

### Пример использования
*В качестве примера получим все магазины пользователя:*

Обратимся к нашему клиенту -> ресурсу `Campaigns` -> методу `GetCampaignsAsync()`:

```csharp
CampaignsResponse campaignsResponse = await client.Campaigns.GetCampaignsAsync();
```
> **Важно!** На выходе вы **не получаете** сразу список магазинов. Сначала возвращается **ответ** от сервера (модель `CampaignsResponse`).

Теперь можно получить массив магазинов `Campaign[]`:

```csharp
Campaign[] campaigns = campaignsResponse.Campaigns;
```

**Полный пример:**
```csharp
using YandexMarketAPI;
using YandexMarketAPI.Resources.Models;

namespace TestMarketAPI.Campaigns;

class Program
{
    static async Task Main(string[] args)
    {
        YandexMarketClient client = new YandexMarketClient(apiKey: "ВАШ_API_КЛЮЧ");
        CampaignsResponse campaignsResponse = await client.Campaigns.GetCampaignsAsync();
        Campaign[] campaigns = campaignsResponse.Campaigns;
        
        Console.WriteLine($"Получено всего магазинов: {campaigns.Length}");

        foreach (var campaign in campaigns)
        {
            Console.WriteLine($"Магазин: ID={campaign.Id}, Name={campaign.Business.Name}");
        }
    }
}
```

Если вам интересно, ознакомьтесь с полной документацией эндпоинта от Яндекс.Маркета:  
https://yandex.ru/dev/market/partner-api/doc/ru/reference/campaigns/getCampaigns

## Написание своих API методов
Благодаря доступным и расширенным методам `PostAsync`, `GetAsync`, `PutAsync` - в клиенте `YandexMarketClient`, вы можете написать свой API метод.

### Пример создания
> Важно! Для свойств модели необходимо использовать аттрибут `JsonProperty` из `Newtonsoft.Json`, так как иначе может быть конфликт с `System.Text.Json`.

```csharp
using Newtonsoft.Json;
using YandexMarketAPI;

// Модель для отправки/получения данных
public class MyTestModel
{
    [JsonProperty("my_value")]
    public int MyValue { get; set; }

    [JsonProperty("description")]
    public string? Description { get; set; }
}

// Пример вызова кастомного метода через PostAsync с query-параметрами
public async Task<MyTestModel> GetMyTestAsync(YandexMarketClient client, int value, string? desc, string userId)
{
    var data = new MyTestModel
    {
        MyValue = value,
        Description = desc
    };

    // Пример query-параметров
    var queryParams = new Dictionary<string, string?>
    {
        { "userId", userId },
        { "debug", "true" }
    };

    // "custom/endpoint" — ваш путь к эндпоинту
    var result = await client.PostAsync<MyTestModel>(
        "custom/endpoint",
        data, // JSON Data
        queryParams // Query параметры
    );
    return result;
}
```
