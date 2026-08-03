using System.Text.Json.Serialization;

namespace Adyen.Models;

public record RepeatedMessageResponse
{
    [JsonPropertyName("MessageHeader")]
    public required MessageHeader1 MessageHeader { get; init; }

    [JsonPropertyName("RepeatedResponseMessageBody")]
    public required RepeatedResponseMessageBody RepeatedResponseMessageBody { get; init; }
}
