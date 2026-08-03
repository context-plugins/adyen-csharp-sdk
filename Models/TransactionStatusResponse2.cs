using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Content of the TransactionStatus Response message.
/// </summary>
public record TransactionStatusResponse2
{
    [JsonPropertyName("Response")]
    public required Response3 Response { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("MessageReference")]
    public MessageReference1? MessageReference { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("RepeatedMessageResponse")]
    public RepeatedMessageResponse? RepeatedMessageResponse { get; init; }
}
