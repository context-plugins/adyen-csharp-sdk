using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record GetAcceptedTermsOfServiceDocumentResponse
{
    /// <summary>
    /// The accepted Terms of Service document in the requested format represented as a Base64-encoded bytes array.
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
    /// An Adyen-generated reference for the accepted Terms of Service.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("termsOfServiceAcceptanceReference")]
    public string? TermsOfServiceAcceptanceReference { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("termsOfServiceDocumentFormat")]
    public TermsOfServiceDocumentFormat? TermsOfServiceDocumentFormat { get; init; }
}
