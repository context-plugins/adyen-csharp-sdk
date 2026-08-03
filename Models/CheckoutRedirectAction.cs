using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record CheckoutRedirectAction
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
    /// Specifies the payment method.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paymentMethodType")]
    public string? PaymentMethodType { get; init; }

    /// <summary>
    /// <b>redirect</b>
    /// </summary>
    [JsonPropertyName("type")]
    public required Type573 Type { get; init; }

    /// <summary>
    /// Specifies the URL to redirect to.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("url")]
    public string? Url { get; init; }
}
