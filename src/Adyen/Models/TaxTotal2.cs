using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Total tax amount from the order.
/// </summary>
public record TaxTotal2
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amount")]
    public Amount? Amount { get; init; }
}
