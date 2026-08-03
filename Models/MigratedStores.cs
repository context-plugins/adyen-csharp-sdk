using System.Text.Json.Serialization;

namespace Adyen.Models;

public record MigratedStores
{
    /// <summary>
    /// The unique identifier of the business line associated with the migrated account holder in the balance platform.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("businessLineId")]
    public string? BusinessLineId { get; init; }

    /// <summary>
    /// The unique identifier of the store associated with the migrated account holder in the classic integration.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("storeCode")]
    public string? StoreCode { get; init; }

    /// <summary>
    /// The unique identifier of the store associated with the migrated account holder in the balance platform.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("storeId")]
    public string? StoreId { get; init; }

    /// <summary>
    /// Your reference for the store in the classic integration. The <see href="https://ca-test.adyen.com/">Customer Area</see> uses this value for the store description.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("storeReference")]
    public string? StoreReference { get; init; }
}
