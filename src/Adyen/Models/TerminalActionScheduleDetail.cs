using System.Text.Json.Serialization;

namespace Adyen.Models;

public record TerminalActionScheduleDetail
{
    /// <summary>
    /// The ID of the action on the specified terminal.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// The unique ID of the terminal that the action applies to.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("terminalId")]
    public string? TerminalId { get; init; }
}
