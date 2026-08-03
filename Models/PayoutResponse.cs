using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record PayoutResponse
{
    /// <summary>
    /// Contains additional information about the payment. Some data fields are included only if you select them first: Go to <b>Customer Area</b> &gt; <b>Developers</b> &gt; <b>Additional data</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("additionalData")]
    public IReadOnlyDictionary<string, string>? AdditionalData { get; init; }

    /// <summary>
    /// Authorisation code:
    /// * When the payment is authorised successfully, this field holds the authorisation code for the payment.
    /// * When the payment is not authorised, this field is empty.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("authCode")]
    public string? AuthCode { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dccAmount")]
    public DccAmount? DccAmount { get; init; }

    /// <summary>
    /// Cryptographic signature used to verify <c>dccQuote</c>.
    /// &gt; This value only applies if you have implemented Dynamic Currency Conversion. For more information, <see href="https://www.adyen.help/hc/en-us/requests/new">contact Support</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dccSignature")]
    public string? DccSignature { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fraudResult")]
    public FraudResult6? FraudResult { get; init; }

    /// <summary>
    /// The URL to direct the shopper to.
    /// &gt; In case of SecurePlus, do not redirect a shopper to this URL.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("issuerUrl")]
    public string? IssuerUrl { get; init; }

    /// <summary>
    /// The payment session.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("md")]
    [MaxLength(20000)]
    public string? Md { get; init; }

    /// <summary>
    /// The 3D request data for the issuer.
    /// <para>
    /// If the value is <b>CUPSecurePlus-CollectSMSVerificationCode</b>, collect an SMS code from the shopper and pass it in the <c>/authorise3D</c> request. For more information, see <see href="https://docs.adyen.com/classic-integration/3d-secure">3D Secure</see>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paRequest")]
    public string? PaRequest { get; init; }

    /// <summary>
    /// Adyen's 16-character reference associated with the transaction/request. This value is globally unique; quote it when communicating with us about this request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pspReference")]
    public string? PspReference { get; init; }

    /// <summary>
    /// If the payment's authorisation is refused or an error occurs during authorisation, this field holds Adyen's mapped reason for the refusal or a description of the error. When a transaction fails, the authorisation response includes <c>resultCode</c> and <c>refusalReason</c> values.
    /// <para>
    /// For more information, see <see href="https://docs.adyen.com/development-resources/refusal-reasons">Refusal reasons</see>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("refusalReason")]
    public string? RefusalReason { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("resultCode")]
    public ResultCode1? ResultCode { get; init; }
}
