using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

public record TopUpAmount
{
    /// <summary>
    /// The fixed amount with which you want to top up the balance account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fixed")]
    public Amount17? Fixed { get; init; }

    /// <summary>
    /// The target balance for the balance account that the top-up must achieve.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("target")]
    public Amount17? Target { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
