using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record GetTermsOfServiceDocumentRequest
{
    /// <summary>
    /// The language to be used for the Terms of Service document, specified by the two-letter <see href="https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes">ISO 639-1</see> language code. Possible values: <b>en</b> for English or <b>fr</b> for French.
    /// </summary>
    [JsonPropertyName("language")]
    public required string Language { get; init; }

    /// <summary>
    /// The requested format for the Terms of Service document. Default value: JSON. Possible values: <b>JSON</b>, <b>PDF</b>, or <b>TXT</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("termsOfServiceDocumentFormat")]
    public string? TermsOfServiceDocumentFormat { get; init; }

    [JsonPropertyName("type")]
    public required Type25 Type { get; init; }
}
