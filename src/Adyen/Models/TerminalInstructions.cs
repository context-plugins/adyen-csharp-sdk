using System.Text.Json.Serialization;

namespace Adyen.Models;

public record TerminalInstructions
{
    /// <summary>
    /// Indicates whether the Adyen app on the payment terminal restarts automatically when the configuration is updated.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("adyenAppRestart")]
    public bool? AdyenAppRestart { get; init; }
}
