using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record PaymentDetailsRequest1
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("authenticationData")]
    public DetailsRequestAuthenticationData? AuthenticationData { get; init; }

    [JsonPropertyName("details")]
    public required PaymentCompletionDetails Details { get; init; }

    /// <summary>
    /// Encoded payment data. For <see href="https://docs.adyen.com/online-payments/3d-secure/other-3ds-flows/authentication-only/#authorise-the-payment-with-adyen">authorizing a payment after using 3D Secure 2 Authentication-only</see>:
    /// <para>
    /// If you received <c>resultCode</c>: <b>AuthenticationNotRequired</b> in the <c>/payments</c> response, use the <c>threeDSPaymentData</c> from the same response.
    /// </para>
    /// <para>
    /// If you received <c>resultCode</c>: <b>AuthenticationFinished</b> in the <c>/payments</c> response, use the <c>action.paymentData</c> from the same response.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paymentData")]
    [MaxLength(200000)]
    public string? PaymentData { get; init; }

    /// <summary>
    /// Change the <c>authenticationOnly</c> indicator originally set in the <c>/payments</c> request. Only needs to be set if you want to modify the value set previously.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threeDSAuthenticationOnly")]
    public bool? ThreeDsauthenticationOnly { get; init; }
}
