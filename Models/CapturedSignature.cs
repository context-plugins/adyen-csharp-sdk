using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record CapturedSignature
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("AreaSize")]
    public AreaSize? AreaSize { get; init; }

    /// <summary>
    /// Coordinates of a point where the pen changes direction or lift. Contain the Coordinates of a point of the written signature where the pen changes direction or lift where (X and Y). When the signer lifts the pen, both X and Y have the value FFFF.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("SignaturePoint")]
    public IReadOnlyList<Point>? SignaturePoint { get; init; }
}
