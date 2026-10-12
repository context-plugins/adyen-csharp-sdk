using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

public record ConfirmPaymentResponse
{
    /// <summary>
    /// Contains redirection URLs to guide the user to the appropriate page, after a successful payment or a cancellation.
    /// </summary>
    [JsonPropertyName("links")]
    public required Links11 Links { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
