using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

/// <summary>
/// Contains redirection URLs to guide the user to the appropriate page, after a successful payment or a cancellation.
/// </summary>
public record Links11
{
    /// <summary>
    /// The URL to where the user must be redirected after a payment has been canceled.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cancel")]
    public Href6? Cancel { get; init; }

    /// <summary>
    /// The URL to where the user must be redirected after a successful payment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("success")]
    public Href1? Success { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
