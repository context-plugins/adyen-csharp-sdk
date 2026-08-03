using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record IbanAccountIdentificationRequirement
{
    /// <summary>
    /// Specifies the allowed prefixes for the international bank account number as defined in the ISO-13616 standard.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// Contains the list of allowed prefixes for international bank accounts. For example: NL, US, UK.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ibanPrefixes")]
    public IReadOnlyList<string>? IbanPrefixes { get; init; }

    /// <summary>
    /// <b>ibanAccountIdentificationRequirement</b>
    /// </summary>
    [JsonPropertyName("type")]
    public required Type303 Type { get; init; }
}
