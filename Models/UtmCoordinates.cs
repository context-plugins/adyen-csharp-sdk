using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

public record UtmCoordinates
{
    /// <summary>
    /// UTM grid zone combination of the longitude zone (1 to 60) and the latitude band (C to X, excluding I and O).
    /// </summary>
    [JsonPropertyName("UTMZone")]
    [RegularExpression("^.+$")]
    public required string UtmZone { get; init; }

    /// <summary>
    /// X-coordinate of the Universal Transverse Mercator coordinate system.
    /// </summary>
    [JsonPropertyName("UTMEastward")]
    [RegularExpression("^.+$")]
    public required string UtmEastward { get; init; }

    /// <summary>
    /// Y-coordinate of the Universal Transverse Mercator coordinate system.
    /// </summary>
    [JsonPropertyName("UTMNorthward")]
    [RegularExpression("^.+$")]
    public required string UtmNorthward { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
