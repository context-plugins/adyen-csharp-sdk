using System.Text.Json.Serialization;

namespace Adyen.Models;

public record ConfirmPaymentResponse
{
    [JsonPropertyName("links")]
    public required Links Links { get; init; }
}
