using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Adyen-developed software, such as libraries and plugins, used to interact with the Adyen API. For example, Magento plugin, Java API library, etc.
/// </summary>
public record CommonField4
{
    /// <summary>
    /// Name of the field. For example, Name of External Platform.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// Version of the field. For example, Version of External Platform.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("version")]
    public string? Version { get; init; }
}
