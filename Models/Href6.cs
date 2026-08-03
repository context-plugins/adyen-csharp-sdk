using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// The URL to where the user must be redirected after a payment has been canceled.
/// </summary>
public record Href6
{
    /// <summary>
    /// The full URL for the redirection.
    /// </summary>
    [JsonPropertyName("href")]
    public required string Href { get; init; }
}
