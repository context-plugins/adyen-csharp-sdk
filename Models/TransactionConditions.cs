using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// Conditions on which the transaction must be processed.
/// </summary>
public record TransactionConditions
{
    /// <summary>
    /// Payment brands accepted for this transaction.
    /// Card payment brands allowed by the Sale System for the payment transaction.
    /// Restrict brand if data sent.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("AllowedPaymentBrand")]
    public IReadOnlyList<string>? AllowedPaymentBrand { get; init; }

    /// <summary>
    /// Identification of the Acquirer.
    /// Restrict to these Acquirer if present.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("AcquirerID")]
    public IReadOnlyList<int>? AcquirerId { get; init; }

    /// <summary>
    /// The preferred type of payment is a debit transaction rather than a credit transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("DebitPreferredFlag")]
    public bool? DebitPreferredFlag { get; init; }

    /// <summary>
    /// Loyalty brands or programs allowed by the Sale System for the loyalty transaction.
    /// Restrict brand if data sent.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("AllowedLoyaltyBrand")]
    public IReadOnlyList<string>? AllowedLoyaltyBrand { get; init; }

    /// <summary>
    /// Type of Loyalty processing requested by the Sale System.
    /// Possible values:
    /// * <b>Allowed</b>
    /// * <b>Forbidden</b>
    /// * <b>Processed</b>
    /// * <b>Proposed</b>
    /// * <b>Required</b>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("LoyaltyHandling")]
    public LoyaltyHandling1? LoyaltyHandling { get; init; }

    /// <summary>
    /// The language used on the terminal screen or in text printed by the terminal.
    /// Typical use case is setting the language on unattended terminals. Format: two-character <see href="https://en.wikipedia.org/wiki/List_of_ISO_639_language_codes">ISO 639:2023</see> format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("CustomerLanguage")]
    [RegularExpression("^[a-z]{2,2}$")]
    public string? CustomerLanguage { get; init; }

    /// <summary>
    /// Indicates if the Cashier requires POI forces online access to the Acquirer.
    /// Go online if data sent.
    /// </summary>
    [JsonPropertyName("ForceOnlineFlag")]
    public bool? ForceOnlineFlag { get; init; } = false;

    /// <summary>
    /// Payment instrument entry mode requested by the Sale System.
    /// Restrict entry mode if sent.
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
    /// The code which identifies the category of the transaction (MCC).
    /// The payment implies a specific MCC.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("MerchantCategoryCode")]
    [RegularExpression("^.{3,4}$")]
    public string? MerchantCategoryCode { get; init; }
}
