using System.Text.Json.Serialization;

namespace Adyen.Models;

public record Name6
{
    /// <summary>
    /// Set to <b>requested</b> to request a <see href="https://docs.adyen.com/payment-methods/cards/name-validation">name validation</see> to verify if the cardholder name provided by the shopper matches the cardholder name on file at the issuing bank.
    /// </summary>
    [JsonPropertyName("status")]
    public required string Status { get; init; }
}
