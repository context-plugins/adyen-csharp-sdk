using System.Text.Json.Serialization;

namespace Adyen.Models;

public record AmountMinMaxRequirement
{
    /// <summary>
    /// Specifies the eligible amounts for a particular route.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// Maximum amount.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("max")]
    public long? Max { get; init; }

    /// <summary>
    /// Minimum amount.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("min")]
    public long? Min { get; init; }

    /// <summary>
    /// <b>amountMinMaxRequirement</b>
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; } = "amountMinMaxRequirement";
}
