using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record ApproveTransfersRequest
{
    /// <summary>
    /// Contains the unique identifiers of the transfers that you want to approve.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transferIds")]
    public IReadOnlyList<string>? TransferIds { get; init; }
}
