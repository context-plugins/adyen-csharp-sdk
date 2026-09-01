using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Core.Models;
using Adyen.Core.Validation.Attributes;

namespace Adyen.Models;

/// <summary>
/// Sensitive information related to the payment card, entered or read by the Sale System.
/// If structure non empty and unprotected.
/// </summary>
public record SensitiveCardData1
{
    /// <summary>
    /// Primary Account Number.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("PAN")]
    [Minimum(8)]
    [Maximum(28)]
    public int? Pan { get; init; }

    /// <summary>
    /// Card Sequence Number.
    /// If EntryMode is File, Keyed, or Manual.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("CardSeqNumb")]
    [Minimum(2)]
    [Maximum(3)]
    public int? CardSeqNumb { get; init; }

    /// <summary>
    /// Date after which the card cannot be used.
    /// If EntryMode is File.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ExpiryDate")]
    [Minimum(4)]
    [Maximum(4)]
    public int? ExpiryDate { get; init; }

    /// <summary>
    /// Magnetic track or magnetic ink characters line.
    /// If EntryMode is MagStripe or RFID .
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("TrackData")]
    public IReadOnlyList<TrackData>? TrackData { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
