using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record SglocalAccountIdentification
{
    /// <summary>
    /// The 4- to 19-digit bank account number, without separators or whitespace.
    /// </summary>
    [JsonPropertyName("accountNumber")]
    [StringLength(19, MinimumLength = 4)]
    public required string AccountNumber { get; init; }

    /// <summary>
    /// The bank's 8- or 11-character BIC or SWIFT code.
    /// </summary>
    [JsonPropertyName("bic")]
    [StringLength(11, MinimumLength = 8)]
    public required string Bic { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public Type8? Type { get; init; }
}
