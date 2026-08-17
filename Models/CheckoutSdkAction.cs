using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record CheckoutSdkAction
{
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
    /// The data to pass to the SDK.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sdkData")]
    public IReadOnlyDictionary<string, string>? SdkData { get; init; }

    /// <summary>
    /// The type of the action.
    /// </summary>
    [JsonPropertyName("type")]
    public required Type19 Type { get; init; }

    /// <summary>
    /// Specifies the URL to redirect to.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("url")]
    public string? Url { get; init; }
}
