using System.Text.Json.Serialization;

namespace Adyen.Models;

public record CancelPaymentResponse
{
    /// <summary>
    /// Contains redirection URLs to guide the user to the appropriate page, after a successful payment or a cancellation.
    /// </summary>
    [JsonPropertyName("links")]
    public required Links11 Links { get; init; }
}
