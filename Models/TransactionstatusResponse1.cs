using System.Text.Json.Serialization;

namespace Adyen.Models;

public record TransactionstatusResponse1
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
