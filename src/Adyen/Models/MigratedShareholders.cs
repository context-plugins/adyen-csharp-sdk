using System.Text.Json.Serialization;

namespace Adyen.Models;

public record MigratedShareholders
{
    /// <summary>
    /// The unique identifier of the legal entity of that shareholder in the balance platform.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("legalEntityCode")]
    public string? LegalEntityCode { get; init; }

    /// <summary>
    /// The unique identifier of the account of the migrated shareholder in the classic integration.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shareholderCode")]
    public string? ShareholderCode { get; init; }
}
