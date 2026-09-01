using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Core.Models;
using Adyen.Core.Validation.Attributes;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// Magnetic track or magnetic ink characters line.
/// Mandatory if CheckNumber absent.
/// </summary>
public record TrackData1
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
