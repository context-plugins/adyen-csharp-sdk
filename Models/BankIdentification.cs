using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record BankIdentification
{
    /// <summary>
    /// Two-character <see href="https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2">ISO 3166-1 alpha-2</see> country code.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("country")]
    public string? Country { get; init; }

    /// <summary>
    /// The bank identification code.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("identification")]
    public string? Identification { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("identificationType")]
    public IdentificationType? IdentificationType { get; init; }
}
