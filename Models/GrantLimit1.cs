using System.Text.Json.Serialization;

namespace Adyen.Models;

public record GrantLimit1
{
    /// <summary>
    /// The limit amount of the grant account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amount")]
    public Amount17? Amount { get; init; }
}
