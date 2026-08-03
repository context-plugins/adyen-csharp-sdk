using System.Text.Json.Serialization;

namespace Adyen.Models;

public record AssociatedPaymentMethod
{
    /// <summary>
    /// Indicates whether the payment method is enabled (<b>true</b>) or disabled (<b>false</b>).
    /// </summary>
    [JsonPropertyName("enabled")]
    public required bool Enabled { get; init; }

    /// <summary>
    /// The identifier of the payment method.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// Payment method <see href="https://docs.adyen.com/development-resources/paymentmethodvariant#management-api">variant</see>.
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; init; }
}
