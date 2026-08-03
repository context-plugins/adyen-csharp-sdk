using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record PaymentResult1
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("PaymentType")]
    public PaymentType1? PaymentType { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("PaymentInstrumentData")]
    public PaymentInstrumentData2? PaymentInstrumentData { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("AmountsResp")]
    public AmountsResp? AmountsResp { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("Instalment")]
    public Instalment? Instalment { get; init; }

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

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("CapturedSignature")]
    public CapturedSignature? CapturedSignature { get; init; }

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

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("PaymentAcquirerData")]
    public PaymentAcquirerData1? PaymentAcquirerData { get; init; }
}
