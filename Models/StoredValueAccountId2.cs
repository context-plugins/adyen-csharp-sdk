using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Core.Validation.Attributes;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record StoredValueAccountId2
{
    [JsonPropertyName("StoredValueAccountType")]
    public required StoredValueAccountType1 StoredValueAccountType { get; init; }

    /// <summary>
    /// Identification of the provider of the stored value account load/reload. When the ProductCode is not sufficient to identify the provider host which delivers the load or reload of the stored value account (for example if it contains the identification of the application.)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("StoredValueProvider")]
    [RegularExpression("^.+$")]
    public string? StoredValueProvider { get; init; }

    /// <summary>
    /// Name of the owner of a stored value account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("OwnerName")]
    [RegularExpression("^.+$")]
    public string? OwnerName { get; init; }

    /// <summary>
    /// Date after which the card cannot be used. If EMV expiry date is present, it overrides Track2 information. Format is MMYY.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ExpiryDate")]
    [Minimum(4)]
    [Maximum(4)]
    public int? ExpiryDate { get; init; }

    /// <summary>
    /// Entry mode of the payment instrument information. In the Payment, Loyalty, or StoredValue Request messages, it informs the POI System the entry mode of the payment instrument information when read by the Sale Terminal. (e.g. because the payment instrument information are a barcode read by the Cashier on a scanner device).
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

    /// <summary>
    /// Stored value account identification. The identification of the stored value account conforming to the IdentificationType.
    /// </summary>
    [JsonPropertyName("StoredValueID")]
    [RegularExpression("^.+$")]
    public required string StoredValueId { get; init; }
}
