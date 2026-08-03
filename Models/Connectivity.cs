using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record Connectivity
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("simcardStatus")]
    public SimcardStatus? SimcardStatus { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("terminalIPAddressURL")]
    public EventUrl? TerminalIpaddressUrl { get; init; }
}
