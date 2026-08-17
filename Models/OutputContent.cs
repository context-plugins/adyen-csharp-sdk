using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// Content to display or print.
/// This is a sequence of elements if they have different formats.
/// </summary>
public record OutputContent
{
    /// <summary>
    /// Format of the content to display or print.
    /// Possible values:
    /// * <b>BarCode</b>
    /// * <b>MessageRef</b>
    /// * <b>Text</b>
    /// * <b>XHTML</b>
    /// </summary>
    [JsonPropertyName("OutputFormat")]
    public required OutputFormat1 OutputFormat { get; init; }

    /// <summary>
    /// Reference of a predefined message to display or print.
    /// Mandatory, if <c>OutputFormat</c> is MessageRef, not allowed otherwise.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("PredefinedContent")]
    public PredefinedContent1? PredefinedContent { get; init; }

    /// <summary>
    /// Content of text message to display or print.
    /// Mandatory, if <c>OutputFormat</c> is Text, not allowed otherwise. One instance of <c>OutputText</c> per shared format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("OutputText")]
    public IReadOnlyList<OutputText>? OutputText { get; init; }

    /// <summary>
    /// XHTML document body containing the message to display or print.
    /// Mandatory if <c>OutputFormat</c> is XHTML, not allowed otherwise.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("OutputXHTML")]
    [RegularExpression("^.{0,262144}$")]
    public string? OutputXhtml { get; init; }

    /// <summary>
    /// Barcode content to display or print.
    /// Mandatory if <c>OutputFormat</c> is Barcode, not allowed otherwise.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("OutputBarcode")]
    public OutputBarcode1? OutputBarcode { get; init; }
}
