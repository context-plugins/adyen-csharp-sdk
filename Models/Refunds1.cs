using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Settings for refunds.
/// </summary>
public record Refunds1
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("referenced")]
    public Referenced? Referenced { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("unreferenced")]
    public Unreferenced? Unreferenced { get; init; }
}
