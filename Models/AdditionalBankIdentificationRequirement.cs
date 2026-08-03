using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record AdditionalBankIdentificationRequirement
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("additionalBankIdentificationType")]
    public AdditionalBankIdentificationType? AdditionalBankIdentificationType { get; init; }

    /// <summary>
    /// The description of the additional bank identification requirement.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// <b>additionalBankIdentificationRequirement</b>
    /// </summary>
    [JsonPropertyName("type")]
    public required Type610 Type { get; init; }
}
