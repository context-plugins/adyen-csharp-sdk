using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// An entry of the menu to present to the Cashier.
/// It conveys message text and parameters of the menu entry. This output data could be only provided for an input command, in order to choose an entry of the menu.
/// </summary>
public record MenuEntry
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("MenuEntryTag")]
    public MenuEntryTag1? MenuEntryTag { get; init; }

    /// <summary>
    /// Selection of a menu entry to be displayed. In Input request message, it allows selection of one or several menu entries before any user action.
    /// </summary>
    [JsonPropertyName("DefaultSelectedFlag")]
    public bool? DefaultSelectedFlag { get; init; } = false;

    [JsonPropertyName("OutputFormat")]
    public required OutputFormat2 OutputFormat { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("PredefinedContent")]
    public PredefinedContent2? PredefinedContent { get; init; }

    /// <summary>
    /// Content of text message to display or print. It conveys Information related to the content of the text message and its format. All the data elements related to the format of the text to display or print are parameters valid for the whole Text content.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("OutputText")]
    public IReadOnlyList<OutputText>? OutputText { get; init; }

    /// <summary>
    /// XHTML document body containing the message to display or print.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("OutputXHTML")]
    [RegularExpression("^.+$")]
    public string? OutputXhtml { get; init; }
}
