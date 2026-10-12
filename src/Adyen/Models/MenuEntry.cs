using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Core.Models;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// An entry of the menu to present to the Cashier.
/// It conveys message text and parameters of the menu entry. This output data could be only provided for an input command, in order to choose an entry of the menu.
/// </summary>
public record MenuEntry
{
    /// <summary>
    /// Characteristics related to the selection of a menu entry.
    /// Possible values:
    /// * <b>NonSelectable</b>
    /// * <b>NonSelectableSubMenu</b>
    /// * <b>Selectable</b>
    /// * <b>SubMenu</b>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("MenuEntryTag")]
    public MenuEntryTag1? MenuEntryTag { get; init; }

    /// <summary>
    /// Selection of a menu entry to be displayed. In Input request message, it allows selection of one or several menu entries before any user action.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("DefaultSelectedFlag")]
    public bool? DefaultSelectedFlag { get; init; } = false;

    /// <summary>
    /// Possible values:
    /// * <b>BarCode</b>
    /// * <b>MessageRef</b>
    /// * <b>Text</b>
    /// * <b>XHTML</b>
    /// </summary>
    [JsonPropertyName("OutputFormat")]
    public required OutputFormat2 OutputFormat { get; init; }

    /// <summary>
    /// Reference of a predefined message to display or print.
    /// It conveys information related to the predefined message.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("PredefinedContent")]
    public PredefinedContent? PredefinedContent { get; init; }

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

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
