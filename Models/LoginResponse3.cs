using System.Text.Json.Serialization;

namespace Adyen.Models;

public record LoginResponse3
{
    [JsonPropertyName("Response")]
    public required Response3 Response { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("POISystemData")]
    public PoisystemData? PoisystemData { get; init; }

    /// <summary>
    /// If token is managed by the POI, the status of the token request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("TokenRequestStatus")]
    public bool? TokenRequestStatus { get; init; }
}
