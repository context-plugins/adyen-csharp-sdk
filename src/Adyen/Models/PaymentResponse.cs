using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;
using Adyen.Models.OneOf;

namespace Adyen.Models;

public record PaymentResponse
{
    /// <summary>
    /// Action to be taken for completing the payment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("action")]
    public Action11? Action { get; init; }

    /// <summary>
    /// Contains additional information about the payment. Some data fields are included only if you select them first: Go to <b>Customer Area</b> &gt; <b>Developers</b> &gt; <b>Additional data</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("additionalData")]
    public IReadOnlyDictionary<string, string>? AdditionalData { get; init; }

    /// <summary>
    /// Authorised amount in the transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amount")]
    public Amount26? Amount { get; init; }

    /// <summary>
    /// Donation Token containing payment details for Adyen Giving.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("donationToken")]
    public string? DonationToken { get; init; }

    /// <summary>
    /// The fraud result properties of the payment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fraudResult")]
    public FraudResult1? FraudResult { get; init; }

    /// <summary>
    /// The reference to uniquely identify a payment. This reference is used in all communication with you about the payment status. We recommend using a unique value per payment; however, it is not a requirement.
    /// If you need to provide multiple references for a transaction, separate them with hyphens ("-").
    /// Maximum length: 80 characters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantReference")]
    public string? MerchantReference { get; init; }

    /// <summary>
    /// Contains updated information regarding the order in case order information was provided in the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("order")]
    public CheckoutOrderResponse1? Order { get; init; }

    /// <summary>
    /// Details about the payment method used in the transaction.
    /// Only returned if <c>resultCode</c> is <b>Authorised</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paymentMethod")]
    public PaymentResponse1? PaymentMethod { get; init; }

    /// <summary>
    /// The object that contains the validation outcomes.
    /// Only returned if <c>resultCode</c> is <b>Authorised</b> and if you have requested a payment validation in the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paymentValidations")]
    public PaymentResponse2? PaymentValidations { get; init; }

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

    /// <summary>
    /// The result of the payment. For more information, see <see href="https://docs.adyen.com/online-payments/payment-result-codes">Result codes</see>.
    /// <para>
    /// Possible values:
    /// </para>
    /// <para>
    /// * <b>AuthenticationFinished</b> – The payment has been successfully authenticated with 3D Secure 2. Returned for 3D Secure 2 authentication-only transactions.
    /// * <b>AuthenticationNotRequired</b> – The transaction does not require 3D Secure authentication. Returned for <see href="https://docs.adyen.com/online-payments/3d-secure/other-3ds-flows/authentication-only">standalone authentication-only integrations</see>.
    /// * <b>Authorised</b> – The payment was successfully authorised. This state serves as an indicator to proceed with the delivery of goods and services. This is a final state.
    /// * <b>Cancelled</b> – Indicates the payment has been cancelled (either by the shopper or the merchant) before processing was completed. This is a final state.
    /// * <b>ChallengeShopper</b> – The issuer requires further shopper interaction before the payment can be authenticated. Returned for 3D Secure 2 transactions.
    /// * <b>Error</b> – There was an error when the payment was being processed. The reason is given in the <c>refusalReason</c> field. This is a final state.
    /// * <b>IdentifyShopper</b> – The issuer requires the shopper's device fingerprint before the payment can be authenticated. Returned for 3D Secure 2 transactions.
    /// * <b>PartiallyAuthorised</b> – The payment has been authorised for a partial amount.
    /// This happens for card payments when the merchant supports Partial Authorisations and the cardholder has insufficient funds.
    /// * <b>Pending</b> – Indicates that it is not possible to obtain the final status of the payment. This can happen if the systems providing final status information for the payment are unavailable, or if the shopper needs to take further action to complete the payment.
    /// * <b>PresentToShopper</b> – Indicates that the response contains additional information that you need to present to a shopper, so that they can use it to complete a payment.
    /// * <b>Received</b> – Indicates the payment has successfully been received by Adyen, and will be processed. This is the initial state for all payments.
    /// * <b>RedirectShopper</b> – Indicates the shopper should be redirected to an external web page or app to complete the authorisation.
    /// * <b>Refused</b> – Indicates the payment was refused. The reason is given in the <c>refusalReason</c> field. This is a final state.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("resultCode")]
    public ResultCode1? ResultCode { get; init; }

    /// <summary>
    /// Response of the 3D Secure 2 authentication.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threeDS2ResponseData")]
    public ThreeDs2ResponseData1? ThreeDs2ResponseData { get; init; }

    /// <summary>
    /// Result of the 3D Secure 2 authentication.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threeDS2Result")]
    public ThreeDs2Result1? ThreeDs2Result { get; init; }

    /// <summary>
    /// When non-empty, contains a value that you must submit to the <c>/payments/details</c> endpoint as <c>paymentData</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threeDSPaymentData")]
    public string? ThreeDsPaymentData { get; init; }
}
