using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// Identification of a Loyalty account.
/// In the Payment Request message, it allows to identify the loyalty account by the Sale Terminal instead of the POI Terminal (e.g. because the account identification is a bar-code read by the Cashier on a scanner device).
/// </summary>
public record LoyaltyAccountId
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

    [JsonPropertyName("IdentificationType")]
    public required IdentificationType11 IdentificationType { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("IdentificationSupport")]
    public IdentificationSupport1? IdentificationSupport { get; init; }

    /// <summary>
    /// Loyalty account identification conforming to the IdentificationType.
    /// </summary>
    [JsonPropertyName("LoyaltyID")]
    public required string LoyaltyId { get; init; }
}
