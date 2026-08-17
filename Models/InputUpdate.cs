using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Definition: Content of the Input Update message. : It conveys
/// update of the display of an Input request in progress.
/// </summary>
public record InputUpdate
{
    /// <summary>
    /// Identification of a previous POI transaction.
    /// To abort a transaction in progress or to request the status of a transaction from which no response has been received. It identifies the message header of the message request to abort or request the status.
    /// </summary>
    [JsonPropertyName("MessageReference")]
    public required MessageReference MessageReference { get; init; }

    /// <summary>
    /// Content to display or print.
    /// This is a sequence of elements if they have different formats.
    /// </summary>
    [JsonPropertyName("OutputContent")]
    public required OutputContent OutputContent { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("MenuEntry")]
    public IReadOnlyList<MenuEntry>? MenuEntry { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("OutputSignature")]
    [RegularExpression("^.+$")]
    public string? OutputSignature { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("MinLength")]
    public int? MinLength { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("MaxLength")]
    public int? MaxLength { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("MaxDecimalLength")]
    public int? MaxDecimalLength { get; init; }
}
