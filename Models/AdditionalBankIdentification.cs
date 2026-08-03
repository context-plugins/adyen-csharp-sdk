using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record AdditionalBankIdentification
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
