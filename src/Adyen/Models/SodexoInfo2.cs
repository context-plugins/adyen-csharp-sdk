using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Details to provide if <c>type</c> is <b>sodexo</b>.
/// </summary>
public record SodexoInfo2
{
    /// <summary>
    /// Sodexo merchantContactPhone
    /// </summary>
    [JsonPropertyName("merchantContactPhone")]
    public required string MerchantContactPhone { get; init; }
}
