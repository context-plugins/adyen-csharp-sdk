using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Content of the TransactionStatus Response message.
/// It conveys Information related to the status of the last or current Payment, Loyalty or Reversal transaction.
/// </summary>
public record TransactionStatusResponse
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
