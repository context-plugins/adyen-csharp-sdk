using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Content of the Logout Response message.
/// </summary>
public record LogoutResponse2
{
    [JsonPropertyName("Response")]
    public required Response3 Response { get; init; }
}
