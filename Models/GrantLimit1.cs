using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

public record GrantLimit1
{
    /// <summary>
    /// The limit amount of the grant account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amount")]
    public Amount17? Amount { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
