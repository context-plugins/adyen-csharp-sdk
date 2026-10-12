using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

public record DefenseDocument
{
    /// <summary>
    /// The content of the defense document.
    /// </summary>
    [JsonPropertyName("content")]
    public required string Content { get; init; }

    /// <summary>
    /// The content type of the defense document.
    /// </summary>
    [JsonPropertyName("contentType")]
    public required string ContentType { get; init; }

    /// <summary>
    /// The document type code of the defense document.
    /// </summary>
    [JsonPropertyName("defenseDocumentTypeCode")]
    public required string DefenseDocumentTypeCode { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
