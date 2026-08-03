using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// It conveys the result of the print, parallel to the message request, except if response not required and absent.
/// Content of the Print Response message.
/// </summary>
public record PrintResponse
{
    [JsonPropertyName("DocumentQualifier")]
    public required DocumentQualifier2 DocumentQualifier { get; init; }

    [JsonPropertyName("Response")]
    public required Response3 Response { get; init; }
}
