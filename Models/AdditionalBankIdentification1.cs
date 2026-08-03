using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// Additional identification codes of the bank. Some banks may require these identifiers for cross-border transfers.
/// </summary>
public record AdditionalBankIdentification1
{
    /// <summary>
    /// The value of the additional bank identification.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("code")]
    public string? Code { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public AdditionalBankIdentificationType? Type { get; init; }
}
