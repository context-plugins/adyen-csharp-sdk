using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// It conveys the result of the Logout.
/// Content of the Logout Response message.
/// </summary>
public record LogoutResponse
{
    [JsonPropertyName("Response")]
    public required Response3 Response { get; init; }
}
