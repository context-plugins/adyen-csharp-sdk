using System.Text.Json.Serialization;

namespace Adyen.Models;

public record GrantLimit
{
    /// <summary>
    /// The amount available on the grant account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amount")]
    public Amount17? Amount { get; init; }
}
