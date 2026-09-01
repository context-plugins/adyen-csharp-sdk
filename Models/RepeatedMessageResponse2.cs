using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

/// <summary>
/// Content of the requested Message Response.
/// If Result is Success (process completed).
/// </summary>
public record RepeatedMessageResponse2
{
    /// <summary>
    /// Message header of the Sale to POI protocol message.
    /// It conveys Information related to the Sale to POI protocol management.
    /// </summary>
    [JsonPropertyName("MessageHeader")]
    public required MessageHeader MessageHeader { get; init; }

    [JsonPropertyName("RepeatedResponseMessageBody")]
    public required RepeatedResponseMessageBody RepeatedResponseMessageBody { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
