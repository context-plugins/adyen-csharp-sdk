using System.Text.Json.Serialization;

namespace Adyen.Models;

public record Refunds
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("referenced")]
    public Referenced? Referenced { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("unreferenced")]
    public Unreferenced? Unreferenced { get; init; }
}
