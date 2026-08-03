using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// Content to display or print.
/// </summary>
public record OutputContent1
{
    [JsonPropertyName("OutputFormat")]
    public required OutputFormat1 OutputFormat { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("PredefinedContent")]
    public PredefinedContent2? PredefinedContent { get; init; }

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

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("OutputBarcode")]
    public OutputBarcode? OutputBarcode { get; init; }
}
