using System.Text.Json.Serialization;

namespace Adyen.Models;

public record MerchantAcquirerPair
{
    /// <summary>
    /// The acquirer ID.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("acquirerId")]
    public string? AcquirerId { get; init; }

    /// <summary>
    /// The merchant identification number (MID).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantId")]
    public string? MerchantId { get; init; }
}
