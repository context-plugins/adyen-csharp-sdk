using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Content of the Logout Response message.
/// </summary>
public record LogoutResponse2
{
    /// <summary>
    /// Result of a message request processing.
    /// </summary>
    [JsonPropertyName("Response")]
    public required Response11 Response { get; init; }
}
