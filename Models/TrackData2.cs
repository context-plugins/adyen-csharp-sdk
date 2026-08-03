using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Core.Validation.Attributes;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record TrackData2
{
    /// <summary>
    /// Card track number.
    /// </summary>
    [JsonPropertyName("TrackNumb")]
    [Minimum(1)]
    [Maximum(3)]
    public int? TrackNumb { get; init; } = 2;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("TrackFormat")]
    public TrackFormat1? TrackFormat { get; init; }

    /// <summary>
    /// Card track content.
    /// </summary>
    [JsonPropertyName("TrackValue")]
    [RegularExpression("^.{1,104}$")]
    public required string TrackValue { get; init; }
}
