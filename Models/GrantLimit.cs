using System.Text.Json.Serialization;

namespace Adyen.Models;

public record GrantLimit
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amount")]
    public Amount5? Amount { get; init; }
}
