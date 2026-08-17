using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// Identification of a Loyalty account.
/// </summary>
public record LoyaltyAccountId2
{
    /// <summary>
    /// Entry mode of the payment instrument information. In the Payment, Loyalty or StoredValue Request messages, it informs the POI System the entry mode of the payment instrument information when read by the Sale Terminal. In the Payment, Loyalty or StoredValue Response messages, it informs the Sale System the entry mode of the payment instrument.
    /// Possible values:
    /// * <b>Contactless</b>
    /// * <b>File</b>
    /// * <b>ICC</b>
    /// * <b>Keyed</b>
    /// * <b>MagStripe</b>
    /// * <b>Manual</b>
    /// * <b>Mobile</b>
    /// * <b>RFID</b>
    /// * <b>Scanned</b>
    /// * <b>SynchronousICC</b>
    /// * <b>Tapped</b>
    /// </summary>
    [JsonPropertyName("EntryMode")]
    public required IReadOnlyList<EntryMode> EntryMode { get; init; }

    /// <summary>
    /// Type of account identification. In a request message, it informs the POI System the type of the account or card identification, when provided by the Sale Terminal. (e.g. because the card information is a barcode read by the Cashier on a scanner device). In a response message, it informs the Sale System the type of the account or card identification.
    /// Possible values:
    /// * <b>AccountNumber</b>
    /// * <b>BarCode</b>
    /// * <b>ISOTrack2</b>
    /// * <b>PAN</b>
    /// * <b>PhoneNumber</b>
    /// </summary>
    [JsonPropertyName("IdentificationType")]
    public required IdentificationType11 IdentificationType { get; init; }

    /// <summary>
    /// Support of the loyalty account identification. Allows knowing where and how you have found the loyalty account identification.
    /// Possible values:
    /// * <b>HybridCard</b>
    /// * <b>LinkedCard</b>
    /// * <b>LoyaltyCard</b>
    /// * <b>NoCard</b>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("IdentificationSupport")]
    public IdentificationSupport1? IdentificationSupport { get; init; }

    /// <summary>
    /// Loyalty account identification conforming to the IdentificationType.
    /// </summary>
    [JsonPropertyName("LoyaltyID")]
    public required string LoyaltyId { get; init; }
}
