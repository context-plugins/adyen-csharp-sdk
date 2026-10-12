using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Details to provide if <c>type</c> is <b>paypal</b>.
/// </summary>
public record PayPalInfo1
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
    [JsonPropertyName("payerId")]
    [StringLength(13, MinimumLength = 13)]
    public required string PayerId { get; init; }

    /// <summary>
    /// Your business email address.
    /// </summary>
    [JsonPropertyName("subject")]
    public required string Subject { get; init; }
}
