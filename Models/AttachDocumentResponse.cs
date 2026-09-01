using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

public record AttachDocumentResponse
{
    /// <summary>
    /// The unique identifier of the attachment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("attachmentId")]
    public string? AttachmentId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
