using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record GeographicCoordinates
{
    /// <summary>
    /// Angular distance of a location on the earth south or north of the equator.
    /// </summary>
    [JsonPropertyName("Latitude")]
    [RegularExpression("^.+$")]
    public required string Latitude { get; init; }

    /// <summary>
    /// Angular measurement of the distance of a location on the earth east or west of the Greenwich observatory.
    /// </summary>
    [JsonPropertyName("Longitude")]
    [RegularExpression("^.+$")]
    public required string Longitude { get; init; }
}
