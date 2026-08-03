using System.Text.Json.Serialization;

namespace Adyen.Models;

public record TaxTotal
{
    /// <summary>
    /// The transaction amount used as a base for the cost estimation.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amount")]
    public Amount2? Amount { get; init; }
}
