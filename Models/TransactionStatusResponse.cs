using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Content of the TransactionStatus Response message.
/// It conveys Information related to the status of the last or current Payment, Loyalty or Reversal transaction.
/// </summary>
public record TransactionStatusResponse
{
    /// <summary>
    /// Result of a message request processing.
    /// </summary>
    [JsonPropertyName("Response")]
    public required Response11 Response { get; init; }

    /// <summary>
    /// Identification of a previous POI transaction.
    /// If <c>Response.Result</c> is Success.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("MessageReference")]
    public MessageReference3? MessageReference { get; init; }

    /// <summary>
    /// Content of the requested Message Response.
    /// If Result is Success (process completed).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("RepeatedMessageResponse")]
    public RepeatedMessageResponse2? RepeatedMessageResponse { get; init; }
}
