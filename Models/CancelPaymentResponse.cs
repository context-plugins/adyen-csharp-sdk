using System.Text.Json.Serialization;

namespace Adyen.Models;

public record CancelPaymentResponse
{
    [JsonPropertyName("links")]
    public required Links Links { get; init; }
}
