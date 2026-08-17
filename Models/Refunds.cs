using System.Text.Json.Serialization;

namespace Adyen.Models;

public record Refunds
{
    /// <summary>
    /// Settings for referenced refunds.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("referenced")]
    public Referenced1? Referenced { get; init; }

    /// <summary>
    /// Settings for unreferenced refunds.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("unreferenced")]
    public Unreferenced2? Unreferenced { get; init; }
}
