using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

public record Fee2
{
    /// <summary>
    /// Contains the amount of the grant fee.
    /// </summary>
    [JsonPropertyName("amount")]
    public required Amount17 Amount { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
