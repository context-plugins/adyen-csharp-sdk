using System.Text.Json.Serialization;

namespace Adyen.Models;

public record PaymentResponse7
{
    /// <summary>
    /// Object that contains the status and outcomes of the <see href="https://docs.adyen.com/payment-methods/cards/name-validation">name validation</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public PaymentValidationsNameResponse2? Name { get; init; }
}
