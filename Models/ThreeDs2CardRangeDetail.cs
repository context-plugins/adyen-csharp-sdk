using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record ThreeDs2CardRangeDetail
{
    /// <summary>
    /// Provides additional information to the 3DS Server.
    /// Possible values:
    /// - 01 (Authentication is available at ACS)
    /// - 02 (Attempts supported by ACS or DS)
    /// - 03 (Decoupled authentication supported)
    /// - 04 (Whitelisting supported)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("acsInfoInd")]
    public IReadOnlyList<string>? AcsInfoInd { get; init; }

    /// <summary>
    /// Card brand.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("brandCode")]
    public string? BrandCode { get; init; }

    /// <summary>
    /// BIN end range.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("endRange")]
    public string? EndRange { get; init; }

    /// <summary>
    /// BIN start range.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("startRange")]
    public string? StartRange { get; init; }

    /// <summary>
    /// Supported 3D Secure protocol versions
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threeDS2Versions")]
    public IReadOnlyList<string>? ThreeDs2Versions { get; init; }

    /// <summary>
    /// In a 3D Secure 2 browser-based flow, this is the URL where you should send the device fingerprint to.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threeDSMethodURL")]
    public string? ThreeDsmethodUrl { get; init; }
}
