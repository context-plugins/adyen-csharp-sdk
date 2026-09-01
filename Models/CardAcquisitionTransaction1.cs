using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Core.Models;
using Adyen.Core.Validation.Attributes;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// Data related to the payment and loyalty card acquisition.
/// </summary>
public record CardAcquisitionTransaction1
{
    /// <summary>
    /// Card payment brands allowed by the Sale System for the payment transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("AllowedPaymentBrand")]
    public IReadOnlyList<string>? AllowedPaymentBrand { get; init; }

    /// <summary>
    /// Loyalty brands or programs allowed by the Sale System for the loyalty transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("AllowedLoyaltyBrand")]
    public IReadOnlyList<string>? AllowedLoyaltyBrand { get; init; }

    /// <summary>
    /// Type of Loyalty processing requested by the Sale System. An way to specify what the POI has to handle concerning the loyalty.
    /// Possible values:
    /// * <b>Allowed</b>
    /// * <b>Forbidden</b>
    /// * <b>Processed</b>
    /// * <b>Proposed</b>
    /// * <b>Required</b>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("LoyaltyHandling")]
    public LoyaltyHandling2? LoyaltyHandling { get; init; }

    /// <summary>
    /// The language used on the terminal screen or in text printed by the terminal.
    ///   Typical use case is setting the language on unattended terminals. Format: two-character <see href="https://en.wikipedia.org/wiki/List_of_ISO_639_language_codes">ISO 639:2023</see> format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("CustomerLanguage")]
    [RegularExpression("^[a-z]{2,2}$")]
    public string? CustomerLanguage { get; init; }

    /// <summary>
    /// Payment instrument entry mode requested by the Sale System. Avoid retry on an out of order card reading device, when the sale system knows that some card entry modes on the POI do not work.
    /// Possible values:
    /// * <b>CheckReader</b>
    /// * <b>Contactless</b>
    /// * <b>File</b>
    /// * <b>ICC</b>
    /// * <b>Keyed</b>
    /// * <b>MagStripe</b>
    /// * <b>Manual</b>
    /// * <b>RFID</b>
    /// * <b>Scanned</b>
    /// * <b>SynchronousICC</b>
    /// * <b>Tapped</b>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ForceEntryMode")]
    public IReadOnlyList<ForceEntryMode>? ForceEntryMode { get; init; }

    /// <summary>
    /// Indicates if the Customer realises the selection of the card application.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ForceCustomerSelectionFlag")]
    public bool? ForceCustomerSelectionFlag { get; init; }

    /// <summary>
    /// Amount of a transaction. In the Card Acquisition Request message, it allows the processing of a contactless card.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("TotalAmount")]
    [Minimum(0.0)]
    [Maximum(99999999.999999)]
    public double? TotalAmount { get; init; }

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
    /// Cash back has been requested with the payment transaction. Allows choice of the Customer language when the POI displays messages or print text to Merchant interface.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("CashBackFlag")]
    public bool? CashBackFlag { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
