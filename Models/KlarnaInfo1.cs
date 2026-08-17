using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// Details to provide if <c>type</c> is <b>klarna</b> or its variant.
/// <para>
/// You can use the following payment method <c>type</c> values for Klarna:
/// * <b>klarna</b>: Klarna Pay Later
/// * <b>klarna_account</b>: Klarna Pay over time
/// * <b>klarna_paynow</b>: Klarna Pay now
/// * <b>klarna_b2b</b>: <see href="https://docs.adyen.com/payment-methods/klarna/billie">Billie via Klarna</see>
/// </para>
/// </summary>
public record KlarnaInfo1
{
    /// <summary>
    /// Indicates the status of <see href="https://docs.adyen.com/online-payments/capture#automatic-capture">Automatic capture</see>. Default value: <b>false</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("autoCapture")]
    public bool? AutoCapture { get; init; }

    /// <summary>
    /// The email address for disputes.
    /// </summary>
    [JsonPropertyName("disputeEmail")]
    public required string DisputeEmail { get; init; }

    /// <summary>
    /// The region of operation. For example, <b>NA</b>, <b>EU</b>, <b>CH</b>, <b>AU</b>.
    /// </summary>
    [JsonPropertyName("region")]
    public required Region Region { get; init; }

    /// <summary>
    /// The email address of merchant support.
    /// </summary>
    [JsonPropertyName("supportEmail")]
    public required string SupportEmail { get; init; }
}
