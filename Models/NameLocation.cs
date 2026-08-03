using System.Text.Json.Serialization;

namespace Adyen.Models;

public record NameLocation
{
    /// <summary>
    /// The city where the merchant is located.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("city")]
    public string? City { get; init; }

    /// <summary>
    /// The country where the merchant is located in <see href="https://en.wikipedia.org/wiki/ISO_3166-1_alpha-3">three-letter country code</see> format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("country")]
    public string? Country { get; init; }

    /// <summary>
    /// The home country in <see href="https://en.wikipedia.org/wiki/ISO_3166-1_numeric">three-digit country code</see> format, used for government-controlled merchants such as embassies.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("countryOfOrigin")]
    public string? CountryOfOrigin { get; init; }

    /// <summary>
    /// The name of the merchant's shop or service.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// The raw data.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("rawData")]
    public string? RawData { get; init; }

    /// <summary>
    /// The state where the merchant is located.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("state")]
    public string? State { get; init; }
}
