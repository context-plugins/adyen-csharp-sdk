using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record HulocalAccountIdentification
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
    public required Type193 Type { get; init; }
}
