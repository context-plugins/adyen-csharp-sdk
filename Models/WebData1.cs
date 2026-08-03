using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// The website and app URL of the legal entity.
/// </summary>
public record WebData1
{
    /// <summary>
    /// The URL of the website or the app store URL.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("webAddress")]
    public string? WebAddress { get; init; }

    /// <summary>
    /// The unique identifier of the web address.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("webAddressId")]
    public string? WebAddressId { get; init; }
}
