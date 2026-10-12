using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

public record UkLocalAccountIdentification1Properties
{
    /// <summary>
    /// The 8-digit bank account number, without separators or whitespace.
    /// </summary>
    [JsonPropertyName("accountNumber")]
    [StringLength(8, MinimumLength = 8)]
    public required string AccountNumber { get; init; }

    /// <summary>
    /// The 6-digit <see href="https://en.wikipedia.org/wiki/Sort_code">sort code</see>, without separators or whitespace.
    /// </summary>
    [JsonPropertyName("sortCode")]
    [StringLength(6, MinimumLength = 6)]
    public required string SortCode { get; init; }

    /// <summary>
    /// <b>ukLocal</b>
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; init; } = "ukLocal";

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
