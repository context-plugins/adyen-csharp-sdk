using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Content of the Login Response message.
/// </summary>
public record LoginResponse2
{
    /// <summary>
    /// Result of a message request processing.
    /// </summary>
    [JsonPropertyName("Response")]
    public required Response11 Response { get; init; }

    /// <summary>
    /// Information related to the POI System.
    /// Returned if the response result is Success.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("POISystemData")]
    public PoiSystemData1? PoiSystemData { get; init; }

    /// <summary>
    /// If token is managed by the POI, the status of the token request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("TokenRequestStatus")]
    public bool? TokenRequestStatus { get; init; }
}
