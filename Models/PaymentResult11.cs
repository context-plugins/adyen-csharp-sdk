using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// Data related to the result of a processed payment transaction.
/// If one data element is present.
/// </summary>
public record PaymentResult11
{
    /// <summary>
    /// Type of payment transaction. Elements requested by the Sale System that are related to the payment only.
    /// Possible values:
    /// * <b>CashAdvance</b>
    /// * <b>CashDeposit</b>
    /// * <b>Completion</b>
    /// * <b>FirstReservation</b>
    /// * <b>Instalment</b>
    /// * <b>IssuerInstalment</b>
    /// * <b>Normal</b>
    /// * <b>OneTimeReservation</b>
    /// * <b>PaidOut</b>
    /// * <b>Recurring</b>
    /// * <b>Refund</b>
    /// * <b>UpdateReservation</b>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("PaymentType")]
    public PaymentType1? PaymentType { get; init; }

    /// <summary>
    /// Data related to the instrument of payment for the transaction.
    /// Sent in the result of the payment transaction. For a card, it could also be sent in the <c>CardAcquisition</c> response, to be processed by the Sale System.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("PaymentInstrumentData")]
    public PaymentInstrumentData? PaymentInstrumentData { get; init; }

    /// <summary>
    /// Various amounts related to the payment response from the POI System. Amounts approved by the POI and the Acquirer for the payment and loyalty transaction, containing:
    ///   * The authorised amount to be paid.
    ///   * The amount of the rebates.
    ///   * The amount of financial fees.
    ///   * The cash back part of the requested amount for a payment with cash back.
    ///   * The tip part of the requested amount for a payment with tip.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("AmountsResp")]
    public AmountsResp1? AmountsResp { get; init; }

    /// <summary>
    /// Information related an instalment transaction. To request an instalment to the issuer, or to make individual instalments of a payment transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("Instalment")]
    public Instalment1? Instalment { get; init; }

    /// <summary>
    /// Information related to a currency conversion. A currency conversion occurred in the payment, and the merchant needs to know information related to this conversion (e.g. to print on the sale receipt).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("CurrencyConversion")]
    public IReadOnlyList<CurrencyConversion>? CurrencyConversion { get; init; }

    /// <summary>
    /// Indicates that the Merchant forced the result of the payment to successful. Allows the Sale System to be sure that the payment has been forced.
    /// </summary>
    [JsonPropertyName("MerchantOverrideFlag")]
    public bool? MerchantOverrideFlag { get; init; } = false;

    /// <summary>
    /// Numeric value of a handwritten signature. Contains the value of a handwritten signature, e.g. the signature of a cardholder on the merchant payment receipt. Only one format of the signature is allowed:
    ///   * The size of the pad area where the signature is written, given with the maximum abscissa and ordinate values.
    ///   * The sequence of coordinates where the pen changes direction or lift.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("CapturedSignature")]
    public CapturedSignature1? CapturedSignature { get; init; }

    /// <summary>
    /// Numeric value of a handwritten signature. Contains the value of a handwritten signature, e.g. the signature of a cardholder on the merchant payment receipt. The format before encryption is the encoded data structure CapturedSignature. The data structure before encryption includes the start and end tags for an XML encoding, the identifier and length bytes for an ASN.1 encoding, and the complete member ProtectedSignature for a JSON encoding.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ProtectedSignature")]
    public string? ProtectedSignature { get; init; }

    /// <summary>
    /// The language of the customer that was used on the terminal screen or in text printed by the terminal. Format: two-character <see href="https://en.wikipedia.org/wiki/List_of_ISO_639_language_codes">ISO 639:2023</see> format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("CustomerLanguage")]
    [RegularExpression("^[a-z]{2,2}$")]
    public string? CustomerLanguage { get; init; }

    /// <summary>
    /// Indicate that the payment transaction processing has required the approval of a host. Allows the Sale System to know if the payment was online or offline.
    /// </summary>
    [JsonPropertyName("OnlineFlag")]
    public bool? OnlineFlag { get; init; } = true;

    /// <summary>
    /// Method for customer authentication. Allows the Sale System informed about customer authentication for the payment transaction.
    /// Possible values:
    /// * <b>Bypass</b>
    /// * <b>ManualVerification</b>
    /// * <b>MerchantAuthentication</b>
    /// * <b>OfflinePIN</b>
    /// * <b>OnlinePIN</b>
    /// * <b>PaperSignature</b>
    /// * <b>SecureCertificate</b>
    /// * <b>SecureNoCertificate</b>
    /// * <b>SecuredChannel</b>
    /// * <b>SignatureCapture</b>
    /// * <b>UnknownMethod</b>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("AuthenticationMethod")]
    public IReadOnlyList<AuthenticationMethod1>? AuthenticationMethod { get; init; }

    /// <summary>
    /// End of the validity period for the reservation, for the first reservation, and the reservation updates as well.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ValidityDate")]
    public DateTimeOffset? ValidityDate { get; init; }

    /// <summary>
    /// Data related to the response from the payment Acquirer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("PaymentAcquirerData")]
    public PaymentAcquirerData? PaymentAcquirerData { get; init; }
}
