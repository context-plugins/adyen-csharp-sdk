using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record ThreeDsavailabilityResponse
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("binDetails")]
    public BinDetail? BinDetails { get; init; }

    /// <summary>
    /// List of Directory Server (DS) public keys.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dsPublicKeys")]
    public IReadOnlyList<DspublicKeyDetail>? DsPublicKeys { get; init; }

    /// <summary>
    /// Indicator if 3D Secure 1 is supported.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threeDS1Supported")]
    public bool? ThreeDs1Supported { get; init; }

    /// <summary>
    /// List of brand and card range pairs.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threeDS2CardRangeDetails")]
    public IReadOnlyList<ThreeDs2CardRangeDetail>? ThreeDs2CardRangeDetails { get; init; }

    /// <summary>
    /// Indicator if 3D Secure 2 is supported.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threeDS2supported")]
    public bool? ThreeDs2Supported { get; init; }
}
