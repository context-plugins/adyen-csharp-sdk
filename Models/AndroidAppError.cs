using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record AndroidAppError
{
    /// <summary>
    /// The error code of the Android app with the <c>status</c> of either <b>error</b> or <b>invalid</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errorCode")]
    public string? ErrorCode { get; init; }

    /// <summary>
    /// The list of payment terminal models to which the returned <c>errorCode</c> applies.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("terminalModels")]
    public IReadOnlyList<string>? TerminalModels { get; init; }
}
