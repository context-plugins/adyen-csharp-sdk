using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Content of the requested Message Response.
/// If Result is Success (process completed).
/// </summary>
public record RepeatedMessageResponse2
{
    [JsonPropertyName("MessageHeader")]
    public required MessageHeader1 MessageHeader { get; init; }

    [JsonPropertyName("RepeatedResponseMessageBody")]
    public required RepeatedResponseMessageBody RepeatedResponseMessageBody { get; init; }
}
