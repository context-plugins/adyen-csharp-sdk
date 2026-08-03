using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.AnyOf;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// Action to be taken for completing the payment.
/// </summary>
public record PaymentResponse9
{
    /// <summary>
    /// Action to be taken for completing the payment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("action")]
    public Action4? Action { get; init; }

    /// <summary>
    /// Contains additional information about the payment. Some data fields are included only if you select them first: Go to <b>Customer Area</b> &gt; <b>Developers</b> &gt; <b>Additional data</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("additionalData")]
    public IReadOnlyDictionary<string, string>? AdditionalData { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amount")]
    public Amount16? Amount { get; init; }

    /// <summary>
    /// Donation Token containing payment details for Adyen Giving.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("donationToken")]
    public string? DonationToken { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fraudResult")]
    public FraudResult? FraudResult { get; init; }

    /// <summary>
    /// The reference to uniquely identify a payment. This reference is used in all communication with you about the payment status. We recommend using a unique value per payment; however, it is not a requirement.
    /// If you need to provide multiple references for a transaction, separate them with hyphens ("-").
    /// Maximum length: 80 characters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantReference")]
    public string? MerchantReference { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("order")]
    public CheckoutOrderResponse? Order { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paymentMethod")]
    public PaymentResponse8? PaymentMethod { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paymentValidations")]
    public PaymentResponse7? PaymentValidations { get; init; }

    /// <summary>
    /// Adyen's 16-character string reference associated with the transaction/request. This value is globally unique; quote it when communicating with us about this request.
    /// <para>
    /// &gt; For payment methods that require a redirect or additional action, you will get this value in the <c>/payments/details</c> response.
    /// </para>
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

    /// <summary>
    /// Code that specifies the refusal reason. For more information, see <see href="https://docs.adyen.com/development-resources/refusal-reasons">Authorisation refusal reasons</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("refusalReasonCode")]
    public string? RefusalReasonCode { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("resultCode")]
    public ResultCode1? ResultCode { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threeDS2ResponseData")]
    public ThreeDs2ResponseData? ThreeDs2ResponseData { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threeDS2Result")]
    public ThreeDs2Result2? ThreeDs2Result { get; init; }

    /// <summary>
    /// When non-empty, contains a value that you must submit to the <c>/payments/details</c> endpoint as <c>paymentData</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threeDSPaymentData")]
    public string? ThreeDspaymentData { get; init; }
}
