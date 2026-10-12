using System.Text.Json.Serialization;
using Adyen.Core.Models;
using Adyen.Core.Validation.Attributes;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// Content of text message to display or print.
/// It conveys information related to the content of the text message and its format. All the data elements related to the format of the text to display or print are parameters valid for the whole text content.
/// </summary>
public record OutputText
{
    /// <summary>
    /// Content of text message to display, print or play.
    /// </summary>
    [JsonPropertyName("Text")]
    public required string Text { get; init; }

    /// <summary>
    /// Character height of the text string to display or print. Absence of this data element means the characters have normal height.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("CharacterSet")]
    public int? CharacterSet { get; init; }

    /// <summary>
    /// Row where the text string has to be displayed or printed.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("StartRow")]
    [Minimum(1)]
    [Maximum(500)]
    public int? StartRow { get; init; }

    /// <summary>
    /// Column where the text string has to be displayed or printed.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("StartColumn")]
    [Minimum(1)]
    [Maximum(500)]
    public int? StartColumn { get; init; }

    /// <summary>
    /// Character width of the text string to display or print. Absence of this data element means the characters have normal width.
    /// Possible values:
    /// * <b>DoubleWidth</b>
    /// * <b>SingleWidth</b>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("CharacterWidth")]
    public CharacterWidth1? CharacterWidth { get; init; }

    /// <summary>
    /// Character height of the text string to display or print. Absence of this data element means the characters have normal height.
    /// Possible values:
    /// * <b>DoubleHeight</b>
    /// * <b>HalfHeight</b>
    /// * <b>SingleHeight</b>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("CharacterHeight")]
    public CharacterHeight1? CharacterHeight { get; init; }

    /// <summary>
    /// Typographic style of the sequence of characters to display or print. Absence of this data element means the characters have normal style.
    /// Possible values:
    /// * <b>Bold</b>
    /// * <b>Italic</b>
    /// * <b>Normal</b>
    /// * <b>Underline</b>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("CharacterStyle")]
    public CharacterStyle1? CharacterStyle { get; init; }

    /// <summary>
    /// Alignment of the text string on the display line or print line. Absence of this data element means the characters have normal alignment.
    /// Possible values:
    /// * <b>Centred</b>
    /// * <b>Justified</b>
    /// * <b>Left</b>
    /// * <b>Right</b>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("Alignment")]
    public Alignment1? Alignment { get; init; }

    /// <summary>
    /// Indicates if the text is at the end of a line. Allows the display or the print of a new line and a carry-over return characters after the formatted text.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("EndOfLineFlag")]
    public bool? EndOfLineFlag { get; init; } = true;

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
