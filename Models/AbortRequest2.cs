using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Content of the Abort Request message.
/// </summary>
public record AbortRequest2
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
