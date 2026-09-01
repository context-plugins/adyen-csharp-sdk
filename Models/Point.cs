using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

public record Point
{
    /// <summary>
    /// The hexadecimal value of the coordinates of a point on the abscissa.
    /// </summary>
    [JsonPropertyName("X")]
    public required string X { get; init; }

    /// <summary>
    /// The hexadecimal value of the coordinates of a point on the ordinate.
    /// </summary>
    [JsonPropertyName("Y")]
    public required string Y { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
