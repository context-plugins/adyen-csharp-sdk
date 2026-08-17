using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Body of the Abort Request message.
/// It conveys Information requested for identification of the message request carrying the transaction to abort. A message to display on the CustomerError Device could be sent by the Sale System (DisplayOutput).
/// </summary>
public record AbortRequest
{
    /// <summary>
    /// Identification of a previous POI transaction.
    /// </summary>
    [JsonPropertyName("MessageReference")]
    public required MessageReference4 MessageReference { get; init; }

    /// <summary>
    /// Reason of aborting a transaction.
    /// </summary>
    [JsonPropertyName("AbortReason")]
    [RegularExpression("^.+$")]
    public required string AbortReason { get; init; }

    /// <summary>
    /// Information to display and the way to process the display.
    /// To display an abort message to the Customer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("DisplayOutput")]
    public DisplayOutput1? DisplayOutput { get; init; }
}
