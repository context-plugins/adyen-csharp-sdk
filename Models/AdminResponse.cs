using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// It conveys the result of the Custom Admin.
/// Content of the Custom Admin Response message.
/// </summary>
public record AdminResponse
{
    [JsonPropertyName("Response")]
    public required Response3 Response { get; init; }
}
