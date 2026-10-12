using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record CheckoutNativeRedirectAction
{
    /// <summary>
    /// When the redirect URL must be accessed via POST, use this data to post to the redirect URL.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("data")]
    public IReadOnlyDictionary<string, string>? Data { get; init; }

    /// <summary>
    /// Specifies the HTTP method, for example GET or POST.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("method")]
    public string? Method { get; init; }

    /// <summary>
    /// Native SDK's redirect data containing the direct issuer link and state data that must be submitted to the /v1/nativeRedirect/redirectResult.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("nativeRedirectData")]
    public string? NativeRedirectData { get; init; }

    /// <summary>
    /// Specifies the payment method.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paymentMethodType")]
    public string? PaymentMethodType { get; init; }

    /// <summary>
    /// <b>nativeRedirect</b>
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; } = "nativeRedirect";

    /// <summary>
    /// Specifies the URL to redirect to.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("url")]
    public string? Url { get; init; }
}
