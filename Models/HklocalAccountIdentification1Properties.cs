using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record HklocalAccountIdentification1Properties
{
    /// <summary>
    /// The 9- to 17-digit bank account number, without separators or whitespace. Starts with the 3-digit branch code.
    /// </summary>
    [JsonPropertyName("accountNumber")]
    [StringLength(17, MinimumLength = 9)]
    public required string AccountNumber { get; init; }

    /// <summary>
    /// The 3-digit clearing code, without separators or whitespace.
    /// </summary>
    [JsonPropertyName("clearingCode")]
    [StringLength(3, MinimumLength = 3)]
    public required string ClearingCode { get; init; }

    /// <summary>
    /// <b>hkLocal</b>
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; init; }
}
