using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record ListExternalTerminalActionsResponse
{
    /// <summary>
    /// The list of terminal actions.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("data")]
    public IReadOnlyList<ExternalTerminalAction>? Data { get; init; }
}
