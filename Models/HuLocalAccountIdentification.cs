using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

public record HuLocalAccountIdentification
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
    public string Type { get; } = "huLocal";

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
