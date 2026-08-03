using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Settings to define the behaviour of the payment terminal.
/// </summary>
public record TerminalInstructions1
{
    /// <summary>
    /// Indicates whether the Adyen app on the payment terminal restarts automatically when the configuration is updated.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("adyenAppRestart")]
    public bool? AdyenAppRestart { get; init; }
}
