using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record GetTermsOfServiceDocumentResponse
{
    /// <summary>
    /// The Terms of Service document in Base64-encoded format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("document")]
    public string? Document { get; init; }

    /// <summary>
    /// The unique identifier of the legal entity.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// The language used for the Terms of Service document, specified by the two-letter <see href="https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes">ISO 639-1</see> language code. Possible value: <b>en</b> for English or <b>fr</b> for French.
    /// <para>
    /// Note that French is only available for some integration types in certain countries/regions. Reach out to your Adyen contact for more information.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("language")]
    public string? Language { get; init; }

    /// <summary>
    /// The format of the Terms of Service document.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("termsOfServiceDocumentFormat")]
    public string? TermsOfServiceDocumentFormat { get; init; }

    /// <summary>
    /// The unique identifier of the Terms of Service document.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("termsOfServiceDocumentId")]
    public string? TermsOfServiceDocumentId { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public Type25? Type { get; init; }
}
