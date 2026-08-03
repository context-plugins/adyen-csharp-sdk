using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Numeric value of a handwritten signature. Contains the value of a handwritten signature, e.g. the signature of a cardholder on the merchant payment receipt. Only one format of the signature is allowed:
///   * The size of the pad area where the signature is written, given with the maximum abscissa and ordinate values.
///   * The sequence of coordinates where the pen changes direction or lift.
/// </summary>
public record CapturedSignature1
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
