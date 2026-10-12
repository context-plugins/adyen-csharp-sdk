using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

/// <summary>
/// A short-lived URL that redirects the user to the iDEAL profile registration page.
/// </summary>
public record Href5
{
    /// <summary>
    /// The full URL for the redirection.
    /// </summary>
    [JsonPropertyName("href")]
    public required string Href { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
