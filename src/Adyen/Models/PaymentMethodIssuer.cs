using System.Text.Json.Serialization;

namespace Adyen.Models;

public record PaymentMethodIssuer
{
    /// <summary>
    /// A boolean value indicating whether this issuer is unavailable. Can be <c>true</c> whenever the issuer is offline.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; init; } = false;

    /// <summary>
    /// The unique identifier of this issuer, to submit in requests to /payments.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// A localized name of the issuer.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }
}
