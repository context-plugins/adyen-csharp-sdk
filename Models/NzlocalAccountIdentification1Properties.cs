using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record NzlocalAccountIdentification1Properties
{
    /// <summary>
    /// The 15-16 digit bank account number. The first 2 digits are the bank number, the next 4 digits are the branch number, the next 7 digits are the account number, and the final 2-3 digits are the suffix.
    /// </summary>
    [JsonPropertyName("accountNumber")]
    [StringLength(16, MinimumLength = 15)]
    public required string AccountNumber { get; init; }

    /// <summary>
    /// <b>nzLocal</b>
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; init; }
}
