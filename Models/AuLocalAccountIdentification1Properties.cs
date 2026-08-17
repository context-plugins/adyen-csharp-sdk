using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record AuLocalAccountIdentification1Properties
{
    /// <summary>
    /// The bank account number, without separators or whitespace.
    /// </summary>
    [JsonPropertyName("accountNumber")]
    [StringLength(9, MinimumLength = 5)]
    public required string AccountNumber { get; init; }

    /// <summary>
    /// The 6-digit <see href="https://en.wikipedia.org/wiki/Bank_state_branch">Bank State Branch (BSB) code</see>, without separators or whitespace.
    /// </summary>
    [JsonPropertyName("bsbCode")]
    [StringLength(6, MinimumLength = 6)]
    public required string BsbCode { get; init; }

    /// <summary>
    /// <b>auLocal</b>
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; init; } = "auLocal";
}
