using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record CancelTransfersRequest
{
    /// <summary>
    /// Contains the unique identifiers of the transfers that you want to cancel.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transferIds")]
    public IReadOnlyList<string>? TransferIds { get; init; }
}
