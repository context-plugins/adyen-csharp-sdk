using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// Configures sending event notifications by pressing a button on a terminal, for example used for pay-at-table.
/// </summary>
public record Notification2
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("category")]
    public Category1? Category { get; init; }

    /// <summary>
    /// The text shown in the prompt which opens when you select the notification button. For example, the description of the input box for pay-at-table.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("details")]
    public string? Details { get; init; }

    /// <summary>
    /// Enables sending event notifications either by pressing the Confirm key on terminals with a keypad or by tapping the event notification button on the terminal screen.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; init; }

    /// <summary>
    /// Shows or hides the event notification button on the screen of terminal models that have a keypad.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("showButton")]
    public bool? ShowButton { get; init; }

    /// <summary>
    /// The name of the notification button on the terminal screen.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("title")]
    public string? Title { get; init; }
}
