using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// Contains the status of the grant.
/// </summary>
public record Status22
{
    /// <summary>
    /// A list of actions that need to be completed to proceed with the grant.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("actions")]
    public IReadOnlyList<Action1>? Actions { get; init; }

    [JsonPropertyName("code")]
    public required Code Code { get; init; }
}
