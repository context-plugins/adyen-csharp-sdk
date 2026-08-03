using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Total tax amount from the order.
/// </summary>
public record TaxTotal2
{
    /// <summary>
    /// The transaction amount used as a base for the cost estimation.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amount")]
    public Amount2? Amount { get; init; }
}
