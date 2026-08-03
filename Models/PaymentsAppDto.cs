using System.Text.Json.Serialization;

namespace Adyen.Models;

public record PaymentsAppDto
{
    /// <summary>
    /// The unique identifier of the Payments App instance.
    /// </summary>
    [JsonPropertyName("installationId")]
    public required string InstallationId { get; init; }

    /// <summary>
    /// The account code associated with the Payments App instance.
    /// </summary>
    [JsonPropertyName("merchantAccountCode")]
    public required string MerchantAccountCode { get; init; }

    /// <summary>
    /// The store code associated with the Payments App instance.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantStoreCode")]
    public string? MerchantStoreCode { get; init; }

    /// <summary>
    /// The status of the Payments App instance.
    /// </summary>
    [JsonPropertyName("status")]
    public required string Status { get; init; }
}
