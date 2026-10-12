using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Use this collection to submit the details that were returned as a result of the <c>/payments</c> call.
/// </summary>
public record PaymentCompletionDetails1
{
    /// <summary>
    /// A payment session identifier returned by the card issuer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("MD")]
    [MaxLength(20000)]
    public string? Md { get; init; }

    /// <summary>
    /// (3D) Payment Authentication Request data for the card issuer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("PaReq")]
    [MaxLength(20000)]
    public string? PaReq { get; init; }

    /// <summary>
    /// (3D) Payment Authentication Response data by the card issuer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("PaRes")]
    [MaxLength(20000)]
    public string? PaRes { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("authorization_token")]
    public string? AuthorizationToken { get; init; }

    /// <summary>
    /// PayPal-generated token for recurring payments.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("billingToken")]
    public string? BillingToken { get; init; }

    /// <summary>
    /// The SMS verification code collected from the shopper.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cupsecureplus.smscode")]
    public string? CupsecureplusSmscode { get; init; }

    /// <summary>
    /// PayPal-generated third party access token.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("facilitatorAccessToken")]
    public string? FacilitatorAccessToken { get; init; }

    /// <summary>
    /// A random number sent to the mobile phone number of the shopper to verify the payment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("oneTimePasscode")]
    public string? OneTimePasscode { get; init; }

    /// <summary>
    /// PayPal-assigned ID for the order.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("orderID")]
    public string? OrderId { get; init; }

    /// <summary>
    /// PayPal-assigned ID for the payer (shopper).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payerID")]
    public string? PayerId { get; init; }

    /// <summary>
    /// Payload appended to the <c>returnURL</c> as a result of the redirect.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payload")]
    [MaxLength(20000)]
    public string? Payload { get; init; }

    /// <summary>
    /// PayPal-generated ID for the payment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paymentID")]
    public string? PaymentId { get; init; }

    /// <summary>
    /// Value passed from the WeChat MiniProgram <c>wx.requestPayment</c> <b>complete</b> callback. Possible values: any value starting with <c>requestPayment:</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paymentStatus")]
    public string? PaymentStatus { get; init; }

    /// <summary>
    /// The result of the redirect as appended to the <c>returnURL</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("redirectResult")]
    [MaxLength(20000)]
    public string? RedirectResult { get; init; }

    /// <summary>
    /// Value you received from the WeChat Pay SDK.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("resultCode")]
    public string? ResultCode { get; init; }

    /// <summary>
    /// The query string as appended to the <c>returnURL</c> when using direct issuer links .
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("returnUrlQueryString")]
    [MaxLength(20000)]
    public string? ReturnUrlQueryString { get; init; }

    /// <summary>
    /// Base64-encoded string returned by the Component after the challenge flow. It contains the following parameters: <c>transStatus</c>, <c>authorisationToken</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threeDSResult")]
    [MaxLength(50000)]
    public string? ThreeDsResult { get; init; }

    /// <summary>
    /// Base64-encoded string returned by the Component after the challenge flow. It contains the following parameter: <c>transStatus</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threeds2.challengeResult")]
    [MaxLength(50000)]
    public string? Threeds2ChallengeResult { get; init; }

    /// <summary>
    /// Base64-encoded string returned by the Component after the challenge flow. It contains the following parameter: <c>threeDSCompInd</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threeds2.fingerprint")]
    [MaxLength(100000)]
    public string? Threeds2Fingerprint { get; init; }

    /// <summary>
    /// PayPalv2-generated token for recurring payments.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("vaultToken")]
    public string? VaultToken { get; init; }
}
