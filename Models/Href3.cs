using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// A short-lived URL that redirects the user to the iDEAL profile management page.
/// </summary>
public record Href3
{
    /// <summary>
    /// The full URL for the redirection.
    /// </summary>
    [JsonPropertyName("href")]
    public required string Href { get; init; }
}
