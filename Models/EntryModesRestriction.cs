using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record EntryModesRestriction
{
    /// <summary>
    /// Defines how the condition must be evaluated.
    /// </summary>
    [JsonPropertyName("operation")]
    public required string Operation { get; init; }

    /// <summary>
    /// List of point-of-sale entry modes.
    /// <para>
    /// Possible values: <b>barcode</b>, <b>chip</b>, <b>cof</b>, <b>contactless</b>, <b>magstripe</b>, <b>manual</b>, <b>ocr</b>, <b>server</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("value")]
    public IReadOnlyList<Value2>? Value { get; init; }
}
