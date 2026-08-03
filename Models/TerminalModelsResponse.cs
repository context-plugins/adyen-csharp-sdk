using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record TerminalModelsResponse
{
    /// <summary>
    /// The terminal models that the API credential has access to.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("data")]
    public IReadOnlyList<NetworkTokenRequestor>? Data { get; init; }
}
