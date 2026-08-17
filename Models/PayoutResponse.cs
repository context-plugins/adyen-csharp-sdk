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

    /// <summary>
    /// Includes the currency of the conversion and the value of the transaction.
    /// &gt; This value only applies if you have implemented Dynamic Currency Conversion. For more information, <see href="https://www.adyen.help/hc/en-us/requests/new">contact Support</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dccAmount")]
    public Amount? DccAmount { get; init; }

    /// <summary>
    /// Cryptographic signature used to verify <c>dccQuote</c>.
    /// &gt; This value only applies if you have implemented Dynamic Currency Conversion. For more information, <see href="https://www.adyen.help/hc/en-us/requests/new">contact Support</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dccSignature")]
    public string? DccSignature { get; init; }

    /// <summary>
    /// The fraud result properties of the payment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fraudResult")]
    public FraudResult2? FraudResult { get; init; }

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
}
