using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Content of the Login Response message.
/// </summary>
public record LoginResponse2
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
