using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record HuLocalAccountIdentification1Properties
{
    /// <summary>
    /// The 24-digit bank account number, without separators or whitespace.
    /// </summary>
    [JsonPropertyName("accountNumber")]
    [StringLength(24, MinimumLength = 24)]
    public required string AccountNumber { get; init; }

    /// <summary>
    /// <b>huLocal</b>
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; init; } = "huLocal";
}
