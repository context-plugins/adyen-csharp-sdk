using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// It conveys the result of the Logout.
/// Content of the Logout Response message.
/// </summary>
public record LogoutResponse
{
    /// <summary>
    /// Result of a message request processing.
    /// </summary>
    [JsonPropertyName("Response")]
    public required Response11 Response { get; init; }
}
