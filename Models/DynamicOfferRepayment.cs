using System.Text.Json.Serialization;

namespace Adyen.Models;

public record DynamicOfferRepayment
{
    [JsonPropertyName("term")]
    public required Term Term { get; init; }
}
