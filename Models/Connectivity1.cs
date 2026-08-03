using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// Settings for terminal connectivity features.
/// </summary>
public record Connectivity1
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("simcardStatus")]
    public SimcardStatus? SimcardStatus { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("terminalIPAddressURL")]
    public EventUrl? TerminalIpaddressUrl { get; init; }
}
