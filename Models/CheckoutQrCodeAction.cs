using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record CheckoutQrCodeAction
{
    /// <summary>
    /// Expiry time of the QR code.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expiresAt")]
    public string? ExpiresAt { get; init; }

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
    /// The contents of the QR code as a UTF8 string.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("qrCodeData")]
    public string? QrCodeData { get; init; }

    /// <summary>
    /// <b>qrCode</b>
    /// </summary>
    [JsonPropertyName("type")]
    public required Type563 Type { get; init; }

    /// <summary>
    /// Specifies the URL to redirect to.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("url")]
    public string? Url { get; init; }
}
