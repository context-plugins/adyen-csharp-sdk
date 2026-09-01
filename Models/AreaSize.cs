using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

public record AreaSize
{
    /// <summary>
    /// Abscissa of a point coordinates. The hexadecimal value in text of the abscissa of the coordinates of a point. Leading zero can be removed (e.g. 3BC, 0, and 1287).
    /// </summary>
    [JsonPropertyName("X")]
    public required string X { get; init; }

    /// <summary>
    /// Ordinate of a point coordinates. The hexadecimal value in text of the ordinate of the coordinates of a point. Leading zero can be removed (e.g. 3BC, 0, and 1287).
    /// </summary>
    [JsonPropertyName("Y")]
    public required string Y { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
