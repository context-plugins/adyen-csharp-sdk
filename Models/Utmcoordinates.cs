using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record Utmcoordinates
{
    /// <summary>
    /// UTM grid zone combination of the longitude zone (1 to 60) and the latitude band (C to X, excluding I and O).
    /// </summary>
    [JsonPropertyName("UTMZone")]
    [RegularExpression("^.+$")]
    public required string Utmzone { get; init; }

    /// <summary>
    /// X-coordinate of the Universal Transverse Mercator coordinate system.
    /// </summary>
    [JsonPropertyName("UTMEastward")]
    [RegularExpression("^.+$")]
    public required string Utmeastward { get; init; }

    /// <summary>
    /// Y-coordinate of the Universal Transverse Mercator coordinate system.
    /// </summary>
    [JsonPropertyName("UTMNorthward")]
    [RegularExpression("^.+$")]
    public required string Utmnorthward { get; init; }
}
