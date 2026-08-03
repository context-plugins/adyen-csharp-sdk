using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Body of the Abort Request message.
/// It conveys Information requested for identification of the message request carrying the transaction to abort. A message to display on the CustomerError Device could be sent by the Sale System (DisplayOutput).
/// </summary>
public record AbortRequest
{
    [JsonPropertyName("MessageReference")]
    public required MessageReference1 MessageReference { get; init; }

    /// <summary>
    /// Reason of aborting a transaction.
    /// </summary>
    [JsonPropertyName("AbortReason")]
    [RegularExpression("^.+$")]
    public required string AbortReason { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("DisplayOutput")]
    public DisplayOutput3? DisplayOutput { get; init; }
}
