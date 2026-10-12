using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// The data of the result from the 3DS authentication.
/// </summary>
public record ThreeDSecure2
{
    /// <summary>
    /// The transaction identifier for the Access Control Server
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("acsTransactionId")]
    public string? AcsTransactionId { get; init; }
}
