using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// <b>paypal</b> details
/// </summary>
public record PayPalResponseInfo1
{
    /// <summary>
    /// Indicates if direct (immediate) capture for PayPal is enabled. If set to <b>true</b>, this setting overrides the <see href="https://docs.adyen.com/online-payments/capture">capture</see> settings of your merchant account. Default value: <b>true</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("directCapture")]
    public bool? DirectCapture { get; init; }

    /// <summary>
    /// PayPal Merchant ID. Character length and limitations: 13 single-byte alphanumeric characters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payerId")]
    [StringLength(13, MinimumLength = 13)]
    public string? PayerId { get; init; }

    /// <summary>
    /// Your business email address.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subject")]
    public string? Subject { get; init; }
}
