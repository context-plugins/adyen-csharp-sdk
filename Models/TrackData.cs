using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Core.Models;
using Adyen.Core.Validation.Attributes;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// Magnetic track or magnetic ink characters line.
/// ISO 7813 - ISO 4909.
/// Generic data structure for a card track, used when the magstripe card reader is located on the Sale Terminal, or for magstripe Card Reader device request. The data structure is also used to store the line at the bottom of a bank check.
/// </summary>
public record TrackData
{
    /// <summary>
    /// Card track number.
    /// </summary>
    [JsonPropertyName("TrackNumb")]
    [Minimum(1)]
    [Maximum(3)]
    public int? TrackNumb { get; init; } = 2;

    /// <summary>
    /// Card track format.
    /// Possible values:
    /// * <b>AAMVA</b>
    /// * <b>ISO</b>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("TrackFormat")]
    public TrackFormat1? TrackFormat { get; init; }

    /// <summary>
    /// Card track content.
    /// </summary>
    [JsonPropertyName("TrackValue")]
    [RegularExpression("^.{1,104}$")]
    public required string TrackValue { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
