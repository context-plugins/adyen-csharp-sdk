using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record ApproveTransferLimitRequest
{
    /// <summary>
    /// A list that includes the <c>transferLimitId</c> of all the pending transfer limits you want to approve.
    /// </summary>
    [JsonPropertyName("transferLimitIds")]
    [MinLength(1)]
    [MaxLength(2147483647)]
    public required IReadOnlyList<string> TransferLimitIds { get; init; }
}
