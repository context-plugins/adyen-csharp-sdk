using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record CheckoutDelegatedAuthenticationAction
{
    /// <summary>
    /// A token needed to authorise a payment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("authorisationToken")]
    public string? AuthorisationToken { get; init; }

    /// <summary>
    /// Encoded payment data.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paymentData")]
    public string? PaymentData { get; init; }

    /// <summary>
    /// Specifies the payment method.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paymentMethodType")]
    public string? PaymentMethodType { get; init; }

    /// <summary>
    /// A token to pass to the delegatedAuthentication component.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("token")]
    public string? Token { get; init; }

    /// <summary>
    /// <b>delegatedAuthentication</b>
    /// </summary>
    [JsonPropertyName("type")]
    public required Type543 Type { get; init; }

    /// <summary>
    /// Specifies the URL to redirect to.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("url")]
    public string? Url { get; init; }
}
