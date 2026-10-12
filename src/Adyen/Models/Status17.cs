using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Core.Models;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record Status17
{
    /// <summary>
    /// A list of actions that need to be completed to proceed with the grant.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("actions")]
    public IReadOnlyList<Action1>? Actions { get; init; }

    /// <summary>
    /// The code for the status of the grant. Possible values:
    /// - <b>Pending</b>
    /// - <b>Active</b>
    /// - <b>Repaid</b>
    /// - <b>WrittenOff</b>
    /// - <b>Failed</b>
    /// - <b>Revoked</b>
    /// - <b>Requested</b>
    /// - <b>Reviewing</b>
    /// - <b>Approved</b>
    /// - <b>Rejected</b>
    /// - <b>Cancelled</b>
    /// </summary>
    [JsonPropertyName("code")]
    public required Code Code { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
