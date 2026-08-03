using System.Text.Json.Serialization;

namespace Adyen.Models;

public record ThreeDsecure
{
    /// <summary>
    /// The transaction identifier for the Access Control Server
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("acsTransactionId")]
    public string? AcsTransactionId { get; init; }
}
