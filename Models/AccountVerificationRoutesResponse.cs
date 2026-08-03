using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record AccountVerificationRoutesResponse
{
    /// <summary>
    /// This array lists available open banking redirection links, each with its associated provider metadata.
    /// </summary>
    [JsonPropertyName("routes")]
    public required IReadOnlyList<Route> Routes { get; init; }
}
