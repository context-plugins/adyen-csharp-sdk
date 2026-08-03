using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// The currency and value to be added to the balance account, specified in minor units. This can be a fixed amount or a target amount.
/// </summary>
public record TopUpAmount1
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fixed")]
    public Fixed? Fixed { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("target")]
    public Target5? Target { get; init; }
}
