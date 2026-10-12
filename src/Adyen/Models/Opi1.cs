using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Settings for an Oracle Payment Interface (OPI) integration.
/// </summary>
public record Opi1
{
    /// <summary>
    /// Indicates if Pay at table is enabled.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enablePayAtTable")]
    public bool? EnablePayAtTable { get; init; }

    /// <summary>
    /// The store number to use for Pay at Table.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payAtTableStoreNumber")]
    public string? PayAtTableStoreNumber { get; init; }

    /// <summary>
    /// The URL and port number used for Pay at Table communication.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payAtTableURL")]
    public string? PayAtTableUrl { get; init; }
}
