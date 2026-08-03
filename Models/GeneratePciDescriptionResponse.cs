using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record GeneratePciDescriptionResponse
{
    /// <summary>
    /// The generated questionnaires in a base64 encoded format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("content")]
    public string? Content { get; init; }

    /// <summary>
    /// The two-letter <see href="https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes">ISO-639-1</see> language code for the questionnaire. For example, <b>en</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("language")]
    public string? Language { get; init; }

    /// <summary>
    /// The array of Adyen-generated unique identifiers for the questionnaires. If empty, the user is not required to sign questionnaires.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pciTemplateReferences")]
    public IReadOnlyList<string>? PciTemplateReferences { get; init; }
}
